using System;
using static CategorizeTrades.Categories.EnumRisk;

namespace CategorizeTrades.Risk
{
    internal static class FactoryRisk
    {
        public static IRisk Create(TypeRisk risk)
        {
            return Create(risk.ToString());
        }

        public static IRisk Create(string risk)
        {
            switch (risk)
            {
                case "EXPIRED":
                    return new Expired(new DateTime(2020, 12, 11));
                case "MEDIUMRISK":
                    return new MediumRisk();
                case "HIGHRISK":
                    return new HighRisk();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
