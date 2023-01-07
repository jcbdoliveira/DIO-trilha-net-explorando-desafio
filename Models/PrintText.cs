namespace DesafioProjetoHospedagem.Models
{
    public class PrintText
    {
        public void printColorText(string frase, int cor)        
        {

            switch (cor)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            
            //Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(frase);
            Console.ResetColor();
        }   
    }
}