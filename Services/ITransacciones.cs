using ServicioSocial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ServicioSocial.Services
{
    public interface ITransacciones
    {
        Usuario Login(Login login);

        List<Calificaciones> ObtenerCalificaciones();

        List<Calificaciones> ObtenerCalificacionesPorAlumno(string alumno);

        List<Alumnos> ObtenerAlumnoPorNoControl(string nocontrol);

        Calificaciones ObtenerCalificacionesPorId(int id);

        void ActualizarCalificacion(Calificaciones c);

        void RegistrarCalificacion(Calificaciones calificacion);
    }
}