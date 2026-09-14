using System;
using System.Collections.Generic;
using System.Text;

namespace SecondOOPAssignment
{
    #region standard shipment class
    public class StandardShipment : Shipment
    {
    
        public StandardShipment( string trackingCode,string description, decimal weight, decimal deliveryFee,DeliveryAddress destination) : base( trackingCode,description,weight,deliveryFee,destination)
        {
        
        }

        public  override void printShipmentDetails()
        {
            System.Console.WriteLine("Standard Shipment");
            base.printShipmentDetails();
        }
    }
    #endregion
}
