using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Human
{
    public virtual string name()
    {
        return "Asshole";
    }

    int maxhp;
    int hp;
    int attack;
    int defence;
    int ap;
    Terrain[] startingTerrain;

    //void move();
    //void attack();
    //void destroyTerrain();
}

class Lumberjack : Human
{
    public override string name()
    {
        return "Lumberjack";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    Terrain[] startingTerrain = { };
}

class Chainsaw : Human
{
    public override string name()
    {
        return "Chainsaw Massacre";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    Terrain[] startingTerrain = { };
}

class Bulldozer : Human
{
    public override string name()
    {
        return "Bulldozer";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    Terrain[] startingTerrain = { };
}

class Hunter : Human
{
    public override string name()
    {
        return "Hunter";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    Terrain[] startingTerrain = { };
}

class TreeHarvester : Human
{
    public override string name()
    {
        return "Tree Harvester";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    Terrain[] startingTerrain = { };
}

class RoadPaver : Human
{
    public override string name()
    {
        return "Road Paver";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    Terrain[] startingTerrain = { };
}

class Farmer : Human
{
    public override string name()
    {
        return "Farmer";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    Terrain[] startingTerrain = { };
}

class Builder : Human
{
    public override string name()
    {
        return "Builder";
    }
    const int maxhp = 25;
    int hp = 25;
    int attack = 0;
    int defence = 0;
    int ap = 4;
    Terrain[] startingTerrain = { };
}