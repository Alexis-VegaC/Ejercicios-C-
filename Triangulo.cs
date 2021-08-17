
public class Triangulo : Figura
{

	//Lados del triangulo 
	private double l1, l2, l3;

	// Constructor
	public Triangulo(string nombre, double l1, double l2, double l3) : base(nombre)
	{
		this.l1 = l1;
		this.l2 = l2;
		this.l3 = l3;
	}

	//Area del triangulo 
	public override double area()
	{
		return 0.5 * (l1 + l2 + l3);
	}

	//Perimetro del triangulo
	public virtual double perimetro()
	{
		return l1 + l2 + l3;
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

	private double L2
	{
		get
		{
			return l2;
		}
		set
		{
			this.l2 = value;
		}
	}

	private double L3
	{
		get
		{
			return l3;
		}
		set
		{
			this.l3 = value;
		}
	}




}
