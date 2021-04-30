using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[System.Serializable]
public struct FPokeColor
{
   public EPokeType pokeType;
   public Color color;
}


public class PokemonCard : MonoBehaviour
{
    public TextMeshPro nameText;
    public TextMeshPro hpText;
    public SpriteRenderer frame;
    public SpriteRenderer portrait;



    public void Initialize(Pokemon pokemon,Color color)
    {
        nameText.SetText(pokemon.name);
        hpText.SetText(pokemon.hp.ToString());
        portrait.sprite = pokemon.portrait;
        frame.color = color;
    }

}
