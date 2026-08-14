using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class ExpressShipment:Shipment
    {

        private decimal extraFee;

        #region Constructor
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination , decimal extrafee) :
            base(trackingCode, description, weight, deliveryfee, destination)
        {
            Extrafees = extrafee;

        } 
        #endregion
        #region Property
        public decimal Extrafees
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Value cannot be negative.");
                extraFee = value;

            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + Extrafees;
            }
        }

        public override void PrintShipmentDetails()
        {
            base.PrintShipmentDetails();
            Console.WriteLine($"Extra Fee: ${Extrafees}");
        }
        #endregion
    }
}
