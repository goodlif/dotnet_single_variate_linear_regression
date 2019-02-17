using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleVariableLinearRegression
{
    class ReadData
    {
        public List<double[]> ReadInData()
        {
            List<double[]> data = new List<double[]>();

            using (StreamReader reader = new StreamReader("DataSingle.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var value = reader.ReadLine().Split(',');

                    data.Add(
                        new double[]
                        {
                            double.Parse(value[0]),
                            double.Parse(value[1])
                        }
                    );
                }
            }

            return data;
        }
    }
}