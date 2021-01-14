using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionBlanco.Models
{
    public class VistasGEE
    {
        public int id { get; set; }
        //public int id_powerbi { get; set; }
        //public int filtro { get; set; }
        public string geeURL { get; set; }
        public string urlBase { get; set; }
        public string comentario { get; set; }
        public string nombre { get; set; }
        public string urlImagen { get; set; }
        public string titulo { get; set; }

        public VistasGEE(int id, string geeURL, string comentario, string nombre, string urlImagen, string titulo)
        {
            this.id = id;
            this.geeURL = geeURL;
            this.urlBase = "https://dashboardfiltrado.azurewebsites.net/AutoDash/Index/";
            this.comentario = comentario;
            this.nombre = nombre;
            this.urlImagen = urlImagen;
            this.titulo = titulo;
        }


        public string urlCompletaPB(int id_powerbi, int filtro)
        {
            return this.urlBase + "/" + id_powerbi.ToString() + "/" + filtro.ToString();
        }

        public string urlCompletaPB(int id_powerbi)
        {
            return this.urlBase + "/" + id_powerbi.ToString();
        }

        public string urlCompletaGEE(int id_filtro_gee)
        {
            return this.geeURL + "?Codcom=" + id_filtro_gee.ToString();
        }

        public VistasGEE()
        {
        }
    }
}