using System;

namespace PetPals.Entity
{
    public abstract class Donation
    {
        public string DonorName { get; set; }
        public decimal Amount { get; set; }

        public Donation(string donorName, decimal amount)
        {
            DonorName = donorName;
            Amount = amount;
        }

        public abstract void RecordDonation();
    }
}
