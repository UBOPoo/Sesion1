using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PetRescue
{
    public struct FTileData
    {
        public int tileIndex;
        public Vector2Int boardPosition;

    }

    public class Tile : MonoBehaviour
    {
       protected BoardManager boardManager;

       protected FTileData tileData;

        public Sprite[] sprites = new Sprite[5];

        public int tileIndex { get { return tileData.tileIndex; } }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        public virtual void OnMouseDown()
        {

            boardManager.DestroyTiles(tileData);


        }

        public void DestroyTile()
        {
            Destroy(gameObject);
        }

        public void Initialize(BoardManager boardManagerReference,Vector2Int NewBoardPosition)
        {

            tileData.tileIndex = Random.Range(0, 5);

            GetComponent<SpriteRenderer>().sprite = sprites[tileData.tileIndex];

            boardManager = boardManagerReference;
            tileData.boardPosition = NewBoardPosition;

        }

        
    }
}
