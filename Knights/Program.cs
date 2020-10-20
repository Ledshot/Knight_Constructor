using System;

namespace Knights
{
   class Program
   {
      public class Knight
      {
         public string Name, Court;
         public int DaysRide;
         public bool HasEquipment;

         public void Greeting()
         {
            Console.WriteLine("Greetings " + Name + ", we are pleased to receive you on behalf of " + Court + ". After " + DaysRide + " riding I'm sure you need some rest.");

            if (HasEquipment == false)
            {
               Console.WriteLine("Please come in.");
            }
            else
            {
               Console.WriteLine("But first, I'm going to need your weapons they're not permitted within the city walls.");
            }
         }
      }

      static void Main(string[] args)
      {
         Boolean Answered = false;
         Boolean Armed = false;

         Console.WriteLine("Who approaches the gate?");
         string Username = Console.ReadLine();
         
         Console.WriteLine("Who's court do you represent?");
         string Court = Console.ReadLine();
         
         Console.WriteLine("How many days have you been in the saddle?");
         int DaysRide = Int32.Parse(Console.ReadLine()); 
         
         Console.WriteLine("Are you armed?");
         do
         {
            string Answer = Console.ReadLine();
            Answer = Answer.ToLower();

            if(Answer == "yes")
            {
               Armed = true;
               Answered = true;
            }else if (Answer == "no")
            {
               Armed = false;
               Answered = true;
            }
            else
            {
               Console.WriteLine("I'm looking for a yes or no");
            }
         } while (Answered == false);

         Knight knight = new Knight();
         knight.Name = Username;
         knight.Court = Court;
         knight.DaysRide = DaysRide;
         knight.HasEquipment = Armed;

         knight.Greeting();
      }
   }
}
