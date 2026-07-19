using System.Security.Cryptography.X509Certificates;

namespace assesmentproject_19;

class Program
{
    static void Main(string[] args)
    {

        SalesReport salesReport = new SalesReport();

        salesReport.OrderCount = 120;
        salesReport.Revenue = 45000;
        salesReport.ReportName = "January Sales";

        salesReport.PrintHeader();
        salesReport.PrintBody();

        InventoryReport inventoryReport = new InventoryReport();

        inventoryReport.ProductCount = 3;
        inventoryReport.ReportName = "Inventory Status";

        inventoryReport.PrintHeader();
        inventoryReport.PrintBody();

        Report report;
        report = new SalesReport();
        salesReport.OrderCount = 5;
        salesReport.Revenue =30230;
        report = salesReport;
        report.PrintBody();

        report = new InventoryReport();
        inventoryReport.ProductCount = 943;
        report = inventoryReport;
        report.PrintBody();


        
    }
}
abstract class Report

{
    public string? ReportName { get; set; }



    public void PrintHeader()
    {
        Console.WriteLine($"[Report] {ReportName}");
  
    }
    public abstract void PrintBody();
}
class SalesReport : Report
{
    public override void PrintBody()
    {
        Console.WriteLine($"Order: {OrderCount} - Revenue {Revenue}");
    }
    public int OrderCount { get; set; }

    public decimal Revenue { get; set; }


}

class InventoryReport : Report
{

    public int ProductCount { get; set; }
    public override void PrintBody()
    {
        Console.WriteLine($"Critical Stock: {ProductCount} Products");
    }



}