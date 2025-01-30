namespace Supplement1;

public class supplement1 
{
/// <summary>
/// Returns the are of a rectangle. if the length is equal to the width,
/// the calculation is done as lenght*lenght instead 
/// </summary>
/// <param name="length"> lenght of the rectangle </param>
/// <param name="width"> widht of the rectangle </param>
/// <returns> Area of the rectange</returns>
    public static double AreaOfRectangle(double length, double width) {
       if(length == width){
        return length * length;
       }
    else{
        return length * width;
    }
       
    }

    /// <summary>
    /// Returns the area of the circle
    /// </summary>
    /// <param name="radius"> Radius of a circle</param>
    /// <returns> The radius of a circle with a given radius.</returns>
    public static double AreaOfCircle(double radius) {
       return double.Pow(radius,2.0)* double.Pi;
    }
    
    public static double AreaOfTriangle(double triangleBase, double triangleHeight){
        
       return triangleBase * triangleHeight / 2;
    }

}


