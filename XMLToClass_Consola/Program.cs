// Pasar fichero XML a clase, y recorrer los clientes
using XMLToClass_Consola.Clases;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Pulsa intro para pasar el fichero a una clase y recorrerla");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadLine();

Root r = new Root();
string ficheroXML = @"C:\MTDEV\VisualStudio\XMLToClass_Consola\XMLToClass_Consola\xsd_schemas\CustomersOrders.xml";
var xUtil = new xmlUtil();
xUtil.DesSerializar(ref r, ficheroXML);

foreach(var c in r.Customers)
{
    Console.WriteLine(c.ContactName);
}


// Modificar un cliente en la clase y mostrarlos de nuevo
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Pulsa intro para modificar un cliente y recorrer de nuevo la clase");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadLine();


r.Customers[1].ContactName = "Cliente Modificado";
string ficheroResultado = "C:\\MTDEV\\VisualStudio\\XMLToClass_Consola\\XMLToClass_Consola\\Clases\\NuevoFichero.xml";
xUtil.Serializar(r, ficheroResultado);
Console.ReadLine();



