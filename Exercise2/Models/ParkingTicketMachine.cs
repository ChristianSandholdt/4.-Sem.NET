namespace Exercise2.Models
{
    public class ParkingTicketMachine
    {
        public int MinutesPrKr { get; set; }
        public int[] cointsToInsert { get; set; }
        public int amountInserted { get; set; }
        public DateTime timenow { get; set; }
        //-----------------------------------------
        public readonly List<int> coinsToInsert;

        public readonly DateTime TimeNow;
        public readonly DateTime PaidUntil;

        public readonly int AmountInserted;

        //-----------------------------------------
        public ParkingTicketMachine(int minutesPrKr, int cointsToInsert)
        {
            MinutesPrKr = minutesPrKr;
            timenow = DateTime.Now;
            amountInserted = 0;
        }
    }
}
