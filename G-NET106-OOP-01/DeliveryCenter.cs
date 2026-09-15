using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_01
{
    internal struct DeliveryCenter
    {

        #region Question05
        Shipment[] shipments;

        public DeliveryCenter()
        {

            shipments = new Shipment[10];
        }

        public Shipment this[int index]
        {
            get
            {
                if (shipments == null || index < 0 || index >= shipments.Length)
                {
                    return default;
                }
                return shipments[index];
            }
            set
            {

                if (shipments != null && index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }


        public Shipment this[string trackingCode]
        {
            get
            {
                if (shipments == null || string.IsNullOrWhiteSpace(trackingCode))
                {
                    return default;
                }


                foreach (var s in shipments)
                {
                    if (s.TrackingCode != null && s.TrackingCode == trackingCode)
                    {
                        return s;
                    }
                }

                return default;
            }

        }


        public bool AddShipment(Shipment shipment)
        {
            if (shipments == null)
            {
                shipments = new Shipment[10];
            }

            for (int i = 0; i < shipments.Length; i++)
            {

                if (string.IsNullOrEmpty(shipments[i].TrackingCode))
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;

        #endregion
        }


    }
}
