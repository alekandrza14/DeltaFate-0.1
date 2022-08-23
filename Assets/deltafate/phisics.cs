using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class phisics
{
    public static string ra = "/"; public static string rah = "*"; public static string fa = @"/n";
    static string script = "";
    public static string command;
    public static string jcommand;
    public static string xcommand;
    public static int i;
    public static int x;
    public static int x1 = 0;
    public static int updatestart;
    public static string savename;


    public static void start(string name, GameObject gameObject, int type)
    {
        if (type != 2)
        {
            if (File.Exists("res/scripts/" + name + ".unscript"))
            {
                savename = name;
                command = "";

                script = File.ReadAllText("res/scripts/" + name + ".unscript");
                Vector3 position = Vector3.zero;
                while (x != 4)
                {

                    if (script.Length >= i)
                    {


                        foreach (char litter in script.ToCharArray(i, 1))
                        {
                            command += litter;


                        }
                    }

                    
                    i += 1;
                    if (x == 0 && command == ra)
                    {

                        command = "";
                        x = 1;
                    }
                    if (x == 1 && command == "setp")
                    {

                        i += 1;
                        command = "";
                        x = 2;
                    }
                    if (x == 2 && command != ra)
                    {
                        if (script.Length >= i)
                        {

                            foreach (char litter in script.ToCharArray(i, 1))
                            {
                                if (litter != ra.ToCharArray(0, 1)[0] && litter != rah.ToCharArray(0, 1)[0])
                                {


                                    jcommand += litter;
                                }
                                
                                

                            }
                        }
                        command = "";

                    }
                    else if (x == 2)
                    {
                        



                        position = JsonUtility.FromJson<pos>(jcommand).v3;

                        x = 3;
                    }
                    if (x == 3)
                    {
                        if (type == 3)
                        {
                            gameObject.transform.position = position;
                        }
                        if (type == 4)
                        {
                            gameObject.transform.position = position;
                        }
                        x = 4;
                    }

                    

                }


            }
            

        }
    }
    public static void startupdate(string name, GameObject gameObject, Rigidbody2D r, int type)
    {
        
        if (File.Exists("res/scripts/" + name + ".unscript"))
        {
            command = "";
            jcommand = "";


            Vector3 position = Vector3.zero;


            if (savename != name)
            {
                if (type != 4)
                {
                    script = File.ReadAllText("res/scripts/" + name + ".unscript");
                    i = 0;
                    x = 0;
                }
            }



            while (updatestart == 0)
            {
                if (type != 3 && type != 1 && type != 0)
                {
                    
                    if (script.Length > i)
                    {


                        foreach (char litter in script.ToCharArray(i, 1))
                        {
                            
                                Debug.Log(command.ToString());

                                command += litter;
                            


                        }
                        
                        
                    }
                    if (x == 4 && command == fa)
                    {

                        command = "";
                        x = 5;
                    }
                    else if (x == 0 && type == 2)
                    {
                        x = 5;
                    }
                    



                    if (x == 5 && command == ra)
                    {

                        command = "";
                        x = 6;
                    }
                    
                    if (x == 6 && command == "addp")
                    {

                        i += 1;
                        
                        x = 7;
                    }

                    if (x == 7 && command != ra)
                    {
                        command = "";
                        if (script.Length > i)
                        {

                            foreach (char litter in script.ToCharArray(i, 1))
                            {
                                if (litter != ra.ToCharArray(0, 1)[0] && litter != rah.ToCharArray(0, 1)[0] && x1!=1)
                                {


                                    jcommand += litter;
                                }
                                else if (litter == rah.ToCharArray(0, 1)[0])
                                {
                                    command = "";
                                    i += 1;
                                    x1 = 1;



                                }
                            }



                        }
                        command = "";
                        if (x1 == 1)
                        {
                            if (script.Length > i)
                            {
                                if (script[i] != ra.ToCharArray(0, 1)[0])
                                {
                                    foreach (char litter in script.ToCharArray(i, 1))
                                    {





                                        if (command != ra)
                                        {


                                            command += litter;
                                        }
                                        Debug.Log(command.ToString());




                                        if (command == ra)
                                        {
                                            command = "";
                                            x1 = 0;

                                        }
                                        xcommand += command;
                                        command = "";

                                    }
                                }

                            }
                        }
                    }
                    else if (x == 7 && xcommand == "")
                    {
                        Debug.Log(jcommand);
                        position = JsonUtility.FromJson<pos>(jcommand).v3;

                        updatestart = 1;
                    }
                    if(x == 7 && xcommand != "" && command == ra)
                    {
                        Debug.Log(jcommand);
                        position = JsonUtility.FromJson<pos>(jcommand).v3 * float.Parse(xcommand);
                        
                        updatestart = 1;
                    }
                    
                    
                }

                i += 1;



            }
            i = 0;
            x = 0;
            x1 = 0;
            xcommand = "";
            jcommand = "";
            command = "";
            if (updatestart == 1)
            {
                if (type == 4)
                {
                    r.velocity = new Vector2(position.x,position.y);
                }
                if (type == 2)
                {
                    r.velocity = new Vector2(position.x, position.y);
                }
                updatestart = 0;
            }


            


            savename = name;
        }
    }
}

public class pos
{
    public Vector3 v3 = new Vector3();
}
