//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************
using System;
using SentimentAnalysis.Model;

namespace SentimentAnalysis.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a sentence for sentiment analysis
            Console.WriteLine("Enter a sentence for sentiment analysis:");
            string input = Console.ReadLine();

            // Create an instance of ModelInput with the user's input
            ModelInput sampleData = new ModelInput()
            {
                Col0 = input
            };

            // Make a prediction on the input data
            var predictionResult = ConsumeModel.Predict(sampleData);

            // Display the results
            Console.WriteLine("\nUsing model to make a prediction...\n");
            Console.WriteLine($"Input Sentence: {sampleData.Col0}");
            Console.WriteLine($"\nPredicted Sentiment: {(predictionResult.Prediction == "1" ? "Positive" : "Negative")}");
            Console.WriteLine($"Prediction Scores: [{String.Join(", ", predictionResult.Score)}]\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}


