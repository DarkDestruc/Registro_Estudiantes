using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pre_Examen
{
    public class Estudiante : INotifyPropertyChanged
    {
        private string nombreEstud;
        private string apellidoEstud;
        private string materiaEstud;

        private string NombreEstud
        {
            get => nombreEstud; set
            {
                nombreEstud = value;
                this.OnPropertyChanged(nameof(NombreEstud));
            }
        }
        private string ApellidoEstud
        {
            get => apellidoEstud; set
            {
                apellidoEstud = value;
                this.OnPropertyChanged(nameof(ApellidoEstud));
            }
        }
        private string MateriaEstud
        {
            get => materiaEstud; set
            {
                materiaEstud = value;
                this.OnPropertyChanged(nameof(MateriaEstud));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string RegEstu)
        {
            this.PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(RegEstu));
        }

    }
}
