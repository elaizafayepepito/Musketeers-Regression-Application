using System;
using System.Linq;
using Accord.Statistics.Models.Regression.Linear;

namespace MultipleRegressionExample
{
    class Regression
    {
        static void Reg(string[] args)
        {
            // define the data
            double[][] inputs =
            {
                new double[] { 1, 2, 3 },
                new double[] { 4, 5, 6 },
                new double[] { 7, 8, 9 },
                new double[] { 10, 11, 12 }
            };

            double[] outputs = { 5, 10, 15, 20 };

            // create a multiple linear regression model
            var regression = new MultipleLinearRegression();
            var regress = regression.Regress(inputs, outputs);

            // use the model to make predictions
            double[] input = { 2, 4, 6 };
            double prediction = regression.Transform(input);
            Console.WriteLine($"prediction: {prediction}");
        }
    }
}
