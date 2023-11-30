using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class CodeRecover
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public string Code { get; set; }
        public bool Status { get; set; }

    }
}
