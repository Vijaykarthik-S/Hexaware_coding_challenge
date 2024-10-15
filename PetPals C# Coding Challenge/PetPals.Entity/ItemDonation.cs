using System;

namespace PetPals.Entity
{
    public class ItemDonation : Donation
    {
        public string ItemType { get; set; }

        public ItemDonation(string donorName, decimal amount, string itemType)
            : base(donorName, amount)
        {
            ItemType = itemType;
        }

        public override void RecordDonation()
        {
            Console.WriteLine($"Item donation of type '{ItemType}' worth {Amount:C} from {DonorName} recorded.");
        }
    }
}
