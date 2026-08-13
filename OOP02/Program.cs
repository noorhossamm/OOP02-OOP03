namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 01
            //a)A class is a reference type, while a struct is a value type.
            //Classes support inheritance, while structs do not support class inheritance.
            //Classes are usually used for more complex objects, while structs are suitable for small data structures.
            //b)Because classes support inheritance, polymorphism, and reference-type behavior, which makes code easier to organize, reuse, and maintain.
            //Question 02
            //a)  Shipment
            //b) ExpressShipment
            //c) TrackingCode()
            //d)To reuse common code from the parent class instead of writing the same code again
            //Improving maintainability and reducing duplication





        //    Console.WriteLine("Enter Center name: ");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("----------------------------------------");


        //    DeliveryCenter c = new DeliveryCenter(name);
        //    Shipment[] s =
        //    {
        //        new StandardShipment("SH-101", "Laptop", 3,80, new DeliveryAddress("Cairo", "Tahrir", 15)),
        //        new ExpressShipment("SH-102", "Phone", 2, 60, new DeliveryAddress("ALex", "Agamy", 20), 30),
        //        new InternationalShipment("SH-103", "Television", 8, 125, new DeliveryAddress("Sharqia", "Zag", 30), "Germany ",100)
        //};


        //    for(int i= 0 ; i< s.Length; i++)
        //    {

        //        c.AddShipment(s[i]);

        //    }
        //    c.PrintAllShipments();

        //    string trackingCode;
        //    do
        //    {
        //        Console.Write("Enter Tracking Code: ");
        //         trackingCode = Console.ReadLine();
        //    } while (string.IsNullOrEmpty(trackingCode));

        //    Console.WriteLine("--------------------------------------------");

        //    Shipment searchedShipment = c[trackingCode];
        //    Console.WriteLine(searchedShipment);

        //    c.RemoveShipment("SH-102");
        //    Console.WriteLine("After removal :");
        //    c.PrintAllShipments();

        }
    }
}