using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace auth.Models
{
    public class Medicines
    {
        public IEnumerable<Medicine> Medicine { get; set; }
        public IEnumerable<MedicineReminder> MedicineReminder { get; set; }
    }
}