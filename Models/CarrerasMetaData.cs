using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

#nullable disable //se agrego anotacion para evitar que haya datos nulos


namespace ServicioSocial.Models
{
    public class CarrerasMetaData
    {
        public byte Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre no puede pasar de 50 letras")]
        public string Carrera { get; set; }
        [Required(ErrorMessage = "El inicio es requerido")]
        [Display(Name = "Inicio de la Vigencia")]
        public DateTime InicioVigencia { get; set; }
        [Display(Name = "Fin de la Vigencia")]
        public DateTime? FinVigencia { get; set; }
    }

    [ModelMetadataType(typeof(CarrerasMetaData))]
    public partial class Carreras { }
}