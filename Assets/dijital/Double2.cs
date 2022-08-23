using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace bigdigital
{
    public class Double2
    {
        public double digital1;
        public decimal digital2;
        public static string getstring(Double2 count)
        {
            string set = "";
            if (count.digital2 != 0)
            {
                set = "d" + count.digital2.ToString();
            }
            if (count.digital2 < 0)
            {
                set = count.digital1.ToString();
            }
            if (count.digital2 == 0)
            {
                set = count.digital1.ToString() + "d" + count.digital2.ToString();
            }
            return set;

        }
        public static Double2 adddouble(Double2 count, double d)
        {
            Double2 d2 = count;
            Double2 d22 = new Double2();
            d22.digital1 += d + d2.digital1;
            if (d22.digital1 >= double.MaxValue / 2)
            {
                Double2 d23 = new Double2();
                d23.digital2 += 1;
                d2.digital2 += d23.digital2;
                d2.digital1 = 0;
            }
            else if (d > 0)
            {
                Double2 d23 = new Double2();
                d23.digital1 += d;
                d2.digital1 += d23.digital1;
            }
            if (d22.digital1 <= double.MinValue / 2)
            {
                Double2 d23 = new Double2();
                d23.digital2 -= 1;
                d2.digital2 += d23.digital2;
                d2.digital1 = double.MinValue;
            }
            else if (d < 0)
            {
                Double2 d23 = new Double2();
                d23.digital1 += d;
                d2.digital1 += d23.digital1;
            }

            return d2;
        }
        public static Double2 addlong(Double2 count, long d)
        {
            Double2 d2 = count;
            Double2 d22 = new Double2();
            d22.digital1 += d + d2.digital1;
            if (d22.digital1 >= double.MaxValue / 2)
            {
                Double2 d23 = new Double2();
                d23.digital2 += 1;
                d2.digital2 += d23.digital2;
                d2.digital1 = 0;
            }
            else if (d > 0)
            {
                Double2 d23 = new Double2();
                d23.digital1 += d;
                d2.digital1 += d23.digital1;
            }
            if (d22.digital1 <= double.MinValue / 2)
            {
                Double2 d23 = new Double2();
                d23.digital2 -= 1;
                d2.digital2 += d23.digital2;
                d2.digital1 = double.MinValue;
            }
            else if (d < 0)
            {
                Double2 d23 = new Double2();
                d23.digital1 += d;
                d2.digital1 += d23.digital1;
            }

            return d2;
        }
        public static Double2 addfloat(Double2 count, float d)
        {
            Double2 d2 = count;
            Double2 d22 = new Double2();
            d22.digital1 += d + d2.digital1;
            if (d22.digital1 >= double.MaxValue / 2)
            {
                Double2 d23 = new Double2();
                d23.digital2 += 1;
                d2.digital2 += d23.digital2;
                d2.digital1 = 0;
            }
            else if (d > 0)
            {
                Double2 d23 = new Double2();
                d23.digital1 += d;
                d2.digital1 += d23.digital1;
            }
            if (d22.digital1 <= double.MinValue / 2)
            {
                Double2 d23 = new Double2();
                d23.digital2 -= 1;
                d2.digital2 += d23.digital2;
                d2.digital1 = double.MinValue;
            }
            else if (d < 0)
            {
                Double2 d23 = new Double2();
                d23.digital1 += d;
                d2.digital1 += d23.digital1;
            }

            return d2;
        }
        public static Double2 addint(Double2 count, int d)
        {
            Double2 d2 = count;
            Double2 d22 = new Double2();
            d22.digital1 += d + d2.digital1;
            if (d22.digital1 >= double.MaxValue / 2)
            {
                Double2 d23 = new Double2();
                d23.digital2 += 1;
                d2.digital2 += d23.digital2;
                d2.digital1 = 0;
            }
            else if (d > 0)
            {
                Double2 d23 = new Double2();
                d23.digital1 += d;
                d2.digital1 += d23.digital1;
            }
            if (d22.digital1 <= double.MinValue / 2)
            {
                Double2 d23 = new Double2();
                d23.digital2 -= 1;
                d2.digital2 += d23.digital2;
                d2.digital1 = double.MinValue;
            }
            else if (d < 0)
            {
                Double2 d23 = new Double2();
                d23.digital1 += d;
                d2.digital1 += d23.digital1;
            }

            return d2;

        }

        public static string v5tostring(Double2 v5s)
        {
            Double2 b5 = new Double2();
            string s = "";
            b5.digital2 = v5s.digital2;
            b5.digital1 = v5s.digital1;

            s += JsonUtility.ToJson(b5);
            return s;
        }
        public static Double2 stringtov5(string v5s)
        {
            Double2 b5 = new Double2();

            b5 = JsonUtility.FromJson<Double2>(v5s);




            return b5;

        }
        public static Double2 setmax(Double2 count)
        {
            Double2 set = count;
            
                set.digital1 = double.MaxValue;
                set.digital2 = decimal.MaxValue;
            

            return set;

        }
        public static Double2 setmin(Double2 count)
        {
            Double2 set = count;
            
                set.digital1 = double.MinValue;
                set.digital2 = decimal.MinValue;
            

            return set;

        }
    }
}
