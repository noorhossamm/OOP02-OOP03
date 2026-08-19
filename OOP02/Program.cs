using System.Threading.Channels;

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





            //Console.WriteLine("Enter Center name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("----------------------------------------");


            //DeliveryCenter c = new DeliveryCenter(name);
            //Shipment[] s =
            //{
            //        new StandardShipment("SH-101", "Laptop", 3,80, new DeliveryAddress("Cairo", "Tahrir", 15)),
            //        new ExpressShipment("SH-102", "Phone", 2, 60, new DeliveryAddress("ALex", "Agamy", 20), 30),
            //        new InternationalShipment("SH-103", "Television", 8, 125, new DeliveryAddress("Sharqia", "Zag", 30), "Germany ",100)
            //};


            //for (int i = 0; i < s.Length; i++)
            //{

            //    c.AddShipment(s[i]);

            //}
            //c.PrintAllShipments();

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




            // Q1
            // a) Method Overloading means having multiple methods with the same name but different parameters[ in count , type , order].
            //    Method Overriding allows a derived class to provide a specific implementation of a method that is already defined in its base class

            // b) Static Binding happens at compile time ,CLR resolve based on refernce type.
            //    Dynamic Binding happens at runtime , CLR resolve based on object type.

            // Q2
            // a) sealed class prevents other classes from inheriting from it.
            // b) sealed class prevents inheritance but a sealed method prevents further overriding of that method.
            // c) No, a sealed method cannot be overridden because sealed keyword stops further overriding.


            //Driver driver = new Driver( 1, "Ahmed Ahmed","010123");


            //Console.WriteLine("Enter Center name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("----------------------------------------");


            //DeliveryCenter center = new DeliveryCenter(name);

            //DeliveryAddress address1 = new DeliveryAddress("Street 1", "Cairo", 10);
            //StandardShipment s1 = new StandardShipment( "SH001", "Laptop", 3, 80,address1);


            //DeliveryAddress address2 =new DeliveryAddress("Street 2", "Giza", 20);
            //ExpressShipment s2 = new ExpressShipment("SH002", "Mobile Phone",2,60,address2,30);

            //DeliveryAddress address3 = new DeliveryAddress("Street 3", "Alexandria", 30);
            //InternationalShipment s3 =new InternationalShipment("SH003","Television",8,120, address3,"Germany",100);

            //center.AddShipment(s1);
            //center.AddShipment(s2);
            //center.AddShipment(s3);

            //center.PrintAllShipments();
            //Console.WriteLine("------------------------------------------");


            //DeliveryHelper d = new DeliveryHelper();
            //Console.WriteLine("Shipment 1 : ");
            //d.PrintShipment(s1);
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Shipment 2 : ");
            //d.PrintShipment(s2);
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Shipment 3 : ");
            //d.PrintShipment(s3);
            //Console.WriteLine("------------------------------------------");


            //s1.UpdateWeight(5);
            //Console.WriteLine($"Updated Weight : {s1.Weight}");
            //Console.WriteLine("------------------------------------------");
            //s1.UpdateWeight(5, 3.5m);
            //Console.WriteLine($"Updated Weight After Packing : {s1.Weight} ");
            //Console.WriteLine("------------------------------------------");



            //Shipment[] shipments =
            //{
            //        new StandardShipment("SH-101", "Laptop", 3,80, new DeliveryAddress("Cairo", "Tahrir", 15)),
            //        new ExpressShipment("SH-102", "Phone", 2, 60, new DeliveryAddress("ALex", "Agamy", 20), 30),
            //        new InternationalShipment("SH-103", "Television", 8, 125, new DeliveryAddress("Sharqia", "Zag", 30), "Germany ",100)
            //};
            //foreach(Shipment s in shipments)
            //{
            //    s.PrintShipmentDetails();
            //    Console.WriteLine("------------------------------------------");
            //}


            // CompletedShipment is sealed, so another class cannot inherit from it .
            // GenerateCustomsReport() is sealed , so it cannot be overridden by another derived class.

            #region ASSIGNMENT 05
            #region Part01
            //Q1)
            //a.Both will refer to the same object as the second variable receives a reference to the same object in memory.
            //b.No it is just one object but 2 variables refer to it.
            //c.Copying the reference means both variables point to the same object so changes through one variable affects the other.
            //Copying the object means creating a separate object  with copied data so changes to one object do not necessarily affect the other.


            #endregion
            #endregion

        }
    }
}