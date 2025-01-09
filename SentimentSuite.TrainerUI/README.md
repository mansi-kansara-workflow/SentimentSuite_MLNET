Overview
------------
SentimentSuite.TrainerUI is a project designed to train a machine learning model using ML.NET Model Builder (Visual Studio UI). The trained model can be used to predict values or integrate with other applications for sentiment analysis. This project demonstrates the complete process of building, training, evaluating, and deploying a custom sentiment analysis model.

Features
------------
Model Training: Train a custom machine learning model using the ML.NET Model Builder UI.
Prediction: Use the trained model to predict sentiment for new inputs.
Code Generation: Automatically generates reusable code files for model integration.
Model Deployment: Enables seamless deployment of the trained model to applications or services.

Prerequisites
------------
Visual Studio 2022 (or higher) with the ML.NET Model Builder extension installed.
.NET 6.0 or higher.
Access to a labeled dataset (e.g., SentimentTrainingData.tsv).

Setup Instructions
------------
Ensure the dataset file SentimentTrainingData.tsv is located in the DataSet folder:
..\SentimentSuite\SentimentSuite.TrainerUI\DataSet\SentimentTrainingData.tsv

Add Model Builder:
In the Solution Explorer, right-click on your project (e.g., SentimentSuite.TrainerUI).
Select Add → Machine Learning.

Install Package
--------------
Using NuGet Packages - Search for 'Microsoft.ML,' and install the latest stable version
Using the .NET CLI - dotnet add package Microsoft.ML


How to Use the Trained Model
------------
1.Add the generated files to your application.
2.Load the model using the SentimentMLModel class.
3.Provide input text for prediction:
	var prediction = SentimentMLModel.Predict(new SentimentData { Text = "I love this product!" });
	Console.WriteLine($"Prediction: {prediction.Prediction} | Probability: {prediction.Probability:P2}");
4.Deploy the application for real-time sentiment analysis.




