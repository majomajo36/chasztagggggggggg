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

        string[] kolory =
        {
            "zielony",
            "pomaranczowy",
            "szary"
        };

        public MainWindow()
        {
            InitializeComponent();

            LosujKolory();
        }

        private void LosujKolory()
        {
            // Losujemy kolor, który trzeba wybrać
            int numer = losowanie.Next(0, 3);

            poprawnyKolor = kolory[numer];

            // Wyświetlamy nazwę koloru
            if (poprawnyKolor == "zielony")
            {
                txtKolor.Text = "zielony";
            }
            else if (poprawnyKolor == "pomaranczowy")
            {
                txtKolor.Text = "pomarańczowy";
            }
            else
            {
                txtKolor.Text = "szary";
            }

            // Tworzymy tablicę przycisków
            string[] przyciski =
            {
                "zielony",
                "pomaranczowy",
                "szary"
            };

            // Losujemy kolejność
            for (int i = 0; i < 3; i++)
            {
                int losowy = losowanie.Next(0, 3);

                string temp = przyciski[i];

                przyciski[i] = przyciski[losowy];

                przyciski[losowy] = temp;
            }

            // Ustawiamy kolory przycisków
            UstawPrzycisk(btn1, przyciski[0]);
            UstawPrzycisk(btn2, przyciski[1]);
            UstawPrzycisk(btn3, przyciski[2]);

            txtKomunikat.Text = "Wybierz kolor";
        }

        private void UstawPrzycisk(Button przycisk, string kolor)
        {
            // Zapamiętujemy kolor przycisku
            przycisk.Tag = kolor;

            if (kolor == "zielony")
            {
                przycisk.Background = Brushes.Green;
            }
            else if (kolor == "pomaranczowy")
            {
                przycisk.Background = Brushes.Orange;
            }
            else if (kolor == "szary")
            {
                przycisk.Background = Brushes.Gray;
            }
        }

        private void Kolor_Click(object sender, RoutedEventArgs e)
        {
            Button klikniety = (Button)sender;

            string wybranyKolor = klikniety.Tag.ToString();

            // Sprawdzamy odpowiedź
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

            // Czekamy chwilę? Nie - od razu następne losowanie
            LosujKolory();
        }
    }
}
