using SecondOOPAssignment;
using System;
#region InternationalShipment class
public class InternationalShipment : Shipment
{
    private string destinationCountry;
    private decimal customsFee;

    public string DestinationCountry
    {
        get { return destinationCountry; }

        set
        {
            if (!string.IsNullOrWhiteSpace(value))


                destinationCountry = value;
        }
    }

    public decimal CustomsFee
    {
        get { return customsFee; }

        set
        {
            if (value >= 0)
                customsFee = value;
        }
    }


    public InternationalShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        string destinationCountry,
        decimal customsFee)
        : base(
            trackingCode,
            description,
            weight,
            deliveryFee,
            destination)
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    }

    public override decimal EstimatedDeliveryTCost
    {
        get
        {
            return deliveryFee + (weight * 5) + CustomsFee;
        }
    }

    public override void printShipmentDetails()
    {
        Console.WriteLine("\nInternational Shipment");

        Console.WriteLine($"Tracking Code      : {trackingCode}");
        Console.WriteLine($"Description        : {description}");
        Console.WriteLine($"Weight             : {weight} KG");
        Console.WriteLine($"Delivery Fee       : {deliveryFee} EGP");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}"); Console.WriteLine($"Destination Country: {DestinationCountry}");
        Console.WriteLine($"Customs Fee        : {CustomsFee} EGP");
        Console.WriteLine($"Estimated Cost     : {EstimatedDeliveryTCost} EGP");
    }
#endregion
}