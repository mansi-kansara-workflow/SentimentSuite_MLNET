# Sentiment Analysis with Machine Learning ML.NET
## 🔍 Overview
The **SentimentSuite** is a sentiment analysis project built with  **ML.NET** that helps predict the sentiment of text (positive or negative). The solution is divided into several subprojects to handle different parts of the machine learning process: training, evaluation, deployment, and integration. It enables easy model building, training, and prediction of sentiments in various types of applications.

---

## 📖 Features

- **Train Model**: Train a sentiment analysis model using ML.NET Model Builder or custom code.
- **Evaluate Model**: Assess the performance and accuracy of the trained model.
- **Predict Sentiment**: Analyze text to determine positive or negative sentiment.
- **Reusable Model**: Save the trained model for use in other applications.

---

## 🛠️ Solution Structure (Projects)
### 1. SentimentSuite.TrainerUI
This project leverages ML.NET Model Builder within Visual Studio to provide an easy-to-use UI for training the sentiment analysis model. It helps users quickly train a model using a dataset.
### 2. SentimentSuite.BuilderCode
A console application that trains a custom sentiment analysis model programmatically. It evaluates the model's performance, saves it, and allows you to use the trained model for sentiment predictions.
### 3. SentimentSuite.AnalyzerConsole
A console application that takes user input (text) and uses the trained model to predict its sentiment (positive or negative). This project is useful for testing and demonstrating the model's capabilities in a command-line interface.
### 4. SentimentSuite.AnalyzerWeb
A web application that allows users to input text through a web interface, after which the trained model predicts the sentiment of the text. This project can be deployed as a web service or integrated into a web application.

---

## 🚀 Getting Started

1. **Install Prerequisites**:
   - Visual Studio : You can use either Visual Studio 2022 or 2019. However, Visual Studio 2022 is recommended for the latest features.
   - .NET SDK: Download and install the latest .NET SDK (currently version 8). This provides the development environment for building .NET applications.
2. **Install Required NuGet Package (Microsoft.ML)**:
 - Using NuGet Packages - Search for `Microsoft.ML`and install the latest stable version
 - Using the .NET CLI - dotnet add package Microsoft.ML 
3. **Install ML.NET Model Builder Extension (for Visual Studio)**
  - For a user-friendly visual approach, use the built-in ML.NET Model Builder extension in Visual Studio. This option simplifies creating and training your model directly within the IDE.
  - This is optional if you want to train your model visually using the ML.NET Model Builder extension in Visual Studio.
4. **Prepare Training Data**: 
   - Use a `.tsv` file containing text and sentiment labels. Datasource can be any file (`.csv`,` .tsv`, `.txt`) or `SQL Server`
5. **Train the Model**:
   - Use **SentimentSuite.TrainerUI** or **SentimentSuite.BuilderCode** to create and save a model.
   
6. **Evaluate the Model**:
   - Check its accuracy using evaluation tools in **AnalyzerConsole** and **AnalyzerWeb**.
7. **Predict Sentiment**:
   - Use **SentimentSuite.AnalyzerConsole** or **SentimentSuite.AnalyzerWeb** to predict sentiment for new text. Also you can check in **SentimentSuite.TrainerUI** or **SentimentSuite.BuilderCode**

--- 
## 🌐 Additional Resources

- [Overview of ML.NET](https://learn.microsoft.com/en-us/dotnet/machine-learning/overview)
