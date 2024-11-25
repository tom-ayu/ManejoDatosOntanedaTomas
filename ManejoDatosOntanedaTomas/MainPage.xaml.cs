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

        
    }

}
