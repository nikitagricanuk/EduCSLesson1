Console.Write("Enter first digit: ");
int digit1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second digit: ");
int digit2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third digit: ");
int digit3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(digit1 > digit2 && digit1 > digit3) Console.Write(Convert.ToString(digit1) + " is bigger");
else if(digit2 > digit3 && digit2 > digit1) Console.Write(Convert.ToString(digit2) + " is bigger");
else Console.Write(Convert.ToString(digit3) + " is bigger");