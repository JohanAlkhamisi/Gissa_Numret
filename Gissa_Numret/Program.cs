namespace Gissa_Numret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Välkommanr och säger..
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");


            //här slumpass nummret
            Random random = new Random();
            int number = random.Next(1, 20);


            // här räknar den hur många gissningar och det är 1-5 och den ökar med 1 och slutar på 5
            for (int Guess = 1; Guess <= 5; Guess = Guess + 1)

            {
                int Userimput = int.Parse(Console.ReadLine());
                
            
            
                
                // frågar om gissninen är rätt eller fel. Om den är rätt så avslutas det. om man har gissat 5 gånger så skrive den ...
            if (Userimput == number)
            {
                Console.WriteLine("Wohoo! Du klarade det!");
                    break;   
            }
            else if (Userimput < number)
            {
                Console.WriteLine("Tyvärr, du gissade för lågt! Gissa igen!");
            }
            else if (Userimput > number)
            {
                Console.WriteLine("Tyvärr, du gissade för högt! Gissa igen!");
            }
                if (Guess == 5) 
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }
          

            }

        }
    }
}
