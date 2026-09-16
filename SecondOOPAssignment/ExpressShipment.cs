using System;

namespace SecondOOPAssignment
{
    #region ExpressShipment class
    public class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }

            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            ExtraFee = extraFee;
        }

        public override decimal EstimatedDeliveryTCost
        {
            get
            {
                return deliveryFee + (weight * 5) + ExtraFee;
            }
        }

        public override void printShipmentDetails()
        {
            Console.WriteLine("Express Shipment");

            Console.WriteLine($"Tracking Code : {trackingCode}");
            Console.WriteLine($"Description   : {description}");
            Console.WriteLine($"Weight        : {weight} KG");
            Console.WriteLine($"Delivery Fee  : {deliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}"); Console.WriteLine(
                $"Estimated Cost: {EstimatedDeliveryTCost} EGP");
        }
    }
    #endregion
}