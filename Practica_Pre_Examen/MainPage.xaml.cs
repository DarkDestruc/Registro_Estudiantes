namespace Practica_Pre_Examen
{
    public partial class MainPage : ContentPage
    {
        public Estudiante MiEstudiante { get; set; }

        public MainPage()
        {
            InitializeComponent();
            MiEstudiante = new Estudiante();
            BindingContext = Estudiante();

        }




        private void ConfirmarBtn_Clicked(object sender, EventArgs e)
        {
            Display(MiEst);
        }
    }
    
}