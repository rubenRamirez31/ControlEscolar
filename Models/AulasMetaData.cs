using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ServicioSocial.Models
{
    public class AulasMetaData
    {
        public short Id { get; set; }
        [Required(ErrorMessage = "El aula es requerida")]
        public string Aula { get; set; }
    }

    [ModelMetadataType(typeof(AulasMetaData))]
    public partial class Aulas { }
}