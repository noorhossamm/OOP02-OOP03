using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class InternationalShipment :Shipment
    {
        private string destinationCountry;
        private decimal customsFee;
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination , string destinationCountry, decimal customsFee) :
            base(trackingCode, description, weight, deliveryfee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;

        }
        public string DestinationCountry 
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Invalid Country");
               destinationCountry = value;

            }
        }
        public decimal CustomsFee 
        { 
            get { return customsFee; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Value cannot be negative.");
                customsFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }

        public override void PrintShipmentDetails()
        {
            base.PrintShipmentDetails();
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: ${CustomsFee}");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report: {TrackingCode} - {DestinationCountry} - Customs Fee: {CustomsFee} EGP");
        }
    }
}
