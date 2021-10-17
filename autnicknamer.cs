using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace boob
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Words to use,in order.
       string[] words1 = {"Swedish","Laggy","Authentic","Alternative","Censored","Suppressed","Creative","Molten","Unusual", "Bound", "Toasty", "Classy", "Lazy", "Sentient", "Evil", "Responsible"};
       string[] words2 = {"Slab","Landscape","Meatball","Octopus","Fossa","Kalashnikov","Puppet","Catwalk","Laxative","Lava","Earth","Monster", "Toaster", "Tuxedo", "Penguin", "Sandwich", "Bead", "Battery"};
       
       Random rnd = new Random();
       
       
       int index = rnd.Next(0, 18);
       
       
       Console.Write(words1[index]);Console.WriteLine(words2[index]);
       
     }
   }
 }
