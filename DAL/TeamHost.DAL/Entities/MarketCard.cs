namespace TeamHost.DAL.Entities
{
    public class MarketCard : BaseEntity
    {
        public string ItemName { get; set; }
        public string GameName { get; set; }
        public double StartingPrice { get; set; }
        public double Quantity { get; set; }
        public string PhotoPath { get; set; }
    }
}
