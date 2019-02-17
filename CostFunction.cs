using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleVariableLinearRegression
{
    class CostFunction
    {
        public double CostFunctionFromSet(double[] theta, List<double[]> Xy)
        {
            //Perform the cost function for every datapoint in the list applying the relavent thetas. 
            var m = (double)Xy.Count;
            double sum = 0;
            foreach(double[] xyi in Xy)
            {
                var x = xyi[0];
                var y = xyi[1];
                var hOfTheta = theta[0] + theta[1] * x;
                sum += Math.Pow(y - hOfTheta, 2);
            }
            return sum * (1 / (2 * m));
        }

        public double BaseLineErrorFunctionFromSet(double[] theta, List<double[]> Xy)
        {
            //Calculate the mean for the set. 
            var m = (double)Xy.Count;
            double sum_avg = 0;
            foreach (double[] xyi in Xy)
            {
                var x = xyi[0];
                sum_avg += x;
            }
            var average = sum_avg * (1 / m);

            double sum = 0;
            foreach (double[] xyi in Xy)
            {
                var y = xyi[1];
                sum += Math.Pow(y - average, 2);
            }
            return sum * (1 / (2 * m));

        }
    }
}