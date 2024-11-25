using ManejoDatosOntanedaTomas.Interfaces;
using ManejoDatosOntanedaTomas.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDatosOntanedaTomas.Repositories
{
    public class EstudianteUDLAPorArchivosRepository : IEstudianteUDLARepository
    {
        public string _filename = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
        
        public bool ActualizarEstudiante(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudiante(EstudianteUDLA estudiante)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_filename, "XxxEstebinxxX");
                return true;
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public EstudianteUDLA DevuelveEstudiante(int id)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA();
            if (File.Exists(_filename))
            {
                string json_data = File.ReadAllText(_filename);
                estudiante = JsonConvert.DeserializeObject<EstudianteUDLA>(json_data);
            }

            return estudiante;
        }   

        public IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantes()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudiante(int id)
        {
            throw new NotImplementedException();
        }
    }
}
