using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessgame : MonoBehaviour
{
    public GameObject chesspiece;
    GameObject[,] positions = new GameObject[8, 8];
    GameObject[] PlayerWhite = new GameObject[16];
    GameObject[] PlayerBlack = new GameObject[16];
    string Currentplayer = "White";
    bool GameOver = false;

    private void Start()
    {
        //Instantiate(chesspiece,new Vector3(0,0,-1), Quaternion.identity);
        PlayerWhite = new GameObject[]
        {
            Create("WhiteRook",0,0),  Create("WhiteKnight",1,0),  Create("WhiteBishop",2,0),  Create("WhiteQueen",3,0),
            Create("WhiteKing",4,0),  Create("WhiteBishop",5,0),  Create("WhiteKnight",6,0),  Create("WhiteRook",7,0),
            Create("WhitePawn",0,1),  Create("WhitePawn",1,1),    Create("WhitePawn",2,1),    Create("WhitePawn",3,1),
            Create("WhitePawn",4,1),  Create("WhitePawn",5,1),    Create("WhitePawn",6,1),    Create("WhitePawn",7,1)
        };
        PlayerBlack = new GameObject[]
        {
             Create("BlackRook",0,7),  Create("BlackKnight",1,7),  Create("BlackBishop",2,7),  Create("BlackQueen",3,7),
            Create("BlackKing",4,7),  Create("BlackBishop",5,7),  Create("BlackKnight",6,7),  Create("BlackRook",7,7),
            Create("BlackPawn",0,6),  Create("BlackPawn",1,6),    Create("BlackPawn",2,6),    Create("BlackPawn",3,6),
            Create("BlackPawn",4,6),  Create("BlackPawn",5,6),    Create("BlackPawn",6,6),    Create("BlackPawn",7,6)
        };
     for (int i = 0; i < PlayerBlack.Length; i++)
        {
            SetPosition(PlayerBlack[i]);
            SetPosition(PlayerBlack[i]);
        }

    }
    public GameObject Create(string name, int x, int y)
    {
        GameObject obj = Instantiate(chesspiece, new Vector3(0,0, -1), Quaternion.identity);
        Chesspiece piece=obj.GetComponent<Chesspiece>();
        piece.name=name;
        piece.Xboard = x;
        piece.Yboard = y;
        piece.Activate();
        return obj;
            
    }
    public void SetPosition(GameObject obj)
    {
        Chesspiece cp = obj.GetComponent<Chesspiece>();
       positions[cp.Xboard, cp.Yboard]= obj;
    }












}


