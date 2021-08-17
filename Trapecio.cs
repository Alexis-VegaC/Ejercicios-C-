
public class Trapecio : Figura
{

	//Lados de un trapecio
	private double bmayor, bmenor, c, d;

	// Constructor
	public Trapecio(string nombre, double bmayor, double bmenor, double c, double d) : base(nombre)
	{

		this.bmayor = bmayor;
		this.bmenor = bmenor;
		this.c = c;
		this.d = d;
	}

	//Perimetro del trapecio 
	public virtual double perimetro()
	{
		return bmayor + bmenor + c + d;
	}

	//get y set
	public virtual double Bmayor
	{
		get
		{
			return bmayor;
		}
		set
		{
			this.bmayor = value;
		}
	}


	public virtual double Bmenor
	{
		get
		{
			return bmenor;
		}
		set
		{
			this.bmenor = value;
		}
	}


	public virtual double C
	{
		get
		{
			return c;
		}
		set
		{
			this.c = value;
		}
	}


	public virtual double D
	{
		get
		{
			return d;
		}
		set
		{
			this.d = value;
		}
	}


	public override double area()
	{
		throw new System.NotSupportedException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
	}

}
