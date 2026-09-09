namespace Lekcja_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string imie;

            Console.WriteLine("Podaj imię:");
            imie = Console.ReadLine();
            string nazwisko;

            Console.WriteLine("Podaj nazwisko:");
            nazwisko = Console.ReadLine();
            string wiek;

            Console.WriteLine("Podaj wiek:");
            wiek = Console.ReadLine();
            string wykształcenie;

            Console.WriteLine("Podaj wykształcenie:");

            wykształcenie = Console.ReadLine();
            Console.WriteLine("witaj: " + imie +"\n"+ "twoje nazwisko to: "+ nazwisko + "\n" + "twój wiek to: " + wiek + "\n"+ "wykształcenie: "+ wykształcenie +"\n");
            




            Console.ReadKey();


        }
    }
}
