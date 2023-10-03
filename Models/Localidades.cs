using System;
using System.Collections.Generic;


namespace ServicioSocial.Models
{
    public class Localidades
    {

        public Localidades()
        {
            Datosgeneralesalumno = new HashSet<Datosgeneralesalumno>();
            Datosgeneralestrabajadores = new HashSet<Datosgeneralestrabajadores>();
        }

        public int Id { get; set; }
        public string Localidades1 { get; set; }
        public short IdMunicipio { get; set; }

        public virtual Municipios IdMunicipioNavigation { get; set; }
        public virtual ICollection<Datosgeneralesalumno> Datosgeneralesalumno { get; set; }
        public virtual ICollection<Datosgeneralestrabajadores> Datosgeneralestrabajadores { get; set; }

    }
}