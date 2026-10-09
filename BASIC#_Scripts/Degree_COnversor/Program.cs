// Store a Fahrenheit temperature
 Console.WriteLine("Enter Fahrenheit Degree: ");
decimal Fahren = Convert.ToDecimal (Console.ReadLine());
// Convert it to Celsius and Kelvin
decimal Celsius = (Fahren - 32) * 5 / 9;
decimal Kelvin = Celsius + 273;
// Display the result
Console.WriteLine($@"{Fahren}°F is {Celsius:0.0}°C");
Console.WriteLine($@"{Celsius:0.0}°C is {Kelvin:0.0}K");
if(Celsius < 20 && Celsius > 15)
{
    Console.WriteLine("It´s getting cold!");
} else if (Celsius < 15) {
    Console.WriteLine("It's Freazing!!");}
if (Celsius >= 20 && Celsius <= 30) {Console.WriteLine("It´s a cozy weather!");}
 else if(Celsius > 30) {Console.WriteLine("It is hot as an oven!!");}
 
 