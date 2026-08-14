using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class StandardShipment: Shipment
    {
        public StandardShipment(string trackingCode , string description , decimal weight , decimal deliveryfee , DeliveryAddress destination ):
            base(trackingCode,description , weight, deliveryfee , destination)
        {

        }
    }
}
