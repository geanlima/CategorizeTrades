using CategorizeTrades.Risk;
using CategorizeTrades.Trades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CategorizeTrades.Categories.EnumRisk;

namespace CategorizeTrades.Categories
{
    internal class Category
    {
        private List<ITrade> _portfolio;

        public Category(List<ITrade> portfolio)
        {
            _portfolio = portfolio;
        }

        public List<string> GetCategories()
        {
            IRisk risk = null;

            List<string> tradeCategories = new List<string>();

            List<IRisk> risks = new List<IRisk> {                
                FactoryRisk.Create(TypeRisk.HIGHRISK),
                FactoryRisk.Create(TypeRisk.EXPIRED),
                FactoryRisk.Create(TypeRisk.MEDIUMRISK)
            };

            foreach (Trade trade in _portfolio)
            {
                foreach (IRisk item in risks)
                {
                    risk = item;

                    if (trade.CalculateRisk(item))
                    {
                        break;
                    }
                }

                tradeCategories.Add(risk.Type);
            }

            return tradeCategories;
        }
    }
}
