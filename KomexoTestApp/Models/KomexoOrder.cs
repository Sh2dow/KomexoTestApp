using System;
using System.ComponentModel.DataAnnotations;

namespace KomexoTestApp.Models
{
    public class KomexoOrder
    {
        public int OrderNr { get; set; }
        public string ProjectName { get; set; }
        public DateTime ServiceDate { get; set; }
        public string EngineerName { get; set; }

        [DataType(DataType.MultilineText)]
        public string ToDo { get; set; }
        public int Cable { get; set; }
        public int Plate { get; set; }
        public int Screw { get; set; }
        public string Signature { get; set; }
    }
}