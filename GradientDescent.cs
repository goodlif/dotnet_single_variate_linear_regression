using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleVariableLinearRegression
{
    class GradientDescent
    {
        public double[] RunGradientDescent(List<double[]> xy, double[] initial_theta , double alpha, int iterations)
        {
            double[] finalTheta = { initial_theta[0], initial_theta[1] };
            Console.WriteLine("GradientDescent for theta0 and theta1: ");
            for (int i = 0; i < iterations; i++)
            {
                finalTheta = IncrementalGradientStepping(finalTheta, xy, alpha);                              
            }

            return finalTheta;
        }

        private double[] IncrementalGradientStepping(double[] theta, List<double[]> xy, double alpha)
        {
            var m = (double)xy.Count();

            double initialResult1 = 0;
            double initialResult2 = 0;
            
            foreach(double[] xyi in xy)
            {
                double x = xyi[0];
                double y = xyi[1];

                initialResult1 += -1 * (1 / m) * (y - ((theta[1] * x) + theta[0]));
                initialResult2 += -1 * (1 / m) * x * (y - ((theta[1] * x) + theta[0]));
            }

            return new double[] { theta[0] - (alpha * initialResult1), theta[1] - (alpha* initialResult2) };
        }
    }
}
