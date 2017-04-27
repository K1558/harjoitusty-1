using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace harjoitustyö
{
    public class Harjoitus : INotifyPropertyChanged
    {
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
      
        /// </summary>
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string paiva;
        public string Paiva
        {
            get { return paiva; }
            set
            {
                paiva = value;
                RaisePropertyChanged();
            }
        }

        private string laji;
        public string Laji
        {
            get { return laji; }
            set
            {
                laji = value;
                RaisePropertyChanged();
            }
        }

        private string maxsyke;
        public string MaxSyke
        {
            get { return maxsyke; }
            set
            {
                maxsyke = value;
                RaisePropertyChanged();
            }
        }

        private string avgsyke;
        public string AvgSyke
        {
            get { return avgsyke; }
            set
            {
                avgsyke = value;
                RaisePropertyChanged();
            }
        }

        private string kalorit;
        public string Kalorit
        {
            get { return kalorit; }
            set
            {
                kalorit = value;
                RaisePropertyChanged();
            }
        }

        private string kommentit;
        public string Kommentit
        {
            get { return kommentit; }
            set
            {
                kommentit = value;
                RaisePropertyChanged();
            }
        }

        private string fiilis;
        public string Fiilis
        {
            get { return fiilis; }
            set
            {
                fiilis = value;
                RaisePropertyChanged();
            }
        }
    }
}


