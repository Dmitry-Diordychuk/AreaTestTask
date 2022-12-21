namespace Area;

public class Triangle : Shape
{
	private readonly float _minSide;
	private readonly float _midSide;
	private readonly float _maxSide;
	
	public Triangle(float sideA, float sideB, float sideC)
	{
		ValidateSideValue(sideA);
		ValidateSideValue(sideB);
		ValidateSideValue(sideC);

		float minAB = Single.Min(sideA, sideB);
		float maxAB = Single.Max(sideA, sideB);
		float min = Single.Min(minAB, sideC);
		float mid = Single.Max(minAB, Single.Min(maxAB, sideC));
		float max = Single.Max(maxAB, sideC);

		if (max >= min + mid)
		{
			throw new ArgumentException($"One side of the triangle is longer equal than sum of other two sides.");
		}

		_minSide = min;
		_midSide = mid;
		_maxSide = max;
		Console.WriteLine($"Analisies: {min} {mid} {max}");
	}

	public override float GetArea()
	{
		float s = (_minSide + _midSide + _maxSide) / 2.0f;
		return MathF.Sqrt(s * (s - _minSide) * (s - _midSide) * (s - _maxSide));
	}

	public bool IsRight()
	{
		return Math.Abs(MathF.Pow(_maxSide, 2.0f) - MathF.Pow(_minSide, 2.0f) - MathF.Pow(_midSide, 2.0f)) < 0.1f;
	}

	private static void ValidateSideValue(float side)
	{
		if (side <= 0.0f)
		{
			throw new ArgumentException($"Side must be greater than 0.0f", nameof(side));
		}
	}
}