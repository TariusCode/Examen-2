using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Encuesta
{
    public int lblNumeroEncuesta { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int Edad { get; set; }
    public string CorreoElectronico { get; set; }
    public bool CarroPropio { get; set; }
}