using SecondOOPAssignment;
using System;
#region DeliveryCenter class
public class DeliveryCenter
{
    private Shipment[] shipments;

    public string CenterName { get; set; }

    public DeliveryCenter(string centerName)
    {
        if (!string.IsNullOrWhiteSpace(centerName))
       
        CenterName = centerName;
        shipments = new Shipment[20];
    }

    public Shipment this[string trackingCode]
    {
        get
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].trackingCode.ToLower()//34ann avoid case sensitivity 
                    == trackingCode.ToLower())
                {
                    return shipments[i];
                }
            }

            return null;
        }
    }

    public Shipment this[int index]
    {
        get
        {
            if (index >= 0 && index < shipments.Length)
            {
                return shipments[index];
            }

            return null;
        }

        set
        {
            if (index >= 0 && index < shipments.Length)
            {
                shipments[index] = value;
            }
        }
    }

    public bool AddShipment(Shipment shipment)
    {
        if (shipment == null)
            return false;

        if (this[shipment.trackingCode] != null)
            return false;

        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] == null)
            {
                shipments[i] = shipment;
                return true;
            }
        }

        return false;
    }

    public bool RemoveShipment(string trackingCode)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] != null &&
                shipments[i].trackingCode.ToLower()
                == trackingCode.ToLower())
            {
                for (int j = i; j < shipments.Length - 1; j++)
                {
                    shipments[j] = shipments[j + 1];
                }

                shipments[shipments.Length - 1] = null;

                return true;
            }
        }

        return false;
    }

    public void PrintAllShipments()
    {
        Console.WriteLine("==================================");
        Console.WriteLine($"Delivery Center: {CenterName}");
        Console.WriteLine("==================================");

        bool found = false;

        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] != null)
            {
                shipments[i].printShipmentDetails();

                Console.WriteLine("----------------------------------");

                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No shipments available.");
        }
    }
#endregion
}