using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class savevartous
{
    private static string ra = "/";
    private static int x; private static int x2; private static int i; private static bool st = true;
    public static long usvarl(string path, long ldefult)
    {
        string command = ""; string lcommand = "";
        string xcommand = "";

        if (File.Exists(path))
        {



            while (File.ReadAllText(path).Length - 1 > i)
            {

                st = true;
                foreach (char litter in File.ReadAllText(path).ToCharArray(i, 1))
                {


                    if (x != 6 && x2 == 0)
                    {


                        lcommand += litter;
                        Debug.Log(lcommand);


                    }
                    if (x == 6 && x2 == 0 && litter.ToString() != ra)
                    {
                        lcommand = "";

                        lcommand += litter;
                        Debug.Log(lcommand);


                    }
                    if (x == 6 && x2 == 0 && litter.ToString() != ra)
                    {
                        xcommand += lcommand;
                        lcommand = "";
                    }
                    else if (x == 6 && x2 == 0 && litter.ToString() == ra)
                    {

                        i = File.ReadAllText(path).Length - 1;
                    }

                    if (x == 6 && x2 == 1)
                    {
                        xcommand = ldefult.ToString();
                        long s22 = 0;
                        i = File.ReadAllText(path).Length - 1;
                        lcommand = s22.ToString();
                    }


                }
                if (lcommand == ra && st == true && x == 0)
                {
                    x = 1;


                }
                else if (lcommand != ra && x == 0 && st == true)
                {
                    xcommand = ldefult.ToString();
                    i = File.ReadAllText(path).Length - 1;
                    Debug.LogError("error ra");
                    st = false;
                }
                if (x == 1)
                {
                    lcommand = "";
                    st = false;
                    x = 2;

                }
                if (lcommand == "l" && lcommand != "f" && x == 2 && st == true)
                {

                    x2 = 0;
                    x = 6;


                }
                
                else if (lcommand == "f" && x == 2 && st == true)
                {
                    savevartous.setusvarlong(path, true, 0);
                    xcommand = ldefult.ToString();
                    x2 = 1;
                    x = 6;




                }
                else if (lcommand != "l" && lcommand != "f" && st == true && x == 2)
                {
                    Debug.LogError("error f l");
                    i = File.ReadAllText(path).Length - 1;

                    if (ldefult != 0)
                    {
                        xcommand = ldefult.ToString();
                    }


                }

                i++;

            }
           

        }
        if (!File.Exists(path))
        {
            xcommand = ldefult.ToString();
        }
        i = 0;
        x = 0;
        x2 = 0;
        Debug.Log(xcommand);
        Debug.Log(x);
        return long.Parse(xcommand);
        lcommand = "";
        xcommand = "";
    }
    public static int usvar(string path, int defult)
    {
        string command = "";
        string xcommand = "";

        if (File.Exists(path))
        {



            while (File.ReadAllText(path).Length - 1 > i)
            {

                st = true;
                foreach (char litter in File.ReadAllText(path).ToCharArray(i, 1))
                {

                    if (x != 3 && x2 == 0)
                    {


                        command += litter;
                        Debug.Log(command);


                    }
                    if (x == 3 && x2 == 0 && litter.ToString() != ra)
                    {
                        command = "";

                        command += litter;
                        Debug.Log(command);


                    }
                    if (x == 3 && x2 == 0 && litter.ToString() != ra)
                    {
                        xcommand += command;
                        command = "";
                    }
                    else if (x == 3 && x2 == 0 && litter.ToString() == ra)
                    {

                        i = File.ReadAllText(path).Length - 1;
                    }

                    if (x == 3 && x2 == 1)
                    {
                        xcommand = defult.ToString();
                        int s22 = 0;
                        i = File.ReadAllText(path).Length - 1;
                        command = s22.ToString();
                    }



                }
                if (command == ra && st == true && x == 0)
                {
                    x = 1;


                }
                else if (command != ra && x == 0 && st == true)
                {
                    xcommand = defult.ToString();
                    i = File.ReadAllText(path).Length - 1;
                    Debug.LogError("error ra");
                    st = false;
                }
                if (x == 1)
                {
                    command = "";
                    st = false;
                    x = 2;

                }
                if (command == "a" && command != "f" && x == 2 && st == true)
                {

                    x2 = 0;
                    x = 3;


                }
                
                else if (command == "f" && x == 2 && st == true)
                {
                    savevartous.setusvar(path, true, 0);
                    xcommand = defult.ToString();
                    x2 = 1;
                    x = 3;




                }
                else if (command != "a" && command != "f" && st == true && x == 2)
                {
                    Debug.LogError("error f a");
                    i = File.ReadAllText(path).Length - 1;
                    xcommand = defult.ToString();
                    if (defult != 0)
                    {
                        xcommand = defult.ToString();
                    }


                }

                i++;

            }

        }
        else if (!File.Exists(path))
        {
            xcommand = defult.ToString();
        }


        i = 0;
        x = 0;
        x2 = 0;
        Debug.Log(xcommand);
        Debug.Log(x);
        return int.Parse(xcommand);
        command = "";
        xcommand = "";
    }
    public static void setusvar(string path, bool delete, int intejer)
    {
        Directory.CreateDirectory(@"DELTAFATE/var");
        string us = "";
        string b = "";
        if (delete == true)
        {

            b = "f";
            intejer = 0;
        }
        if (delete == false)
        {
            b = "a"; ;
        }
        us += ra + b + intejer.ToString() + ra;
        File.WriteAllText(path, us);
    }
    public static void setusvarlong(string path, bool delete, long intejer)
    {
        Directory.CreateDirectory(@"DELTAFATE/var");
        string us = "";
        string b = "";
        if (delete == true)
        {

            b = "f";
            intejer = 0;
        }
        if (delete == false)
        {
            b = "l"; ;
        }
        us += ra + b + intejer.ToString() + ra;
        File.WriteAllText(path, us);
    }
}
