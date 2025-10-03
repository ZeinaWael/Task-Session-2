Console.WriteLine("<- Welcome to Islam's cleaning service ->");

Console.Write("Enter the number of small carpets : ");
int small = int.Parse(Console.ReadLine());

Console.Write("Enter the number of large carpets : ");
int large = int.Parse(Console.ReadLine());

Console.WriteLine("Price per small room : $25");
Console.WriteLine("Price per large room : $35");

double cost = (small * 25) + (large * 35);
double tax = cost * 0.06;

Console.WriteLine($"your cost before tax : ${cost.ToString("C")}");
Console.WriteLine("Tax : " + tax.ToString("C"));

Console.WriteLine("--------------------");

double total = cost + tax;
Console.WriteLine($"Total estimate : {total.ToString("C")}");

Console.WriteLine("Note !");
Console.WriteLine("This estimate is vaild for 30 days");

