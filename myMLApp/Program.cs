using System;
using MyMLAppML.Model;

namespace myMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            input.SentimentText = "I appreciate all the work you've done so far. It has been a great help.";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
        }
    }
}