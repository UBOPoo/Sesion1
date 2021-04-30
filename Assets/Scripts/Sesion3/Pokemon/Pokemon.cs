using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public enum EPokeType { Fire,Water,Plant,Lighting,Rock,Psychic,Ghost,Normal}

[System.Serializable]
public class Pokemon
{
    public string name;
    public EPokeType pokeType;
    public float hp;
    public Sprite portrait;


}