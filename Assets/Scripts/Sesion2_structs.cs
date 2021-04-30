using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EClass { Warrior,Mage,Rogue,Gatito}

[System.Serializable]
public struct FCharacterData
{
    public int level;
   public float hp;
   public string name;
   public float xp;
    public EClass job;

    public FWeaponData mainWeapon;
     
}

[System.Serializable]
public struct FWeaponData
{
    public int id;
    public string name;
    public float range;
    public float damage;
    public Sprite icon;
}

public class Sesion2_structs : MonoBehaviour
{
    public FCharacterData[] characterData;

    // Start is called before the first frame update
    void Start()
    { 
      FCharacterData characterData=   GetRandomCharacterData(); 
        Debug.Log(characterData.name);
    }

    public FCharacterData GetRandomCharacterData()
    {
        int randomIndex = Random.Range(0, characterData.Length);

        return characterData[randomIndex];
    } 
}
