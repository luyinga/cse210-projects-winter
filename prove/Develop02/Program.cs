using system;
using System.IO;


class Program
{
    static void Main(string[] args)
    
    {   
        string journal = "myJournal";
        string[] lines = System.IO.File.ReadAllLines(journal);

        foreach (string line in lines)
        Console .WriteLine(line);
    }
 class Date 

 {
     // Get the current date.
     DateTime theCurrentTime = DateTime.Now;
     string dateText = theCurrentTime.ToShortDateString();
      Console.WriteLine(thisDay.ToString("d"));
 }



        class welcome

        {   string greeting = "Welcme to the journal program ?";
            string select ="Please select one of the choices:"
            Console.WriteLine($"{greeting}");
            Console.WriteLine($"{select}");

            string word1 = "Write";
            string word2 = "Display";
            string word3 = "Load";
            string word4 = "save";
            string word5 = "Quit";
            Console.WriteLine("What would you like to do?");
        }
    
    }
}