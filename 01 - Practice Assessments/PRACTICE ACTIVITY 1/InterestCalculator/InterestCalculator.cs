Console.Write("Enter principal amount: ");
float principalAmount = float.Parse(Console.ReadLine());
Console.Write("Enter rate of interest: ");
float rateOfInterest = float.Parse(Console.ReadLine());
Console.Write("Enter time in years: ");
float timeInYears = float.Parse(Console.ReadLine()); 

float simpleInterest = (principalAmount * rateOfInterest * timeInYears) / 100;
Console.WriteLine("Simple Interest: " + simpleInterest);