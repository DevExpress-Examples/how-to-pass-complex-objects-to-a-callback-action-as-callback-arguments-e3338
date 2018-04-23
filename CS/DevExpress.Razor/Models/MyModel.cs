using System;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.Razor.Models {
    public class MyData {
        public string Name { get; set; }

        public int? Age { get; set; }

        public string Email { get; set; }

        public DateTime? ArrivalDate { get; set; }
    }
}
