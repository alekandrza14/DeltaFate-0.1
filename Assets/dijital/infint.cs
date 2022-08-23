using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bigdigital
{
    public class infint
    {
        public int digital1;
        public int digital2;

        public static string getstring(infint count)
        {
            string set = "";
            if (count.digital2 != 0)
            {
                set = count.digital2.ToString()+"."+ count.digital1.ToString();
            }
            if (count.digital2 == 0)
            {
                set ="0."+ count.digital1.ToString();
            }

            return set;

        }
      
        public static infint addint(infint count, int d)
        {
            infint d2 = count;
            infint d22 = new infint();
            d22.digital1 += d + d2.digital1;
            if (d22.digital1 >= int.MaxValue / 2 && d > 0)
            {
                infint d23 = new infint();
                d23.digital2 += 1;
                d2.digital2 += d23.digital2;
                d2.digital1 = 0;
            }
            if (d>0) 
            {
                infint d23 = new infint();
                d23.digital1 += d;
                d2.digital1 += d23.digital1;
            }
            if (d22.digital1 <= 0 && d < 0)
            {
                infint d23 = new infint();
                d23.digital2 -= 1;
                d2.digital2 += d23.digital2;
                d2.digital1 = int.MaxValue / 2;
                d2.digital1 -= 1;
            }
            if (d < 0)
            {
                infint d23 = new infint();
                d23.digital1 += d;
                d2.digital1 += d23.digital1;
                
            }
            if (d2.digital2 <=-1 && d2.digital1 >= 0)
            {
                d2.digital1 = 0; 
                d2.digital2 = 0;
            }
            



            return d2;

        }

        public static string v5tostring(infint v5s)
        {
            infint b5 = new infint();
            string s = "";
            b5.digital2 = v5s.digital2;
            b5.digital1 = v5s.digital1;

            s += JsonUtility.ToJson(b5);
            return s;
        }
        public static infint stringtov5(string v5s)
        {
            infint b5 = new infint();

            b5 = JsonUtility.FromJson<infint>(v5s);




            return b5;

        }
        public static infint setmax(infint count)
        {
            infint set = count;

            set.digital1 = int.MaxValue;
            set.digital2 = int.MaxValue;


            return set;

        }
        public static infint setmin(infint count)
        {
            infint set = count;

            set.digital1 = int.MinValue;
            set.digital2 = int.MinValue;


            return set;

        }
    }
}

