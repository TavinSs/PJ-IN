using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_IN
{
    public class Fatura
    {
        public DateTime DataVencimento { get; set; }
        public decimal ValorTotal { get; set; }
        public string Banco { get; set; }
        public bool Pago { get; set; }

    }
}
