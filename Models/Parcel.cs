namespace parcelhubwebsite.Models
{
    public class Parcel
    {
        public int Id { get; set; }              // Parcel ID
        public string TrackingNumber { get; set; } // Parcel Tracking Number
        public string Sender { get; set; }        // Sender's name
        public string Receiver { get; set; }      // Receiver's name
        public string Company { get; set; }       // Courier company
    }
}