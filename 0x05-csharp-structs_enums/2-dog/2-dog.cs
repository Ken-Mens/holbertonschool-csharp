using System;

enum Rating { Good, Great, Excellent };

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    public Dog(string nm, float ag, string own, Rating rt)
    {
        name = nm;
        age = ag;
        owner = own;
        rating = rt;
    }
}