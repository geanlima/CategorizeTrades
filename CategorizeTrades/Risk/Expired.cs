using CategorizeTrades.Trades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CategorizeTrades.Categories.EnumRisk;

namespace CategorizeTrades.Risk
{
    internal class Expired : IRisk
    {
        public string Type { get; private set; }

        public DateTime _dateReference;

        public Expired(DateTime dateReference)
        {
            _dateReference = dateReference;
        }

        public bool CalculateRisk(ITrade trade)
        {
            Type = "";
            if ((int)_dateReference.Subtract(trade.NextPaymentDate).TotalDays > 30)
            {
                Type = TypeRisk.EXPIRED.ToString();
                return true;
            }

            return false;
        }
    }
}
