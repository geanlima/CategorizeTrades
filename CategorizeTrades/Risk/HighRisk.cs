﻿using CategorizeTrades.Categories;
using CategorizeTrades.Trades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CategorizeTrades.Categories.EnumRisk;

namespace CategorizeTrades.Risk
{
    internal class HighRisk : IRisk
    {
        public string Type { get; private set; }

        public bool CalculateRisk(ITrade trade)
        {
            Type = "";
            if (trade.Value > 1000000 && trade.ClientSector.Equals(Sector.PRIVATE.ToString()))
            {
                Type = TypeRisk.HIGHRISK.ToString();
                return true;
            }

            return false;
        }
    }
}
