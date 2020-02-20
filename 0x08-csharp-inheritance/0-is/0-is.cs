using System;
using System.Collections.Generic;

    /// <summary> Object class</summary>
    class Obj
    {

    /// <summary> method that returns true if obj is int</summary>
  	///<returns>T or F</returns>
    public static bool IsOfTypeInt(object obj)
        {
            return obj is int;
        }
    }
