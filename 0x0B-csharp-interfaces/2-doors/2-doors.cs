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