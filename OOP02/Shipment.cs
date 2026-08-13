using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class Shipment
    {
        #region Attributes
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        #endregion

        #region Properties
        public DeliveryAddress Destination { get; set; }
        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tracking code cannot be null or empty.");
                }
                trackingCode = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Description cannot be null or empty.");
                }
                description = value;
            }
        }

        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Weight must be a positive value.");
                }
                weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Delivery fee cannot be negative.");
                }
                deliveryFee = value;
            }
        }

        public virtual decimal EstimatedCost
        {
            get
            {
                return (DeliveryFee + (Weight * 5));
            }
        }
        #endregion

        #region Constructor
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);

        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;

        }
        #endregion

        #region Methods
        public void UpdateDeliveryFee(decimal newFee)
        {
            if(newFee>=0)
            DeliveryFee = newFee;

            else 
                throw new ArgumentOutOfRangeException("Delivery fee must be a positive value.");

        }

        public void PrintShipmentDetails()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
            Console.WriteLine($"Destination Address: {Destination.GetFullAddress()}");
        }

        #endregion

        override public string ToString()
        {
            return $"Tracking Code: {TrackingCode}\n Description: {Description}\n Weight: {Weight} kg\n Delivery Fee: ${DeliveryFee}\n Estimated Cost: ${EstimatedCost}, \n Destination Address: {Destination.GetFullAddress()}";
        }
    }
}
