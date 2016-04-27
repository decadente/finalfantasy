using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO { 
    public class Doctor
    {
	    public Doctor()
	    {
		}
        public int doctor_id { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int usuario_id { get; set; }
    }
}