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
    public static double AreaOfCircle(double radius) {
        throw new NotImplementedException();
    }
    
    public static double AreaOfTriangle(double triangleBase, double triangleHeight){
        
        throw new NotImplementedException();
    }

}


