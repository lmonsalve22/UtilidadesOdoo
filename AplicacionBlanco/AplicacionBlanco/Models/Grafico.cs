using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionBlanco.Models
{
    public class Grafico
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string TITULO { get; set; }
        public string SUBTITULO { get; set; }
        public string DESCRIPCION { get; set; }
        public string FECHA_PUBLICACION { get; set; }
        public string REGION { get; set; }
        public string PERIODO_ESTUDIO { get; set; }
        public string GRUPO_EDAD { get; set; }
        public string TAGS { get; set; }
        public string MACROTEMA { get; set; }
        public string URL { get; set; }
        public string IDIOMA { get; set; }


        public Grafico(int iD, string nOMBRE, string tITULO, string sUBTITULO, string dESCRIPCION, string fECHA_PUBLICACION, string rEGION, string pERIODO_ESTUDIO, string gRUPO_EDAD, string tAGS, string mACROTEMA, string uRL, string Español)
        {
            ID = iD;
            NOMBRE = nOMBRE;
            TITULO = tITULO;
            SUBTITULO = sUBTITULO;
            DESCRIPCION = dESCRIPCION;
            FECHA_PUBLICACION = fECHA_PUBLICACION;
            REGION = rEGION;
            PERIODO_ESTUDIO = pERIODO_ESTUDIO;
            GRUPO_EDAD = gRUPO_EDAD;
            TAGS = tAGS;
            MACROTEMA = mACROTEMA;
            URL = uRL;
            IDIOMA = Español;
        }

        public string URLCOmpleta()
        {
            //https://github.com/Sud-Austral/MPG/raw/main/Prueba/test.csv
            return "https://github.com/Sud-Austral/MPG/raw/main/" + MACROTEMA + "/" + URL;
        }
    }
}