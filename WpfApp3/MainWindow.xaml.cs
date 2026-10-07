using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        Random losowanie = new Random();

        int poprawne = 0;
        int bledne = 0;

        string poprawnyKolor;

        // Lista wszystkich kolorów
        string[] kolory =
        {
            "zielony",
            "pomaranczowy",
            "szary",
            "czerwony",
            "niebieski",
            "zolty",
            "fioletowy",
            "rozowy",
            "brazowy",
            "czarny",
            "bialy",
            "turkusowy",
            "granatowy",
            "limonkowy",
            "seledynowy",
            "bordowy",
            "bezowy",
            "zloty",
            "srebrny",
            "lawendowy",
            "miętowy",
            "oliwkowy",
            "koralowy"
        };

        public MainWindow()
        {
            InitializeComponent();

            LosujKolory();
        }

        private void LosujKolory()
        {
            // Losujemy poprawny kolor
            int numer = losowanie.Next(kolory.Length);

            poprawnyKolor = kolory[numer];

            txtKolor.Text = WyswietlNazwe(poprawnyKolor);

            // Losujemy 3 różne kolory
            string[] przyciski = new string[3];

            przyciski[0] = poprawnyKolor;

            // Drugi kolor
            do
            {
                przyciski[1] = kolory[losowanie.Next(kolory.Length)];
            }
            while (przyciski[1] == przyciski[0]);

            // Trzeci kolor
            do
            {
                przyciski[2] = kolory[losowanie.Next(kolory.Length)];
            }
            while (przyciski[2] == przyciski[0] ||
                   przyciski[2] == przyciski[1]);

            // Mieszamy kolejność przycisków
            for (int i = 0; i < 3; i++)
            {
                int losowy = losowanie.Next(3);

                string temp = przyciski[i];

                przyciski[i] = przyciski[losowy];

                przyciski[losowy] = temp;
            }

            // Ustawiamy przyciski
            UstawPrzycisk(btn1, przyciski[0]);
            UstawPrzycisk(btn2, przyciski[1]);
            UstawPrzycisk(btn3, przyciski[2]);

            txtKomunikat.Text = "Wybierz kolor";
            txtKomunikat.Foreground = Brushes.Red;
        }

        private void UstawPrzycisk(Button przycisk, string kolor)
        {
            przycisk.Tag = kolor;

            if (kolor == "zielony")
                przycisk.Background = Brushes.Green;

            else if (kolor == "pomaranczowy")
                przycisk.Background = Brushes.Orange;

            else if (kolor == "szary")
                przycisk.Background = Brushes.Gray;

            else if (kolor == "czerwony")
                przycisk.Background = Brushes.Red;

            else if (kolor == "niebieski")
                przycisk.Background = Brushes.Blue;

            else if (kolor == "zolty")
                przycisk.Background = Brushes.Yellow;

            else if (kolor == "fioletowy")
                przycisk.Background = Brushes.Purple;

            else if (kolor == "rozowy")
                przycisk.Background = Brushes.Pink;

            else if (kolor == "brazowy")
                przycisk.Background = Brushes.Brown;

            else if (kolor == "czarny")
                przycisk.Background = Brushes.Black;

            else if (kolor == "bialy")
                przycisk.Background = Brushes.White;

            else if (kolor == "turkusowy")
                przycisk.Background = Brushes.Turquoise;

            else if (kolor == "granatowy")
                przycisk.Background = Brushes.Navy;

            else if (kolor == "limonkowy")
                przycisk.Background = Brushes.Lime;

            else if (kolor == "seledynowy")
                przycisk.Background = Brushes.LightGreen;

            else if (kolor == "bordowy")
                przycisk.Background = Brushes.Maroon;

            else if (kolor == "bezowy")
                przycisk.Background = Brushes.Beige;

            else if (kolor == "zloty")
                przycisk.Background = Brushes.Gold;

            else if (kolor == "srebrny")
                przycisk.Background = Brushes.Silver;

            else if (kolor == "lawendowy")
                przycisk.Background = Brushes.Lavender;

            else if (kolor == "miętowy")
                przycisk.Background = Brushes.MediumAquamarine;

            else if (kolor == "oliwkowy")
                przycisk.Background = Brushes.Olive;

            else if (kolor == "koralowy")
                przycisk.Background = Brushes.Coral;
        }

        private string WyswietlNazwe(string kolor)
        {
            if (kolor == "pomaranczowy")
                return "pomarańczowy";

            if (kolor == "zolty")
                return "żółty";

            if (kolor == "fioletowy")
                return "fioletowy";

            if (kolor == "rozowy")
                return "różowy";

            if (kolor == "brazowy")
                return "brązowy";

            if (kolor == "czarny")
                return "czarny";

            if (kolor == "bialy")
                return "biały";

            if (kolor == "granatowy")
                return "granatowy";

            if (kolor == "limonkowy")
                return "limonkowy";

            if (kolor == "seledynowy")
                return "seledynowy";

            if (kolor == "bordowy")
                return "bordowy";

            if (kolor == "bezowy")
                return "beżowy";

            if (kolor == "zloty")
                return "złoty";

            if (kolor == "srebrny")
                return "srebrny";

            if (kolor == "lawendowy")
                return "lawendowy";

            if (kolor == "miętowy")
                return "miętowy";

            if (kolor == "oliwkowy")
                return "oliwkowy";

            if (kolor == "koralowy")
                return "koralowy";

            return kolor;
        }

        private void Kolor_Click(object sender, RoutedEventArgs e)
        {
            Button klikniety = (Button)sender;

            string wybranyKolor = klikniety.Tag.ToString();

            if (wybranyKolor == poprawnyKolor)
            {
                poprawne++;

                txtPoprawne.Text = poprawne.ToString();

                txtKomunikat.Text = "Dobrze!";
                txtKomunikat.Foreground = Brushes.Green;
            }
            else
            {
                bledne++;

                txtBledne.Text = bledne.ToString();

                txtKomunikat.Text = "Wybrano zły kolor.";
                txtKomunikat.Foreground = Brushes.Red;
            }

            LosujKolory();
        }
    }
}
