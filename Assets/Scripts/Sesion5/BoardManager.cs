using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PetRescue
{
    public class BoardManager : MonoBehaviour
    {
        public Vector2Int boardSize = new Vector2Int(7,7);

        public GameObject tilePrefab;

        public float tileOffSet = 1.4f;

        Tile[,] board;

        // Start is called before the first frame update
        void Start()
        {
            InitializeBoard();
        }


        public void DestroyTiles(FTileData tileData)
        {
            Debug.Log(tileData.boardPosition);

            /*
            xxxxxxxxx  
            xxx0xxxx  y+1
    0    x-1    xx01000xxxx   x +1
            xxx0xxxx  y-1
            xxxxxxxx0
             
             
             */

            //for para  la derecha 
            for (int x = tileData.boardPosition.x; x < boardSize.x; x++)
            {
                //safe check // null check 
                if (board[x, tileData.boardPosition.y] == null) break;
                if (board[x, tileData.boardPosition.y].tileIndex != tileData.tileIndex) break;

                if (board[x,tileData.boardPosition.y].tileIndex==tileData.tileIndex)
                {
                    board[x, tileData.boardPosition.y].DestroyTile();
                }

            }

            //for para la izquierda 
            for (int x = tileData.boardPosition.x; x >=0; x--)
            {
                //safe check // null check 
                if (board[x, tileData.boardPosition.y] == null) break;
                if (board[x, tileData.boardPosition.y].tileIndex != tileData.tileIndex) break;


                if (board[x, tileData.boardPosition.y].tileIndex == tileData.tileIndex)
                {
                    board[x, tileData.boardPosition.y].DestroyTile();
                }
            }



            //for para  la up 
            for (int y = tileData.boardPosition.y; y < boardSize.y; y++)
            {
                //safe check // null check 
                if (board[tileData.boardPosition.x, y] == null) break;
                if (board[tileData.boardPosition.x, y].tileIndex != tileData.tileIndex) break;


                if (board[tileData.boardPosition.x, y].tileIndex == tileData.tileIndex)
                {
                    board[tileData.boardPosition.x,y].DestroyTile();
                }
            }

            //for para la izquierda 
            for (int y = tileData.boardPosition.y; y >=0; y--)
            {
                if (board[tileData.boardPosition.x, y] == null) break;
                if (board[tileData.boardPosition.x, y].tileIndex != tileData.tileIndex) break;

                if (board[tileData.boardPosition.x, y].tileIndex == tileData.tileIndex)
                {
                    board[tileData.boardPosition.x, y].DestroyTile();
                }
            }

            board[tileData.boardPosition.x, tileData.boardPosition.y].DestroyTile();
        }

        void Refill()
        {
            ///buscar nulls 
            /// /////version dificil
            ///opcion 1- mover las hacia abajo 
            ///        - Instanciar nuevas piezas en los espacios vacios superiores
            //version facil
            ///opcion 2- instanciar en los espacios null
        }


        public void Explode(FTileData tileData)
        {
            ///destruye un area alrededor de 
             //bomb tambien tiene tileData.boardPosition
        }
        void InitializeBoard()
        {
            Vector3 SpawnPosition = Vector3.zero;
            Vector2Int boardPosition = Vector2Int.zero;

            board = new Tile[boardSize.x,boardSize.y];

            for (int x = 0; x < boardSize.x; x++)
            {
                for (int y = 0; y < boardSize.y; y++)
                {
                    SpawnPosition.x = x * tileOffSet;
                    SpawnPosition.y = y * tileOffSet;
                    boardPosition.x = x;
                    boardPosition.y = y;

                    GameObject tile=       Instantiate(tilePrefab, SpawnPosition, Quaternion.identity);
                    tile.GetComponent<Tile>().Initialize(this,boardPosition);

                    board[x, y] = tile.GetComponent<Tile>();


                }
            }
        }

         
    }

}
