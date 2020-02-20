using System;
using System.Collections.Generic;

    /// <summary> Object class</summary>
    class Obj
    {

    /// <summary> method that  checks if subclass or not</summary>
  

        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            return derivedType.IsSubclassOf(baseType);
        }
    }
