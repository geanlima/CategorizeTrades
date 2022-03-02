using CategorizeTrades.Risk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeTrades.Trades
{
    internal class Trade : ITrade
    {
        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public bool CalculateRisk(IRisk risk)
        {
            return risk.CalculateRisk(this);
        }

        
    }
}
