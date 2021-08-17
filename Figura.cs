public abstract class Figura
{

	//Nombre de la figura
	private string nombre;

	//Constructor
	public Figura(string nombre)
	{
		this.nombre = nombre;

	}

	//Calcular el area de una figura
	public abstract double area();

	protected internal virtual string Nombre
	{
		get
		{
			return this.nombre;
		}
		set
		{
			this.nombre = value;
		}
	}

}
