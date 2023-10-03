using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ServicioSocial.Models
{
    public class DatosGeneralesAlumnoMetaData
    {
        [Required(ErrorMessage = "CURP Requerido")]
        public string Curp { get; set; }
        [Required(ErrorMessage = "Nombre requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Apellido paterno requerido")]
        [Display(Name = "Apellido Paterno")]
        public string Apaterno { get; set; }
        [Required(ErrorMessage = "Apellido materno requerido")]
        [Display(Name = "Apellido Materno")]
        public string Amaterno { get; set; }
        [Required(ErrorMessage = "Fecha requerida")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public byte[] Foto { get; set; }
        [Required(ErrorMessage = "Dirección requerida")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "CP Requerido")]
        public int? Cp { get; set; }
        [Display(Name = "Localidad")]
        public int IdLocalidad { get; set; }
        public string UrlFoto { get; set; }
    }
    [ModelMetadataType(typeof(DatosGeneralesAlumnoMetaData))]
    public partial class Datosgeneralesalumno { }
}