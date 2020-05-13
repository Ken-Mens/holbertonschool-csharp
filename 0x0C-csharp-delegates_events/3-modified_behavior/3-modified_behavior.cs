using System;

///<summary>Calculates modifiers.</summary>
public enum Modifier
{
    ///<summary>Weak modifier</summary>
    Weak = 1,
    ///<summary>Base modifier</summary>
    Base = 2,
    ///<summary>Strongest modifier</summary>
    Strong = 3
}

/// <summary>Will apply effect based on tier modifier.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>Will calculate health.</summary>

public delegate void CalculateHealth(float health);

///<summary> Public Player class</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>Player Class Constructor.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary>Prints Player health.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
       ///<summary> Will calculate Player damage.</summary>
    public void TakeDamage(float damage)
    {
        Console.WriteLine($"{this.name} takes {damage} damage!");
        if (damage <= 0f)
            this.hp -= damage;
            this.ValidateHP(this.hp - damage);
    }
    ///<summary>Will calculate Player healing.</summary>
    public void HealDamage(float heal)
    {
        Console.WriteLine($"{this.name} heals {heal} HP!");
           if (this.hp >= 0)
            this.ValidateHP(this.hp + heal);
    }

    ///<summary>Sets new value of Player hp.</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else 
            this.hp = newHp;
    }
    ///<summary>Will Validate Player hp modifications.</summary>
      public float ApplyModifier(float baseValue, Modifier modifier) 
      {
       return (baseValue * ((float)modifier / 2f));
      }
}
