Overview
------------
SentimentSuite.BuilderCode is console application that trains a machine learning model to perform sentiment analysis using ML.NET. The program allows users to input a sentence, and it predicts whether the sentiment of the text is Positive or Negative based on a custom-trained model. The model is trained using a dataset of sentiment-labeled text and then used to predict sentiments for new text inputs.

Features
------------
Model Training: The program loads a dataset and trains a machine learning model using ML.NET to classify text as positive or negative.
Prediction: After training the model, the program uses it to predict the sentiment of a user-provided text input.
Model Saving: After successful training, the model is saved to a file for later use.
Data Evaluation: The model’s accuracy and other metrics are evaluated after training.
Time-limited Training: Training is performed within a specified time limit (30 seconds by default).

Prerequisites
------------
.NET SDK 6.0 or higher
Visual Studio or any compatible IDE
Access to the training dataset in .tsv format
Basic knowledge of machine learning concepts and ML.NET

Setup Instructions
------------
Make sure you have the training dataset SentimentTrainingData.tsv available at the specified path in the code:
..\SentimentSuite\SentimentSuite.BuilderCode\DataSet\SentimentTrainingData.tsv

Update the model save path if necessary in the following line:
..\SentimentSuite\SentimentSuite.BuilderCode\SentimentMLModel.zip

Install Package
--------------
Using NuGet Packages - Search for 'Microsoft.ML,' and install the latest stable version
Using the .NET CLI - dotnet add package Microsoft.ML

How to Run
------------
1.Run the console application:
2.Enter a sentence when prompted:
	Enter a sentence to analyze sentiment:
	I love this product!
3.View the sentiment prediction:
	Sentiment Text  : I love this product!
	Prediction      : Positive
	Prediction Prob : 85.00%

Troubleshooting
------------
Model File Not Found: 
	Ensure the model file path is correct, and the model is saved in the specified location:
	..\SentimentSuite\SentimentSuite.BuilderCode\SentimentMLModel.zip

Dataset Not Found: 
	Verify that the dataset file SentimentTrainingData.tsv exists at the specified path:
	..\SentimentSuite\SentimentSuite.BuilderCode\DataSet\SentimentTrainingData.tsv



