using System;

namespace PetPals.Entity
{
    public class CashDonation : Donation
    {
        public DateTime DonationDate { get; set; }

        public CashDonation(string donorName, decimal amount, DateTime donationDate)
            : base(donorName, amount)
        {
            DonationDate = donationDate;
        }

        public override void RecordDonation()
        {
            Console.WriteLine($"Cash donation of {Amount:C} from {DonorName} on {DonationDate.ToShortDateString()} recorded.");
        }
    }
}
