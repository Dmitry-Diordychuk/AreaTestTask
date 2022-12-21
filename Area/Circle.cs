namespace Area;

public class Circle : Shape
{
	private readonly float _radius;

	public Circle(float radius)
	{
		if (radius <= 0.0f)
		{
			throw new ArgumentException($"Radius must be greater than 0.0f", nameof(radius));
		}
		
		_radius = radius;
	}
	
	public override float GetArea()
	{
		return MathF.PI * MathF.Pow(_radius, 2.0f);
	}
}