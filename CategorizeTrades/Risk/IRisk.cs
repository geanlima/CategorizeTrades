using CategorizeTrades.Trades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeTrades.Risk
{
    interface IRisk
    {
        public string Type { get; }
        public bool CalculateRisk(ITrade trade);
    }
}
