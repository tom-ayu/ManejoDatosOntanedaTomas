using ManejoDatosOntanedaTomas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDatosOntanedaTomas.Interfaces
{
    public interface IEstudianteUDLARepository
    {
        IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantes();
        EstudianteUDLA DevuelveEstudiante(int id);
        bool CrearEstudiante(EstudianteUDLA estudiante);
        bool ActualizarEstudiante(EstudianteUDLA estudiante);
        bool EliminarEstudiante(int id);
    }
}
