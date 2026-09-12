using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_01
{
    internal struct DeliveryAddress

    {
        public string City;

        public string Street;

        public int BuildingNumber;


        public DeliveryAddress(string city , string street , int buildingNumber)
        {

            this.City = city;

            this.Street = street;

            this.BuildingNumber = buildingNumber;
            
        }

        public string GetFullAddress()
        {
            return $" City: {City}        Street: {Street}         Building Number: {BuildingNumber} ";
        }
    }
}
