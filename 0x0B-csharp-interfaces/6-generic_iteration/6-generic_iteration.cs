using System;
using System.Collections.Generic;


///<summary>Base class.</summary>
public abstract class Base
{
    ///<summary>Name of instance.</summary>
    public string name;

    ///<summary>String override.</summary>
    public override string ToString()
    {
        return (name + " is a " + this.GetType().ToString());
    }
}
interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}
class Door : Base, IInteractive
{

    public Door(string val = "Door")
    {
        name = val;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem = false;
    public int durability { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 1)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    public void Interact()
    {
        if (durability < 1)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }
    public void Break()
    {
        durability --;
        if (durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", name);
        else if (durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", name);
        else if (durability < 0)
            Console.WriteLine("The {0} is already broken.", name);
    }
}

/// <summary></summary>
public class Key : Base, ICollectable
{
    /// <summary>Determines wheter the key is collected or inherited from.</summary>
    public bool isCollected { get; set; }

    /// <summary>Forms a key construct.</summary>
    /// <param name="name">Object's name.</param>
    /// <param name="isCollected">Whether the object has been collected or not.</param>
    public Key(string name="Key", bool isCollected=false) {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>Picking up the key.</summary>
    public void Collect() {
        if (this.isCollected)
            Console.WriteLine("You have already picked up the {0}.", this.name);
        else
            Console.WriteLine("You pick up the {0}.", this.name);
        this.isCollected = true;
    }
}
/// <summary>Stores a list of objects in the room</summary>
public class Objs<T> : System.Collections.Generic.List<T>
{
}