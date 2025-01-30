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

   [Fact]
        public void ShouldCalculateAreaOfUnitCircle()
        {
            Assert.True(Math.PI == supplement1.AreaOfCircle(1.0));
        }

  
}
