using Area;

namespace AreaTests;

public class CircleUnitTest
{
	[Fact]
	public void CircleBasicAreaTest()
	{
		Assert.Equal(78.54f, Shape.CreateCircle(5.0f).GetArea(), 0.01f);
	}
	
	[Fact]
	public void CircleExceptionTest()
	{
		Assert.Throws<ArgumentException>(() => Shape.CreateCircle(0.0f));
	}

	[Fact]
	public void CircleIsCircleTest()
	{
		Assert.IsType<Circle>(Shape.CreateCircle(1.0f));
	}
}