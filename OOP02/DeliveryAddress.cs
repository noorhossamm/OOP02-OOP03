using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal struct DeliveryAddress
    {
        private string city;
        private string street;
        private int buildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.buildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"City : {city} , Street : {street} , Building Number :{buildingNumber} ";

        }
    }
}
