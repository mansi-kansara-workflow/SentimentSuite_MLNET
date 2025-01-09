Overview
------------
SentimentSuite.AnalyzerWeb is a web application built with ASP.NET Core that uses a pre-trained ML.NET model to analyze the sentiment of user-provided text. It predicts whether the sentiment of the input is Positive or Negative based on the model trained in SentimentSuite.TrainerUI.

Features
------------
Accepts user input via a web form for sentiment analysis.
Uses a pre-trained ML.NET model for sentiment prediction.
Displays the predicted sentiment (Positive/Negative) on the webpage.

Prerequisites
------------
.NET SDK 6.0 or higher
Visual Studio or any compatible IDE
SentimentSuite.TrainerUI project added as a reference
Basic knowledge of ASP.NET Core MVC architecture

How to Run
------------
1.Run the web application:
2.Enter a sentence when prompted:
	Enter a sentence to analyze sentiment:
	I love this product!
3.View the sentiment prediction:
	Prediction: Positive

Troubleshooting
------------
Model File Not Found: If you encounter a "Model File Not Found" issue, make sure the path to the model file (SentimentMLModel.mlnet) is correctly set in your project. The model file should be located in the bin\Debug\netX.X or bin\Release\netX.X directory after building the application. If the file is not found in the correct directory, change the directory to the working directory where the model is located to ensure the web app can access it.
	1.Right-click on the SentimentMLModel.mlnet file in Solution Explorer.
	2.Select Properties.
	3.Set Copy to Output Directory to Copy if newer or Copy always. This ensures the file is available in the build output.


