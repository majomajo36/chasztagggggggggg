using System.ComponentModel.Design;

namespace L2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("podaj 1 liczbe");
                double numb1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("podaj 2 liczbe");
                double numb2 = double.Parse(Console.ReadLine());
                double wynik;
                Console.WriteLine("podaj znak");
                string znak = Console.ReadLine();

                switch (znak)
                {
                    case "+":
                        wynik = numb1 + numb2;
                        Console.WriteLine(numb1 + "+" + numb2);
                        Console.WriteLine(wynik);
                        break;
                    case "-":
                        wynik = numb1 - numb2;
                        Console.WriteLine(numb1 + "-" + numb2);
                        Console.WriteLine(wynik);
                        break;

                    case "*":
                        wynik = numb1 * numb2;
                        Console.WriteLine(numb1 + "*" + numb2);
                        Console.WriteLine(wynik);
                        break;

                    case ":":

                        if(numb2 ==0)
                                throw new Exception("dzielenie przez 0");
                    
                        wynik = numb1 / numb2;
                        Console.WriteLine(numb1 + "/" + numb2);
                        Console.WriteLine(wynik);
                        break;

                    default:
                        Console.WriteLine("spadaj");
                        break;

                }

            }catch(Exception e)
            {

                Console.WriteLine(e.ToString());

            }







                Console.ReadLine();
        }
    }
}
