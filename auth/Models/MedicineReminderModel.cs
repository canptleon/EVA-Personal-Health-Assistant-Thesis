using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace auth.Models
{
    public class MedicineReminderModel
    {
        public int id { get; set; }
        public string identityNumber { get; set; }
        public int medicineId { get; set; }
        public System.DateTime start { get; set; }
        public int day { get; set; }
        public string clock { get; set; }
        public int reuse { get; set; }
        public bool used { get; set; }

    }
}