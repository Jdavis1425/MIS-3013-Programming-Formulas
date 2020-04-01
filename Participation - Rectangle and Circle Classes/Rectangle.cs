using System;

class Rectangle
{
	public double Length { get; set; }
	public double Width { get; set; }

	public Rectangle()
	{
		Length = 0;
		Width = 0;
	}

	public double CalculateArea()
	{
		double Area = Width * Length;
		return Area;

	}
	public double CalculatePerimeter()
	{
		double Perimeter = 2 * (Length + Width);
		return Perimeter;
	}
}	
