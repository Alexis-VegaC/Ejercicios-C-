
public class Rectangulo : Figura
{

	//Base y altura
	private double b, h;

	// Constructor
	public Rectangulo(string nombre, double b, double h) : base(nombre)
	{
		this.b = b;
		this.h = h;
	}

	//Area del rectangulo 
	public override double area()
	{
		return b * h;
	}

	//Perimetro del rectangulo
	public virtual double perimetro()
	{
		return 2 * (h + b);
	}

	//get
	private double B
	{
		get
		{
			return b;
		}
		set
		{
			this.b = value;
		}
	}

	private double H
	{
		get
		{
			return h;
		}
		set
		{
			this.h = value;
		}
	}



}