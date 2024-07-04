// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string line="";
int intRecordCount=0;

// hello

try
    {
       // StreamReader sr = new StreamReader("D:\\TestDataInput.txt");
        StreamReader sr = new StreamReader("/users/davidchapa/code/textfiles/TestDataInput.txt");

    line = sr.ReadLine();

    while (line != null)
        {
   
           

            var values = line.Split(',');

            /*Console.WriteLine(values.Length);            
            Console.WriteLine(values[0]);
            Console.WriteLine(line);
            */

            int intFieldCount = 0;

            intRecordCount++;

            Console.WriteLine("Record#: {0}",intRecordCount);
            Console.WriteLine("Field count: {0}", values.Length);

            foreach  ( var item in values) 
            {
                intFieldCount++;
                Console.WriteLine("#: {0} Value: {1}",intFieldCount,item);
            }
            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.WriteLine();

            line = sr.ReadLine();

        }

        sr.Close();
    }

catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        Console.WriteLine(line.Length);
    }

finally

    {
        Console.WriteLine("Executing finally block");
    }

∂