Console.Write("Please enter first digit: ");
int digit1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter second digit: ");
int digit2 = Convert.ToInt32(Console.ReadLine());

if(digit1 > digit2) Console.WriteLine(Convert.ToString(digit1) + " is bigger");
else Console.WriteLine(Convert.ToString(digit2) + " is bigger");