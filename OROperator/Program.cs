//Math >= 90 OR Chemistry >=90 Biology >= 90

//math && chemistry || math && biology || chemistry && biology

int math, biology, chemistry;

Console.WriteLine("Eter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Eter your Biology result:");
biology = Int32.Parse(Console.ReadLine());


Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >=90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Cangratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}