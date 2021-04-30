using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Dealer : MonoBehaviour
{

    public Pokemon[] pokedex;
    public FPokeColor[] pokeColors;
    public int dealSize = 6;
     
    public GameObject cardPrefab;

    // Start is called before the first frame update
    void Start()
    {
        RandomDeal();
    }

    public Color GetPokeColor(EPokeType pokeType)
    {
        for (int i = 0; i < pokeColors.Length; i++)
        {
            if (pokeColors[i].pokeType == pokeType)
                return pokeColors[i].color;
        }

        return Color.black;

    }

    public void RandomDeal()
    {

        Vector3 spawnLocation = Vector3.zero;
        //selecciono 6 datos de cartas al azar
        // instancio 6 prefab de cartas
        // le pasa a cada instancia de prefab la informacion

        GameObject pokemonCardInstance=     Instantiate(cardPrefab, spawnLocation, Quaternion.identity);

        pokemonCardInstance.GetComponent<PokemonCard>().Initialize(pokedex[0],GetPokeColor(pokedex[0].pokeType));


    }
   
}
