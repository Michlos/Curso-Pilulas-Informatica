using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeira_Intereface
{
    class JunteNomes : INotifyPropertyChanged
    {
        private string nome, sobreNome, nomeCompleto;
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                OnPopertyChanged("NomeCompleto");
            }
        }
        public string SobreNome
        {
            get { return sobreNome; }
            set
            {
                sobreNome = value;
                OnPopertyChanged("NomeCompleto");
            }
        }
        public string NomeCompleto
        {
            get
            {
                nomeCompleto = Nome + " " + SobreNome;
                return nomeCompleto;
            }
            set
            {
                nomeCompleto = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPopertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


    }
}
