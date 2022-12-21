namespace Area;

public abstract class Shape
{
	public static Shape CreateCircle(float radius)
	{
		return new Circle(radius);
	}

	public static Shape CreateTriangle(float sideA, float sideB, float sideC)
	{
		return new Triangle(sideA, sideB, sideC);
	}
	
	public abstract float GetArea();
}