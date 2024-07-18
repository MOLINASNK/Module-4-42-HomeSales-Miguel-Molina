using System;

class Program {
  
  public static void Main (string[] args) {
    
    double totalD = 0, totalE = 0, totalF = 0, saleAmount; 
    char initial;

    while (true)
    {
      Console.Write("Enter the salesperson initial (D,E,F) or Z to quit: ");
      initial = Char.ToUpper(Console.ReadLine()[0]);

      if (initial == 'Z')
      {
        break;
      }
      if (initial != 'D' && initial != 'E' && initial != 'F')
      {
        Console.WriteLine(" Invalid initial. Please enter D, E, or F.");
        continue;
      }
      Console.Write("Enter the sale amount: ");
      while (!Double.TryParse(Console.ReadLine(), out saleAmount) || saleAmount < 0)
      {
        Console.WriteLine("Invalid sale amount. Please enter a positive number.");
        Console.Write("Enter Sale Amount");
      }
      switch (initial)
      {
      case 'D':
        totalD += saleAmount;
        break;
      case 'E':
        totalE += saleAmount;
        break;
      case 'F':
        totalF += saleAmount;
        break;
      }
      }
    {
    double grandTotal = totalD + totalE + totalF;

    Console.WriteLine("\nSales Totals:");
    Console.WriteLine($"Danielle: ${totalD:F2}");
    Console.WriteLine($"Edward: ${totalE:F2}");
    Console.WriteLine($"Francis: ${totalF:F2}");
    Console.WriteLine($"Grand Total: ${grandTotal:F2}");
    
    string highestSalesperson = "Danielle";
    double highestTotal = totalD;

    if (totalE > highestTotal)
      {
        highestSalesperson = "Edward";
        highestTotal = totalE;
      }

    if (totalF > highestTotal)
    {
      highestSalesperson = "Francis";
      highestTotal = totalF;
    }

    Console.WriteLine($"Highest Salesperson: {highestSalesperson} with ${highestTotal:F2}");
    }
  }
}