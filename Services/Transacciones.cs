using ServicioSocial.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using MySqlConnector;

namespace ServicioSocial.Services
{
    public class Transacciones : ITransacciones
    {
        private readonly IConfiguration _config;

        public Transacciones(IConfiguration _config)
        {
            this._config = _config;
        }

        public Usuario Login(Login login)
        {
            using MySqlConnection db = new MySqlConnection(_config.GetConnectionString("conexion"));
            string comando = "SELECT u.id,u.nomUsuario,u.pwd,u.IdRol,r.Id,r.Rol " +
                             "FROM Usuarios AS u INNER JOIN Roles AS r ON u.IdRol = r.Id WHERE u.nomUsuario = '" + login.Usuario + "' AND u.pwd='" + login.Password + "'";
            Usuario user = db.Query<Usuario, Roles, Usuario>(comando, (u, r) =>
            {
                u.Rol = r;
                return u;
            }, splitOn: "Id"
            ).FirstOrDefault();
            return user;
        }

        public List<Calificaciones> ObtenerCalificaciones()
        {
            using (MySqlConnection db = new MySqlConnection(_config.GetConnectionString("conexion")))
            {
                string comando = "select * from Calificaciones";
                List<Calificaciones> calificaciones = db.Query<Calificaciones>(comando).ToList();
                return calificaciones;
            }
        }

        public List<Calificaciones> ObtenerCalificacionesPorAlumno(string nombre)
        {
            using (MySqlConnection db = new MySqlConnection(_config.GetConnectionString("conexion")))
            {
                string comando = "SELECT * FROM Calificaciones WHERE IdAlumno ='" + nombre + "'";
                List<Calificaciones> calificacion = db.Query<Calificaciones>(comando).ToList();
                return calificacion;
            }
        }

        public Calificaciones ObtenerCalificacionesPorId(int id)
        {
            using (MySqlConnection db = new MySqlConnection(_config.GetConnectionString("conexion")))
            {
                string comando = "SELECT * FROM Calificaciones WHERE Id =" + id;
                Calificaciones calificacion = db.Query<Calificaciones>(comando).FirstOrDefault();
                return calificacion;
            }
        }

        public void ActualizarCalificacion(Calificaciones c)
        {
            using (MySqlConnection db = new MySqlConnection(_config.GetConnectionString("conexion")))
            {
                string comando = "UPDATE Calificaciones SET IdAlumno = @idalumno, IdMateria = " +
                    "@idmateria, Calificacion = @calificacion WHERE Id = @id";

                var resultado = db.Execute(comando, c);
            }
        }

        public void RegistrarCalificacion(Calificaciones c)
        {
            using (MySqlConnection db = new MySqlConnection(_config.GetConnectionString("conexion")))
            {
                string comando = "INSERT INTO Calificaciones (IdAlumno, IdMateria, Calificacion) " +
                                 "VALUES (@idalumno,@idmateria,@calificacion);";
                var resultado = db.Execute(comando, c);
            }
        }

        public List<Alumnos> ObtenerAlumnoPorNoControl(string nocontrol)
        {
            using (MySqlConnection db = new MySqlConnection(_config.GetConnectionString("conexion")))
            {
                string comando = "SELECT * FROM Alumnos WHERE NoControl ='" + nocontrol + "'";
                List<Alumnos> alumno = db.Query<Alumnos>(comando).ToList();
                return alumno;
            }
        }
    }
}