# SentimentSuite

Overview
------------
The SentimentSuite solution is a comprehensive sentiment analysis project built with ML.NET. It combines model training, evaluation, and deployment into separate subprojects, making it easy to build, train, and use a custom machine learning model for sentiment prediction.

Features
------------
Train Model: Use ML.NET Model Builder to train a sentiment analysis model.
Evaluate Model: Assess the model's performance and accuracy.
Predict Sentiment: Analyze text to predict positive or negative sentiment.
Reusable Model: Save and integrate the trained model into other applications.

Solution Structure
------------
SentimentSuite.TrainerUI : A project to train the sentiment analysis model using the ML.NET Model Builder within Visual Studio.
SentimentSuite.BuilderCode : A console application to train a custom ML.NET model programmatically, evaluate its accuracy, and predict sentiment for user-provided text.
SentimentSuite.AnalyzerConsole: A console app where users can input text to predict sentiment.
SentimentSuite.AnalyzerWeb: A web application for sentiment analysis via a web interface.

Getting Started
------------
Ensure you have .NET 6.0 or later and Visual Studio installed.
Install required NuGet packages (Microsoft.ML).
Prepare the dataset in .tsv format for training.
Use TrainerUI or BuilderCode to train a model and save it.
Integrate the trained model for sentiment predictions in your application.