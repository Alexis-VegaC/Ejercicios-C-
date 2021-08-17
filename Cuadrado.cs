public class Cuadrado : Figura
{

	//Lado del cuadrado 
	private double l1;

	// Constructor
	public Cuadrado(string nombre, double l1) : base(nombre)
	{
		this.l1 = l1;
	}

	//Area del cuadrado 
	public override double area()
	{
		return l1 * l1;
	}

	//Perimetro del cuadrado
	public virtual double perimetro()
	{
		return 4 * l1;
	}

	//get
	private double L1
	{
		get
		{
			return l1;
		}
		set
		{
			this.l1 = value;
		}
	}


}
