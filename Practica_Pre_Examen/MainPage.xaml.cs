namespace Practica_Pre_Examen
{
    public partial class MainPage : ContentPage

    {
        string titulo = "Registro";
        public Estudiante MiEstudiante { get; set; }

        public MainPage()
        {
            InitializeComponent();
            MiEstudiante = new Estudiante();
            BindingContext = MiEstudiante;

        }

            private void ConfirmarBtn_Clicked(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var mensaje = $"{MiEstudiante.NombreEstud} sus datos se ingresaron correctamente";
             
            }
            
        }
        private bool IsValid()
        {
            if (string.IsNullOrEmpty(MiEstudiante.NombreEstud)) 
            { 
            
                DisplayAlert(titulo, "Debe Ingresar un Nombre", "Ok");
                return false;
            }
            if (string.IsNullOrEmpty(MiEstudiante.ApellidoEstud))
            {
                DisplayAlert(titulo, "Debe Ingresar un Apellido", "Ok");
                return false;
            }
            if (string.IsNullOrEmpty(MiEstudiante.MateriaEstud))
            {
                DisplayAlert(titulo, "Debe Ingresar una Materia", "Ok");
                return false;
            }
            {

            }
            return true;
                }
    }
    
}