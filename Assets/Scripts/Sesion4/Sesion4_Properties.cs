using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Character
{
    [SerializeField]  private float m_hp;
    private float m_maxHp;

    [SerializeField]  private string name;

    public Character(float NewHp)
    {
        m_hp = m_maxHp = NewHp;

    }

    public float hp
    {
        get
        {
            return m_hp;
        }

        set
        {
            m_hp = Mathf.Clamp(value, 0, m_maxHp);
        }

    }

    public void ApplyDamage(float Damage)
    {

        hp -= Damage;
     //   hp = hp - Damage;

    }
    public void RecoverHp(float AddHp)
    {

        hp += AddHp;
        //hp = hp + AddHp;

    }
    public string Name
    {
        set
        {
            
            if(value=="")
            name =  "Default";
            else
                name = value;

        }
    }


}


public class Sesion4_Properties : MonoBehaviour
{
   public Character warrior = new Character(10);
    // Start is called before the first frame update
    void Start()
    {


        warrior.Name = "Peter";
        Debug.Log(warrior.hp);


        ///aca bva pco
        


        warrior.ApplyDamage(22);
     

    }

    private void Update()
    {
      //  warrior.RecoverHp(Time.deltaTime);
     // Debug.Log(warrior.hp);
    }


}
