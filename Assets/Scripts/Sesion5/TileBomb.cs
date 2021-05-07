using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PetRescue
{
    public class TileBomb : Tile
    {
        public override void OnMouseDown()
        {

            boardManager.Explode(tileData);
        }
    }
}
