using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Animal
{
    abstract public string name {get;}
    abstract public int maxap {get;}
    abstract public int ap {get; set;}
    abstract public int maxhp {get;}
    abstract public int hp {get; set;}
    abstract public int atk {get; set;}
    abstract public int def {get; set;}
    abstract public int upkeep {get; set;}
    Terrain[] startingTerrain;
    Diet[] dietTypes;

    //void move();
    //void attack();
    //void heal();
    //void gather();
}

class Beaver : Animal
{
    override public string name {
        get {return "Beaver"; }
    }
    override public int maxap {
        get { return 4;}
        }
    int _ap = 4; 
    override public int ap {
        get { return _ap;}
        set{ _ap = value;}
        }
    override public int maxhp {
        get { return 25;}
        }
    int _hp = 25; 
    override public int hp {
        get { return _hp;}
        set{ _hp = value;}
        }
    override public int atk {
        get { return 15;}
        set{ }
        }
    override public int def {
        get { return 15;}
        set{ }
        }
    override public int upkeep {
        get { return 5;}
        set{ }
        }
    Terrain[] startingTerrain = { Terrain.River };
    Diet[] dietTypes = {Diet.Forage};
}

class BlackBear : Animal
{
    override public string name {
        get {return "Bear"; }
    }
    override public int maxap {
        get { return 4;}
        }
    int _ap = 4; 
    override public int ap {
        get { return _ap;}
        set{ _ap = value;}
        }
    override public int maxhp {
        get { return 100;}
        }
    int _hp = 100; 
    override public int hp {
        get { return _hp;}
        set{ _hp = value;}
        }
    override public int atk {
        get { return 60;}
        set{ }
        }
    override public int def {
        get { return 60;}
        set{ }
        }
    override public int upkeep {
        get { return 15;}
        set{ }
        }
    Terrain[] startingTerrain = { Terrain.Forest, Terrain.Mountain };
    Diet[] dietTypes = { Diet.Forage, Diet.Preditor };
}
/*
class Deer : Animal
{
    public override string name()
    {
        return "Deer";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int maxap = 4;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Plains };
    Diet[] dietTypes = { Diet.Graize };
}



class GrizzlyBear: Animal
{
    public override string name()
    {
        return "Grizzly Bear";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Forest, Terrain.Mountain };
    Diet[] dietTypes = { Diet.Forage, Diet.Preditor};
}

class Squirrel : Animal
{
    public override string name()
    {
        return "Squirrel";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Forest };
    Diet[] dietTypes = { Diet.Forage };
}

class Fox : Animal
{
    public override string name()
    {
        return "Fox";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Forest };
    Diet[] dietTypes = { Diet.Preditor, Diet.Forage };
}
class Mouse : Animal
{
    public override string name()
    {
        return "Mouse";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Plains };
    Diet[] dietTypes = { Diet.Forage  };
}

class Wolf : Animal
{
    public override string name()
    {
        return "Wolf";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Forest, Terrain.Mountain };
    Diet[] dietTypes = { Diet.Preditor };
}

class Racoon : Animal
{
    public override string name()
    {
        return "Racoon";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Forest };
    Diet[] dietTypes = { Diet.Forage };
}

class Moose : Animal
{
    public override string name()
    {
        return "Meese";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Plains };
    Diet[] dietTypes = { Diet.Graize };
}

class  Porcupine: Animal
{
    public override string name()
    {
        return "Porcupine";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Forest, Terrain.Plains };
    Diet[] dietTypes = { Diet.Graize, Diet.Forage };
}

class Skunk : Animal
{
    public override string name()
    {
        return "Skunk";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Forest, Terrain.Plains };
    Diet[] dietTypes = { Diet.Preditor, Diet.Forage };
}

class Eagle : Animal
{
    public override string name()
    {
        return "Eagle";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Mountain };
    Diet[] dietTypes = { Diet.Preditor };
}

class Groundhog : Animal
{
    public override string name()
    {
        return "Groundhog";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Plains };
    Diet[] dietTypes = { Diet.Forage };
}

class Snake : Animal
{
    public override string name()
    {
        return "Snek";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Forest, Terrain.Plains };
    Diet[] dietTypes = { Diet.Preditor };
}

class Bison : Animal
{
    public override string name()
    {
        return "Bison";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Plains };
    Diet[] dietTypes = { Diet.Graize };
}

class Owl : Animal
{
    public override string name()
    {
        return "Owl";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Forest };
    Diet[] dietTypes = { Diet.Preditor };
}

class BighornSheep : Animal
{
    public override string name()
    {
        return "Bighorn Sheep";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Mountain };
    Diet[] dietTypes = { Diet.Graize };
}

class Rabbit : Animal
{
    public override string name()
    {
        return "Rabbit";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Plains };
    Diet[] dietTypes = { Diet.Forage };
}
class MountainLion : Animal
{
    public override string name()
    {
        return "Mountain Lion";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.Mountain };
    Diet[] dietTypes = { Diet.Preditor };
}
class Goose : Animal
{
    public override string name()
    {
        return "Devil Bird";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    int upkeep = 5;
    Terrain[] startingTerrain = { Terrain.River };
    Diet[] dietTypes = { Diet.Graize };
}
*/

