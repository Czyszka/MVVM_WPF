using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloryWPF.ModelWidoku
{
    using Model;
    using System.ComponentModel;
    using System.Windows.Input;
    using System.Windows.Media;

    public class EdycjaKoloru : ObservedObject, IEdycjaKoloru 
    {
        //zaimplementowane w ObservedObject, teraz mozna korzystac w kazdym z modeliWidoku
        //public event PropertyChangedEventHandler? PropertyChanged;
        //protected void OnPropertyChanged(params string[] nazwyWlasnosci)
        //{
        //    if (PropertyChanged is not null)
        //        foreach (string nazwaWlasnosci in nazwyWlasnosci)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs(nazwaWlasnosci));
        //        }
        //}
        private ICommand resetujCommand;
        public ICommand Resetuj
        {
            get
            {
                if (resetujCommand == null) resetujCommand = new RelayCommand(
                    argument => { R = 0; G = 0; B = 0; }, argument => (R != 0) || (G != 0) || (B != 0));
                return resetujCommand;
            }
        }
        private readonly Kolor kolor = Ustawienia.Zapisane;
        public byte R { get { return kolor.R; } set { kolor.R = value; OnPropertyChanged("R", "Color"); } }
        public byte G { get { return kolor.G; } set { kolor.G = value; OnPropertyChanged("G", "Color"); } }
        public byte B { get { return kolor.B; } set { kolor.B = value; OnPropertyChanged("B", "Color"); } }

        //public Color Color
        //{
        //    get { return kolor.ToColor(); }
        //}
        //public void Zapisz() => Ustawienia.Zapisane = kolor;
        private ICommand zapiszCommand;
        public ICommand Zapisz
        {
            get
            {
                if (zapiszCommand is null)
                    zapiszCommand = new RelayCommand(
                        argument => { Ustawienia.Zapisane=kolor; });
                return zapiszCommand;
            }
        }
    }
    //static class Rozszerzenia
    //{
    //    public static Color ToColor(this Kolor kolor)
    //    {
    //        return new Color()
    //        {
    //            A = 255,
    //            R = kolor.R,
    //            G = kolor.G,
    //            B = kolor.B
    //        };
    //    }
    //}
}
