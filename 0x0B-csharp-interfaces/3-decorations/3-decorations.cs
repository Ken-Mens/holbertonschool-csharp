using System;

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
