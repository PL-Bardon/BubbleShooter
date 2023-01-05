using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    public Game gameControler;
    public Event input;
    public System.Random r;
    void Start()
    {
        gameControler = new Game(15);
        input = new Event();
        r = new System.Random();
    }

    private void Update()
    {
        input = Event.current;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gameControler.DestroyCell(r.Next(0,this.gameControler.lenA-1));
            gameControler.MoveBoard();
        }
        
    }
}