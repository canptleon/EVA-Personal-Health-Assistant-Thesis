using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace auth.Models
{
    public class Doctors
    {
        public IEnumerable<Doctor> Doctor { get; set; }
        public IEnumerable<Section> Section { get; set; }
    }
}