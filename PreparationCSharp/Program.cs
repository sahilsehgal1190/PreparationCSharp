using System;

    class Program
    {
    static void Main(string[] args)
    {
        //string strNumber = "100";
        



   
        bool? AreYouMajor = null;

        if (AreYouMajor == true)
        {
            Console.WriteLine("User is Major");
        }
        else if (AreYouMajor == false)
        {
            Console.WriteLine("User is not Major");
        }
        else
        {
            Console.WriteLine("User did not answer the question");
        }
        Console.ReadLine();

        }
    }
