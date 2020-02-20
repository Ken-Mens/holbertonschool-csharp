using System;

///<summary>Class for Shape</summary>
class Shape
{
	///<summary>Throws an error</summary>
	public virtual int Area()
	{
		throw new System.NotImplementedException("Area() is not implemented");
	}
}