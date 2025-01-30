namespace Supplement1.Tests;

public class UnitTest1
{
    [Fact]
    
public void ShouldCalculateAreaOfRectangleWithDifferentLengthAndWidth()
{
    Assert.True(50.0 == supplement1.AreaOfRectangle(5.0, 10.0));
}

    [Fact]
public void ShouldCalculateArea0fRectangleWithSameLengthAndWidth()
  {

  Assert.True(25.0 == supplement1.AreaOfRectangle(5.0, 5.0));
  
  }

  public void ShouldCalculateArea0fUnitCircle()
  {

  Assert.True(double.Pi == supplement1.AreaOfCircle(1.0));
  
  }
}
