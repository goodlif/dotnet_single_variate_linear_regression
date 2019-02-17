using System;

namespace dotnet_single_variate_linear_regression
{
    class Program
    {
        static void Main(string[] args)
        {
           static ReadData dataReader = new ReadData();
        static CostFunction costFunction = new CostFunction();
        static GradientDescent gradientDescent = new GradientDescent();

        static CostFunction_1 costFunction_1 = new CostFunction_1();
        static GradientDescent_1 gradientDescent_1 = new GradientDescent_1();

        static CostFunction_2 costFunction_2 = new CostFunction_2();
        static GradientDescent_2 gradientDescent_2 = new GradientDescent_2();

        static CostFunction_3 costFunction_3 = new CostFunction_3();
        static GradientDescent_3 gradientDescent_3 = new GradientDescent_3();

        static CostFunction_4 costFunction_4 = new CostFunction_4();
        static GradientDescent_4 gradientDescent_4 = new GradientDescent_4();

        static CostFunction_5 costFunction_5 = new CostFunction_5();
        static GradientDescent_5 gradientDescent_5 = new GradientDescent_5();

        static CostFunction_6 costFunction_6 = new CostFunction_6();
        static GradientDescent_6 gradientDescent_6 = new GradientDescent_6();

        static double[] theta = { 0, 0 }; // {theta1, theta2}
        static (double theta0, double theta1) coefficients = (theta0: 0, theta1: 0);
        private static (double theta0, double theta1) computedTheta_2;
        private static double[] computedTheta;

        static void Main(string[] args)
        {

            var data = dataReader.ReadInData();

            //Set up your initial parameters
            var iterations = 1500;
            var alpha = 0.01;

            Console.WriteLine($" Test : {costFunction.CostFunctionFromSet(new double[] { -1, 2 }, data)}");
            
            //step 4 perform gradient descent
            computedTheta = gradientDescent.RunGradientDescent(data, theta, alpha, iterations);

            Console.WriteLine($" Submission 0 - FinalTheta 1 : {computedTheta[0]} FinalTheta 2 : {computedTheta[1]} ");

            Console.WriteLine($" Cost : {costFunction.CostFunctionFromSet(computedTheta, data)}");

            //step 6 calculate R^2 term. 
            var r_squarred = (1 - (costFunction.CostFunctionFromSet(computedTheta, data) / costFunction.BaseLineErrorFunctionFromSet(computedTheta, data))) * 100;

            Console.WriteLine($"R_SQUARRED: {r_squarred}%");

            //R^2 should be > 50%

            //step 7 use optimal theta to guess a Y
            var x = 7;
            var y = computedTheta[0] + x * computedTheta[1];
            // your answer should be around 4.46 

            Console.WriteLine($"For a population of X=7 (10 000s) our estimated profit is ${y} ($10 000s)");
            Console.ReadLine();

        }
    }
}
