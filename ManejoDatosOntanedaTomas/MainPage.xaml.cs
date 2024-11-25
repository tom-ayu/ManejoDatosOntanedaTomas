using ManejoDatosOntanedaTomas.Interfaces;
using ManejoDatosOntanedaTomas.Models;
using ManejoDatosOntanedaTomas.Repositories;

namespace ManejoDatosOntanedaTomas
{
    public partial class MainPage : ContentPage
    {
        IEstudianteUDLARepository _estudianteUDLARepository;
        EstudianteUDLA estudiante = new EstudianteUDLA();

        public MainPage()
        {
            
            _estudianteUDLARepository = new EstudianteUDLAPorArchivosRepository();
            InitializeComponent();

            estudiante = _estudianteUDLARepository.DevuelveEstudiante(1);

            BindingContext = estudiante;
        }

        private async void GuardarEstudiante_Clicked(object sender, EventArgs e)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                Id = Int32.Parse(Editor_Id.Text),
                Nombre = Editor_Nombre.Text,
                Carrera = Editor_Carrera.Text,
            };

            bool guardar_estudiante = _estudianteUDLARepository.CrearEstudiante(estudiante);

            if (guardar_estudiante)
            {
                await DisplayAlert("Alerta", "Todo posi", "OK");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alerta", "Negado pana", "OKn't");
            }
        }
    }

}
