// Math >= 90 OR Chemistry >=90 OR 

//math && chemistry || math && biology || chemistry && biology

int math, biology, chemistry;

Console.WriteLine("enter your math resault:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry resault:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry resault:");
chemistry = Int32.Parse(Console.ReadLine());


if ((math >= 90 && chemistry >=90) || (math >= 90 && biology >=90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congartulations! You are accepted!");
}
else
{
    Console.WriteLine("Yor application cannot be approved.");
}
