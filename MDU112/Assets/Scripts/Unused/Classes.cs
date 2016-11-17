using UnityEngine;
using System.Collections.Generic;


public class Classes
{
    //Creates random attributes on a scale of 
    public float Stamina = Random.Range(1, 50);
    public float Strength = Random.Range(1, 50);
    public float Agility = Random.Range(1, 50);
    public float Acuity = Random.Range(1, 50);

    private float _Health;
    private float _Damage;
    private float _DodgeChance;
    private float _CritChance;
    public string _ClassName;

    //Creates list for names
    public static List<string> NameList = new List<string>();

    public Classes()
    {
        //Convert attributes to stats
        _Health = Stamina * 2;
        _Damage = Strength * 2;
        _DodgeChance = Agility * 2;
        _CritChance = Acuity * 2;

        //Takes a random name from the name list and assigns it to the character
        int RandomName = (int)UnityEngine.Random.Range(1, Battle.NameList.Count);
        _ClassName = Battle.NameList[RandomName];
    }

    public float Health
    {
        get { return _Health; }
        set { _Health = value; }
    }

    public float Damage
    {
        get { return _Damage; }
        set { _Damage = value; }
    }

    public float DodgeChance
    {
        get { return _DodgeChance ; }
        set { _DodgeChance = value; }
    }

    public float CritChance
    {
        get { return _CritChance; }
        set { _CritChance = value; }
    }
}