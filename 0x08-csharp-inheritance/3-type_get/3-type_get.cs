using System;
using System.Collections.Generic;
using System.Reflection;


    /// <summary> Object class</summary>
    class Obj
    {

    /// <summary> prints the names of the available properties</summary>
  

       ///<summary>Printout all propoerties and methods of object</summary>
    public static void Print(object myObj)
	{
		TypeInfo idx = myObj.GetType().GetTypeInfo();
		Console.WriteLine("{0} Properties:", idx.Name);
		foreach (PropertyInfo prop in idx.GetProperties())
		{
			Console.WriteLine(prop.Name);
		}

		Console.WriteLine("{0} Methods:", idx.Name);
		foreach (MethodInfo metInfo in idx.GetMethods())
		{
			Console.WriteLine(metInfo.Name);
		}
	}
    }
