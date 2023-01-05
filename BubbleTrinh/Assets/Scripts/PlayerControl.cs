using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public Rigidbody2D player;
    private Vector2 posPlayer;
    public int deplacement;
    public int sizeOfPanel;
    public Game gameControler;
    private int X;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        gameControler = GetComponent<Game>();
    }

    // Update is called once per frame
    void Update()
    {
        posPlayer = player.position;
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (posPlayer.x <= sizeOfPanel-deplacement)
                posPlayer = new Vector2(posPlayer.x + deplacement, posPlayer.y);
            else
                posPlayer = new Vector2(sizeOfPanel, posPlayer.y);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (posPlayer.x >= deplacement)
                posPlayer = new Vector2(posPlayer.x - deplacement, posPlayer.y);
            else
                posPlayer = new Vector2(0, posPlayer.y);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            X = VerifIndex();
            gameControler.DestroyCell(X);
        }
    }

    public int VerifIndex()
    {
        return (int) this.player.position.x / this.sizeOfPanel * this.gameControler.lenA;
    }
}
