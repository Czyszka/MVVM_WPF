using KoloryWPF.Model;
using KoloryWPF.ModelWidoku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KoloryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Color KolorProstokata 
        //{ 
        //    get { return (rectangle.Fill as SolidColorBrush).Color; } 
        //    set { (rectangle.Fill as SolidColorBrush).Color = value; } 
        //}
        public MainWindow()
        {
            InitializeComponent();
            //Color kolor = Ustawienia.Zapisane.ToColor();
            //rectangle.Fill = new SolidColorBrush(kolor);
            //sliderR.Value = kolor.R;
            //sliderG.Value = kolor.G;
            //sliderB.Value = kolor.B;
        }

        //private void sliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    Color kolor = Color.FromRgb(
        //        (byte)sliderR.Value, (byte)sliderG.Value, (byte)sliderB.Value);

        //    KolorProstokata = kolor;
        //}

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape) Close();
        }

        //private void Window_Closed(object sender, EventArgs e)
        //{
        //    //Ustawienia.Zapisane=new Kolor(KolorProstokata.R, KolorProstokata.G, KolorProstokata.B);
        //    EdycjaKoloru edycjaKoloru = this.Resources["edycjaKoloru"] as EdycjaKoloru;
        //    edycjaKoloru.Zapisz();
        //}
    }
}
