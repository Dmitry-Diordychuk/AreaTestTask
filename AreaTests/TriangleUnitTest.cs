using Area;

namespace AreaTests;

public class TriangleUnitTest
{
	[Fact]
	public void TriangleBasicAreaTest()
	{
		Assert.Equal(2.91f, Shape.CreateTriangle(2.0f, 3.0f, 4.0f).GetArea(), 0.01f);
	}
	
	[Fact]
	public void TriangleBasicRightTrueTest()
	{
		Triangle triangle = (Triangle)Shape.CreateTriangle(5.0f, 3.0f, 5.83f);
		Assert.True(triangle.IsRight());
	}
	
	[Fact]
	public void TriangleBasicRightFalseTest()
	{
		Triangle triangle = (Triangle)Shape.CreateTriangle(5.0f, 2.0f, 5.83f);
		Assert.False(triangle.IsRight());
	}
	
	[Fact]
	public void TriangleSideAExceptionTest()
	{
		Assert.Throws<ArgumentException>(() => Shape.CreateTriangle(0.0f, 1.0f, 2.0f));
	}
	
	[Fact]
	public void TriangleSideBExceptionTest()
	{
		Assert.Throws<ArgumentException>(() => Shape.CreateTriangle(1.0f, 0.0f, 2.0f));
	}
	
	[Fact]
	public void TriangleSideCExceptionTest()
	{
		Assert.Throws<ArgumentException>(() => Shape.CreateTriangle(1.0f, 2.0f, 0.0f));
	}
	
	[Fact]
	public void TriangleOneSideLongerOrEqualThanSumOfTwoOtherSidesExceptionTest()
	{
		Assert.Throws<ArgumentException>(() => Shape.CreateTriangle(1.0f, 2.0f, 3.0f));
	}
	
	[Fact]
	public void TriangleIsTriangleTest()
	{
		Assert.IsType<Triangle>(Shape.CreateTriangle(2.0f, 3.0f, 4.0f));
	}
}