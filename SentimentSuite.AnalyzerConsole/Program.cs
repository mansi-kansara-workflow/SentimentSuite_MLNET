
// Create single instance of sample data from first line of dataset for model input
using SentimentSuite_TrainerUI;

Console.WriteLine("Enter a sentence to analyze sentiment:");

string inputText = Console.ReadLine();

SentimentMLModel.ModelInput sampleData = new SentimentMLModel.ModelInput()
{
    SentimentText = inputText
};

Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");


var result = SentimentMLModel.Predict(sampleData);

var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.SentimentText}\nSentiment: {sentiment}");

Console.WriteLine(" =============== End of process, hit any key to finish ===============");

Console.ReadKey();

