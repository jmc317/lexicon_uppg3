namespace lexicon_uppg3
{
    /*Uppgift:
Skapa publika properties med get och set som hämtar eller sätter tilldelad variabel.
Instansiera en person i Program.cs, kommer du direkt åt variablerna?Kasta ett undantag av typen ArgumentException i varje property om dess
validering inte fullföljs, undantaget ska innehålla ett beskrivande
meddelande.
Se till att hantera undantagen i Program-klassen med en try-catch block.
*/
    public class Person
    {
        private string fName { get; set; }
        private string lName { get; set; }
        private int age { get; set; }
        private int height { get; set; }
        private int weight { get; set; }

        public void Age()
        {
            Console.WriteLine("Add age:");
        }

       
    }

}
/* try



         if (age =< 0)
         {
                throw new ArgumentException("Age cannot be 0.");
         }

    Console.WriteLine($"Your age is: {age}");
            
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
*/