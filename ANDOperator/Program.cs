// Math >= 90; Biology >=90; Chemistry >=90;


int math, biology, chemistry;

Console.WriteLine("enter your math resault:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology resault:");
biology =Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry resault:");
chemistry =Int32.Parse(Console.ReadLine());


if (math >= 90 && biology >=90 && chemistry >= 90)
{
    Console.WriteLine("Congartulations! You are accepted!");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}

