using Microsoft.ML;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        var mlContext = new MLContext();

        Console.WriteLine("Enter a sentence to analyze sentiment:");

        string? inputText = Console.ReadLine();

        if (!string.IsNullOrEmpty(inputText))
        {
            SentimentData sample = new SentimentData
            {
                SentimentText = inputText
            };

            // Load data
            var filePath = @"D:\Practice\MLNET\Projects\Sentiment\SentimentSuite\SentimentSuite.BuilderCode\DataSet\SentimentTrainingData.tsv";
            Log($"Loading data from file: {filePath}");
            var sentimentData = mlContext.Data.LoadFromTextFile<SentimentData>(
                path: filePath,
                hasHeader: true,
                separatorChar: '\t');
            Log("Data loaded successfully.");

            // Split data
            Log("Splitting data into training and testing sets...");
            var dataSplit = mlContext.Data.TrainTestSplit(sentimentData, testFraction: 0.2);
            IDataView trainData = dataSplit.TrainSet;
            IDataView testData = dataSplit.TestSet;
            Log("Data split into train and test sets.");

            // Create data transformation pipeline
            Log("Creating data transformation pipeline...");
            var estimator = mlContext.Transforms.Text.FeaturizeText(outputColumnName: "Features", inputColumnName: "SentimentText")
                            .Append(mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName: "Sentiment", featureColumnName: "Features"));
            Log("Data transformation pipeline created.");

            // Time-limited training
            Log("------- Starting model training with time limit ---------");
            var cancellationTokenSource = new CancellationTokenSource();
            int trainingSeconds = 30; // Customize the training duration in seconds
            cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(trainingSeconds));

            try
            {
                Task<ITransformer> trainingTask = Task.Run<ITransformer>(() =>
                {
                    return estimator.Fit(trainData);
                }, cancellationTokenSource.Token);

                if (trainingTask.Wait(TimeSpan.FromSeconds(trainingSeconds)))
                {
                    var model = trainingTask.Result;
                    Log("------- Model training completed successfully ---------");

                    // Evaluate model
                    EvaluateModel(mlContext, model, testData);

                    // Make a prediction
                    MakePrediction(mlContext, model, sample);

                    // Save model
                    SaveModel(mlContext, model, sentimentData.Schema);
                }
                else
                {
                    Log("Training did not complete within the allocated time.");
                }
            }
            catch (OperationCanceledException)
            {
                Log("Model training was cancelled due to time constraints.");
            }

        }
        Console.ReadLine();
    }

    private static void EvaluateModel(MLContext mlContext, ITransformer model, IDataView testData)
    {
        Log("=============== Starting model evaluation ===============");
        IDataView predictions = model.Transform(testData);
        var metrics = mlContext.BinaryClassification.Evaluate(predictions, "Sentiment");

        Log("Model Quality Metrics Evaluation:");
        Log("---------------------------------");
        Log($"Accuracy        : {metrics.Accuracy:P2}");
        Log($"AUC             : {metrics.AreaUnderRocCurve:P2}");
        Log($"F1 Score        : {metrics.F1Score:P2}");
        Log("=============== End of model evaluation ===============");
    }

    private static void MakePrediction(MLContext mlContext, ITransformer model, SentimentData sample)
    {
        var predictionFunction = mlContext.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(model);

        var resultPrediction = predictionFunction.Predict(sample);
        Log("Prediction result:");
        Log($"Sentiment Text  : {resultPrediction.SentimentText}");
        Log($"Prediction      : {(Convert.ToBoolean(resultPrediction.Prediction) ? "Positive" : "Negative")}");
        Log($"Prediction Prob : {resultPrediction.Probability:P2}");
        Log("--------------- End of prediction ---------------");
    }

    private static void SaveModel(MLContext mlContext, ITransformer model, DataViewSchema schema)
    {
        Log("Saving the trained model...");
        string modelPath = @"D:\Practice\MLNET\Projects\Sentiment\SentimentSuite\SentimentSuite.BuilderCode\SentimentMLModel.zip";
        mlContext.Model.Save(model, schema, modelPath);
        Log($"Model saved successfully at {modelPath}");
    }

    // Custom log method for consistent log format
    private static void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
    }
}
