// Collect the bill amount and tip percentage
 Console.WriteLine("Enter yor bill details:\n");
 Console.WriteLine("Bill amount:    ");
 decimal billAmount = Convert.ToDecimal(Console.ReadLine());
 Console.Write("Tip percentage: ");
 decimal tipPercentage = Convert.ToDecimal (Console.ReadLine());
 // Display the entered values
Console.WriteLine("\nBill details:");
Console.WriteLine($" Bill amount: ${billAmount:0.0}");
Console.WriteLine($" Tip percentage: {tipPercentage:0.0}%");
 // Calculate the tip and total
decimal tipAmount = billAmount * (tipPercentage / 100);
decimal totalAmount = billAmount + tipAmount;
Console.WriteLine($"\nTip amount:   ${tipAmount:0.0}");
Console.WriteLine($"Total amount:   ${totalAmount:0.0}");
 // Display the results
