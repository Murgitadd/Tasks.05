using System;

class Program {
  
  public static void Main (string[] args) {
    ATM();
  }

  static void ATM ()
  { 
    Console.WriteLine("===========");
    Console.WriteLine("~~~ATM~~~");
    Console.WriteLine("===========");

    
    double balance = 0;
    bool check = true;

while (check) {
    Console.WriteLine("Emeliyyatı Seç:");
    Console.WriteLine("[1] Balansi goster.");
    Console.WriteLine("[2] Pul cixar.");
    Console.WriteLine("[3] Pul elave et.");
    Console.WriteLine("[0] Cix.");
  
    Console.WriteLine("");
    string choose = Console.ReadLine();
    Console.WriteLine("");
  
    if (choose=="1")
    {
      Console.WriteLine($"Balans:{balance}");
    }
    else if (choose=="2")
    {
      Console.WriteLine("Meblegi daxil et");
      Console.Write("Mebleg: ");
      double withdraw=double.Parse(Console.ReadLine());
      Console.WriteLine("");
      if (balance < withdraw)
      {
        Console.WriteLine("Lazim qeder Pulun yoxdur.");
      }
      else
      {
        balance -= withdraw;
      }
    }
    else if (choose=="3")
    {
      Console.WriteLine("Meblegi elave et");
      Console.Write("Mebleg: ");
      double add=double.Parse(Console.ReadLine());
      Console.WriteLine("");
      balance += add;
    }
    else if (choose=="0")
    {
      Console.WriteLine("Bizi secdiyiniz ucun sag ol.");
      check = false;
    }
    else
    {
      Console.WriteLine("Duzgun secim et.");
    }
  Console.WriteLine("----------------");
   }
  }

  
}
