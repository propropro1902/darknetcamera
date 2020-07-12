using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class customMeter
    {
        private readonly double[] record;
        private readonly int length;
        private int filled;
        private int index;


        public customMeter(int len)
        {
            record = new double[len];
            length = len;
        }

        public void add(double value)
        {
            record[index] = value;
            index = (index + 1) % length;
            filled++;
        }

        public double getAverage()
        {
            double total = 0;
            if (filled >= length)
            {
                for (int i = 0; i < length; i++)
                {
                    total += record[i];
                }
                return total / length;
            }
            else
            {
                int count = 0;
                for (int i = 0; i < length; i++)
                {
                    if (record[i] != -1)
                    {
                        total += record[i];
                        count += 1;
                    }
                }
                return total / count;
            }
        }

        public void reset()
        {
            for (int i = 0; i < length; i++)
            {
                record[i] = -1;
            }

            index = 0;
            filled = 0;
        }

        public int getFilled()
        {
            return filled;
        }

        public int getLength()
        {
            return length;
        }

    }
}
