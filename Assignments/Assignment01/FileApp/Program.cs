using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

var salesData = new Dictionary<string, decimal>
{
    { "JanuarySales.txt", 1200.50m },
    { "FebruarySales.txt", 980.75m },
    { "MarchSales.txt", 1432.10m }
};

WriteSalesSummary(salesData);
Console.WriteLine("SalesSummary.txt created!");

static void WriteSalesSummary(Dictionary<string, decimal> salesData)
{
    var sb = new StringBuilder();
    decimal total = 0;

    sb.AppendLine("Sales Summary");
    sb.AppendLine("----------------------------");

    foreach (var item in salesData)
    {
        sb.AppendLine($"{item.Key}: {item.Value.ToString("C")}");
        total += item.Value;
    }

    sb.AppendLine();
    sb.AppendLine($"Total Sales: {total.ToString("C")}");

    File.WriteAllText("SalesSummary.txt", sb.ToString());
}
