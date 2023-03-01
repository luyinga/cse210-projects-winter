
using System.IO;

namespace Journal
{
    
}
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



        class welcome{

        
        public void welcom (string welc)


        {
            Console.WriteLine("Welcome to the journal program");
            Console.WriteLine("Please select one of the choices: ");

            string [] words = new string [5] {"Write", "Display","Load", "Save", "Quit"};
            foreach (string word in words.Range(1, 5))
            {
                Console.WriteLine(word);
            }                                                           
        }
            public void journal (string jour)
            {   string DateTime = DateTime.Now;

                string question = "What would you like to do?";
                string question1 = "If I had one thing I could do over today, what would it be?";
                string question2 = "What was the best part of my day?";
                string question3 = "Who was the most interesting person I interacted with today";
                
                Console.WriteLine($"{question}");
                string answer = Console.ReadLine();
                int num = Int32.Parse(answer);

                if (num == 1)
                {
                    Console.WriteLine($"{question1}");
                    Console.WriteLine($"{question2}");
                    Console.WriteLine($"{question3}");

                } 
                else if (num == 2)
                {
                    Console.WriteLine($"{DateTime}");
                }
                else if (num == 3)
                {
                    Console.WriteLine("Please select one of the choices: ");
                    Console.WriteLine($"{question}");
                }
                else if (num == 4)
                {
                    Console.WriteLine("save the file");
                    Console.WriteLine($"What is your file name?");
                }
                else 
                {
                    Console.WriteLine("Quit");
                }

            }

        
    
}