using System;

namespace KoloryWPF.Model
{
    static class Ustawienia
    {
        private static Kolor Czytaj()
        {
            Properties.Settings ustawienia = Properties.Settings.Default;
            return new Kolor(ustawienia.R,ustawienia.G,ustawienia.B);
        }
        private static void Zapisz(Kolor kolor)
        {
            Properties.Settings ustawienia = Properties.Settings.Default;
            ustawienia.R = kolor.R;
            ustawienia.B = kolor.B;
            ustawienia.G = kolor.G;
            ustawienia.Save();
        }

        public static Kolor Zapisane { get { return Czytaj(); } set { Zapisz(value); } }
    }
}
