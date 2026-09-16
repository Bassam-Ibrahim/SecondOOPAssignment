using SecondOOPAssignment;

class Program
{
    public static void Main(string[] args)
    {
        #region Theoretical Questions
        /*
        Question Number 1
        a) The class is reference type and supports inheritance,
           and the struct is value type and does not support inheritance.

        b) The class supports inheritance, so it will be easy for large
           projects. We will not write a lot of code and it will be easy
           to maintain, but the struct is value type and does not support
           inheritance, so it will be hard to maintain and write a lot of code.

        Question Number 2
        a) Parent class is Shipment.
        b) Child class is ExpressShipment.
        c) ExpressShipment inherits the TrackingCode property from Shipment.
        d) The child class can use the members of the parent class.
        */
        #endregion

        #region Last Question Main Testing

        Console.WriteLine("===== Smart Delivery Management System =====");


        string centerName;

        do
        {
            Console.Write("Enter Delivery Center Name: ");
            centerName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(centerName))
            {
                Console.WriteLine("Center name cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(centerName));

        DeliveryCenter center = new DeliveryCenter(centerName);



        Console.WriteLine("\n===== Enter Standard Shipment Data =====");

        string standardTrackingCode;

        do
        {
            Console.Write("Enter Tracking Code: ");
            standardTrackingCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(standardTrackingCode))
            {
                Console.WriteLine("Tracking code cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(standardTrackingCode));


        string standardDescription;

        do
        {
            Console.Write("Enter Description: ");
            standardDescription = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(standardDescription))
            {
                Console.WriteLine("Description cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(standardDescription));


        decimal standardWeight;
        bool isValidStandardWeight;

        do
        {
            Console.Write("Weight: ");

            isValidStandardWeight =
                decimal.TryParse(
                    Console.ReadLine(),
                    out standardWeight
                );

            if (!isValidStandardWeight || standardWeight <= 0)
            {
                Console.WriteLine("Please enter a number greater than zero.");
            }

        } while (!isValidStandardWeight || standardWeight <= 0);


        decimal standardDeliveryFee;
        bool isValidStandardDeliveryFee;

        do
        {
            Console.Write("Delivery Fee: ");

            isValidStandardDeliveryFee =
                decimal.TryParse(
                    Console.ReadLine(),
                    out standardDeliveryFee
                );

            if (!isValidStandardDeliveryFee || standardDeliveryFee < 0)
            {
                Console.WriteLine(
                    "Please enter a number greater than or equal to zero."
                );
            }

        } while (!isValidStandardDeliveryFee || standardDeliveryFee < 0);


        string standardCity;

        do
        {
            Console.Write("Enter City: ");
            standardCity = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(standardCity))
            {
                Console.WriteLine("City cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(standardCity));


        string standardStreet;

        do
        {
            Console.Write("Enter Street: ");
            standardStreet = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(standardStreet))
            {
                Console.WriteLine("Street cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(standardStreet));


        int standardBuildingNumber;
        bool isValidStandardBuildingNumber;

        do
        {
            Console.Write("Enter Building Number: ");

            isValidStandardBuildingNumber =
                int.TryParse(
                    Console.ReadLine(),
                    out standardBuildingNumber
                );

            if (!isValidStandardBuildingNumber || standardBuildingNumber <= 0)
            {
                Console.WriteLine(
                    "Building number must be a positive integer."
                );
            }

        } while (
            !isValidStandardBuildingNumber ||
            standardBuildingNumber <= 0
        );


        DeliveryAddress standardAddress =
            new DeliveryAddress(
                standardCity,
                standardStreet,
                standardBuildingNumber
            );


        StandardShipment standardShipment =
            new StandardShipment(
                standardTrackingCode,
                standardDescription,
                standardWeight,
                standardDeliveryFee,
                standardAddress
            );

        center.AddShipment(standardShipment);



        Console.WriteLine("\n===== Enter Express Shipment Data =====");

        string expressTrackingCode;

        do
        {
            Console.Write("Enter Tracking Code: ");
            expressTrackingCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(expressTrackingCode))
            {
                Console.WriteLine("Tracking code cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(expressTrackingCode));


        string expressDescription;

        do
        {
            Console.Write("Enter Description: ");
            expressDescription = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(expressDescription))
            {
                Console.WriteLine("Description cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(expressDescription));


        decimal expressWeight;
        bool isValidExpressWeight;

        do
        {
            Console.Write("Weight: ");

            isValidExpressWeight =
                decimal.TryParse(
                    Console.ReadLine(),
                    out expressWeight
                );

            if (!isValidExpressWeight || expressWeight <= 0)
            {
                Console.WriteLine("Please enter a number greater than zero.");
            }

        } while (!isValidExpressWeight || expressWeight <= 0);


        decimal expressDeliveryFee;
        bool isValidExpressDeliveryFee;

        do
        {
            Console.Write("Delivery Fee: ");

            isValidExpressDeliveryFee =
                decimal.TryParse(
                    Console.ReadLine(),
                    out expressDeliveryFee
                );

            if (!isValidExpressDeliveryFee || expressDeliveryFee < 0)
            {
                Console.WriteLine(
                    "Please enter a number greater than or equal to zero."
                );
            }

        } while (!isValidExpressDeliveryFee || expressDeliveryFee < 0);


        decimal extraFee;
        bool isValidExtraFee;

        do
        {
            Console.Write("Extra Fee: ");

            isValidExtraFee =
                decimal.TryParse(
                    Console.ReadLine(),
                    out extraFee
                );

            if (!isValidExtraFee || extraFee < 0)
            {
                Console.WriteLine(
                    "Please enter a number greater than or equal to zero."
                );
            }

        } while (!isValidExtraFee || extraFee < 0);


        string expressCity;

        do
        {
            Console.Write("Enter City: ");
            expressCity = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(expressCity))
            {
                Console.WriteLine("City cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(expressCity));


        string expressStreet;

        do
        {
            Console.Write("Enter Street: ");
            expressStreet = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(expressStreet))
            {
                Console.WriteLine("Street cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(expressStreet));


        int expressBuildingNumber;
        bool isValidExpressBuildingNumber;

        do
        {
            Console.Write("Enter Building Number: ");

            isValidExpressBuildingNumber =
                int.TryParse(
                    Console.ReadLine(),
                    out expressBuildingNumber
                );

            if (!isValidExpressBuildingNumber || expressBuildingNumber <= 0)
            {
                Console.WriteLine(
                    "Building number must be a positive integer."
                );
            }

        } while (
            !isValidExpressBuildingNumber ||
            expressBuildingNumber <= 0
        );


        DeliveryAddress expressAddress =
            new DeliveryAddress(
                expressCity,
                expressStreet,
                expressBuildingNumber
            );


        ExpressShipment expressShipment =
            new ExpressShipment(
                expressTrackingCode,
                expressDescription,
                expressWeight,
                expressDeliveryFee,
                expressAddress,
                extraFee
            );

        center.AddShipment(expressShipment);



        Console.WriteLine("\n===== Enter International Shipment Data =====");

        string internationalTrackingCode;

        do
        {
            Console.Write("Enter Tracking Code: ");
            internationalTrackingCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(internationalTrackingCode))
            {
                Console.WriteLine("Tracking code cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(internationalTrackingCode));


        string internationalDescription;

        do
        {
            Console.Write("Enter Description: ");
            internationalDescription = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(internationalDescription))
            {
                Console.WriteLine("Description cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(internationalDescription));


        decimal internationalWeight;
        bool isValidInternationalWeight;

        do
        {
            Console.Write("Weight: ");

            isValidInternationalWeight =
                decimal.TryParse(
                    Console.ReadLine(),
                    out internationalWeight
                );

            if (!isValidInternationalWeight || internationalWeight <= 0)
            {
                Console.WriteLine("Please enter a number greater than zero.");
            }

        } while (
            !isValidInternationalWeight ||
            internationalWeight <= 0
        );


        decimal internationalDeliveryFee;
        bool isValidInternationalDeliveryFee;

        do
        {
            Console.Write("Delivery Fee: ");

            isValidInternationalDeliveryFee =
                decimal.TryParse(
                    Console.ReadLine(),
                    out internationalDeliveryFee
                );

            if (
                !isValidInternationalDeliveryFee ||
                internationalDeliveryFee < 0
            )
            {
                Console.WriteLine(
                    "Please enter a number greater than or equal to zero."
                );
            }

        } while (
            !isValidInternationalDeliveryFee ||
            internationalDeliveryFee < 0
        );


        string destinationCountry;

        do
        {
            Console.Write("Enter Destination Country: ");
            destinationCountry = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(destinationCountry))
            {
                Console.WriteLine("Country cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(destinationCountry));


        decimal customsFee;
        bool isValidCustomsFee;

        do
        {
            Console.Write("Customs Fee: ");

            isValidCustomsFee =
                decimal.TryParse(
                    Console.ReadLine(),
                    out customsFee
                );

            if (!isValidCustomsFee || customsFee < 0)
            {
                Console.WriteLine(
                    "Please enter a number greater than or equal to zero."
                );
            }

        } while (!isValidCustomsFee || customsFee < 0);


        string internationalCity;

        do
        {
            Console.Write("Enter City: ");
            internationalCity = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(internationalCity))
            {
                Console.WriteLine("City cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(internationalCity));


        string internationalStreet;

        do
        {
            Console.Write("Enter Street: ");
            internationalStreet = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(internationalStreet))
            {
                Console.WriteLine("Street cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(internationalStreet));


        int internationalBuildingNumber;
        bool isValidInternationalBuildingNumber;

        do
        {
            Console.Write("Enter Building Number: ");

            isValidInternationalBuildingNumber =
                int.TryParse(
                    Console.ReadLine(),
                    out internationalBuildingNumber
                );

            if (
                !isValidInternationalBuildingNumber ||
                internationalBuildingNumber <= 0
            )
            {
                Console.WriteLine(
                    "Building number must be a positive integer."
                );
            }

        } while (
            !isValidInternationalBuildingNumber ||
            internationalBuildingNumber <= 0
        );


        DeliveryAddress internationalAddress =
            new DeliveryAddress(
                internationalCity,
                internationalStreet,
                internationalBuildingNumber
            );


        InternationalShipment internationalShipment =
            new InternationalShipment(
                internationalTrackingCode,
                internationalDescription,
                internationalWeight,
                internationalDeliveryFee,
                internationalAddress,
                destinationCountry,
                customsFee
            );

        center.AddShipment(internationalShipment);



        Console.WriteLine("\n===== All Shipments =====");

        center.PrintAllShipments();



        Console.WriteLine("\n===== Search Shipment =====");

        string searchTrackingCode;

        do
        {
            Console.Write("Enter Tracking Code: ");
            searchTrackingCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(searchTrackingCode))
            {
                Console.WriteLine("Tracking code cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(searchTrackingCode));


        Shipment searchedShipment =
            center[searchTrackingCode];

        if (searchedShipment != null)
        {
            Console.WriteLine("\nShipment Found:");
            searchedShipment.printShipmentDetails();
        }
        else
        {
            Console.WriteLine("Shipment not found.");
        }



        Console.WriteLine("===== Remove Shipment =====");

        string removeTrackingCode;

        do
        {
            Console.Write("Enter Tracking Code: ");
            removeTrackingCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(removeTrackingCode))
            {
                Console.WriteLine("Tracking code cannot be empty. Try again.");
            }

        } while (string.IsNullOrWhiteSpace(removeTrackingCode));


        bool removed =
            center.RemoveShipment(removeTrackingCode);

        if (removed)
        {
            Console.WriteLine("Shipment removed successfully.");
        }
        else
        {
            Console.WriteLine("Shipment not found.");
        }



        Console.WriteLine("\n===== Remaining Shipments =====");

        center.PrintAllShipments();


        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();

        #endregion
    }
}