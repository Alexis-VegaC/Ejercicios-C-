
public class Main
{

	public static void Main(string[] args)
	{

	  Triangulo t1 = new Triangulo("triangulo", 5, 3, 7);
	  Cuadrado c1 = new Cuadrado("cuadrado", 5);
	  Rectangulo r1 = new Rectangulo("rectangulo", 6, 8);
	  Trapecio tra1 = new Trapecio("trapecio", 3, 6, 7, 9);

	  Console.WriteLine(t1.area());
	  Console.WriteLine(t1.perimetro());

	  Console.WriteLine(c1.area());
	  Console.WriteLine(c1.perimetro());

	  Console.WriteLine(r1.area());
	  Console.WriteLine(r1.perimetro());
	  Console.WriteLine(tra1.perimetro());
	}
}

