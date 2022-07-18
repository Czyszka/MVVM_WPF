using System.ComponentModel;

namespace KoloryWPF.ModelWidoku
{
    public abstract class ObservedObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(params string[] nazwyWlasnosci)
        {
            if (PropertyChanged is not null)
                foreach (string nazwaWlasnosci in nazwyWlasnosci)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nazwaWlasnosci));
                }
        }
    }
}
