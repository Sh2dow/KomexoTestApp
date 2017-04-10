using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KomexoTestApp.Models
{
    public class KomexoOrder
    {
        [DisplayName("Order Nr")]
        public int OrderNr { get; set; }
        [DisplayName("Project name")]
        public string ProjectName { get; set; }

        [DisplayName("Service Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ServiceDate { get; set; }

        [DisplayName("Engineer name")]
        public string EngineerName { get; set; }

        [DisplayName("To Do")]
        [DataType(DataType.MultilineText)]
        public string ToDo { get; set; }
        public int Cable { get; set; }
        public int Plate { get; set; }
        public int Screw { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }
        public string Signature { get; set; }
    }
}