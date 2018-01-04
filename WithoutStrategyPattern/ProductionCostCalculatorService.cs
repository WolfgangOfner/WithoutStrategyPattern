namespace WithoutStrategyPattern
{
    public class ProductionCostCalculatorService
    {
        public decimal CalculateProductionCost(Product item)
        {
            switch (item.ProductionCountry)
            {
                case "China":
                    item.ProductionCost = item.Price * 0.1m;
                    break;
                case "Australia":
                    item.ProductionCost = item.Price * 0.2m;
                    break;
                case "USA":
                    item.ProductionCost = item.Price * 0.22m;
                    break;
                default:
                    throw new UnknownProductionCountryException();
            }

            return item.ProductionCost;
        }
    }
}