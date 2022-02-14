using System;
using System.IO;
using System.Text;


namespace Day_15_Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\t ____::: Welcome To The Quiz Program By U.Joshna :::____\t\t\t\n");
            //Variable Declaration Section
            int score = 0, ans;
            string name;
            Console.Write(" Enter The Name Of The Participant : ");
            name = Console.ReadLine();

            
            Console.WriteLine($"\n\t\tHi {name}, You are About To begin The Quiz on Bhahubali Movie\n");




            //Question No:1
            Console.WriteLine("\nQ1. Which Characters Should watch in Bhahubali");
            
          Console.WriteLine("\n1. Bhahubali 2. Ballala Dheva 3.Rose 4.lilly");
           
          Console.Write("\nEnter Your Answer : ");
          ans = Convert.ToInt32(Console.ReadLine());
         if (ans == 1)
          score += 20;
            //Question No:2
            Console.WriteLine("\n\nQ2. Who is the Top Most Characters in Bhahubali Movie");
        Console.WriteLine("\n1.karthik   2.Sagar  3.Dhevasena 4. Kattappa");

            
        Console.Write("\nEnter Your Answer : ");
        ans = Convert.ToInt32(Console.ReadLine());
        if (ans == 2)
        score += 20;
            //Question No:3
            Console.WriteLine("\n\nQ What are the Characters inn Arya 2 Movie");
            Console.WriteLine(("\n1.Arya 2.Latha 3.Geetha 4.Sai"));
     Console.WriteLine("\nEnter Your Answer : ");
       ans = Convert.ToInt32(Console.ReadLine());
       if (ans == 3)
      score += 20;
            //Question No:4
            Console.WriteLine("\n\nQ4. Which Characters are in Darling Movie");

            Console.WriteLine("\n1.Prabha 2.Nandhini 3.Arjun 4.Revanth");
            
      Console.Write("\nEnter Your Answer : ");
      ans = Convert.ToInt32(Console.ReadLine());
      if (ans == 2)
      score += 20;
            //Question No:5
            Console.WriteLine("\n\nQ5. What was the Characters in Magadheera Movie");


            Console.WriteLine("\n1.Kala Bhairava 2.Renuka 3.Lakshna 4.Rana Dhev Billa");

           
     Console.Write("\nEnter Your Answer : ");
     ans = Convert.ToInt32(Console.ReadLine());
     if (ans == 4)
     score += 20;
     StreamWriter sw = new StreamWriter(@"E:\C#\NBTraining1\Scores_Results.txt", true);
     sw.WriteLine(" Name : {0} \n\t Score : {1}\n", name, score);
     sw.Close();
 

     Console.WriteLine("\n\t ____:::*** Congratulations, Your Scores got submitted to the Admin ***:::____\n");

          

     Console.ReadLine();
         }
     }
}
