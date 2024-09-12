using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chesspiece : MonoBehaviour
{
    public GameObject controller;
    //public GameObject Tile;
    public int Xboard = -2;
    public int Yboard = -2;
    string Player;
    public Sprite BlackKing, BlackQueen, BlackKnight, BlackBishop, BlackRook, BlackPawn;
    public Sprite WhiteKing, WhiteQueen, WhiteKnight, WhiteBishop, WhiteRook, WhitePawn;
    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");
        SetPlayerPos();
        switch(this.name)
        {
            case "BlackQueen": this.GetComponent<SpriteRenderer>().sprite = BlackQueen; break; 
            case "BlackKing": this.GetComponent<SpriteRenderer>().sprite = BlackKing; break;
            case "BlackBishop": this.GetComponent<SpriteRenderer>().sprite = BlackBishop; break; 
            case "BlackKnight": this.GetComponent<SpriteRenderer>().sprite = BlackKnight; break;
            case "BlackRook": this.GetComponent<SpriteRenderer>().sprite = BlackRook; break;
            case "BlackPawn": this.GetComponent<SpriteRenderer>().sprite = BlackPawn; break;

            case "WhitePawn": this.GetComponent<SpriteRenderer>().sprite = WhitePawn; break;
            case "WhiteQueen": this.GetComponent<SpriteRenderer>().sprite = WhiteQueen; break;
            case "WhiteKing": this.GetComponent<SpriteRenderer>().sprite = WhiteKing; break;
            case "WhiteBishop": this.GetComponent<SpriteRenderer>().sprite = WhiteBishop; break;
            case "WhiteKnight": this.GetComponent<SpriteRenderer>().sprite = WhiteKnight; break;
            case "WhiteRook": this.GetComponent<SpriteRenderer>().sprite = WhiteRook; break;


        }

    }
    public void SetPlayerPos()
    {
        float X = Xboard;
        float Y = Yboard;

        X *= .66f;
        Y *= .66f;

        X += -2.3f;
        Y += -2.3f;

        this.transform.position = new Vector3(X, Y, -1);
    }
    //public int GetXBoard()
    //{
    //    return Xboard;
    //}
    //public int GetYBoard()
    //{
    //    return Yboard;
    //}
    //public void SetXboard(int x)
    //{
    //    Xboard =x ;
    //}
    //public void SetYBoard(int y)
    //{
    //    Yboard = y;
    //}

}


