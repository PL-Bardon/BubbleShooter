using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public int nbr;
    private Board sentinelle;
    private int nbrL;
    public int lenA;
    
    public Game(int nbr = 15)
    {
        if (nbr <= 3)
            throw new Exception("nbr too small");
        this.nbr = nbr;
        this.sentinelle = new Board();
        this.lenA = nbr - 2;
    }

    public void DestroyCell(int i)
    {
        Board next = this.sentinelle.Next;
        if (next == null)
            return;
        while (next.Next != null)
            next = next.Next;
        next.DestroyNearby(i);
        this.nbrL = sentinelle.Next.VerifVoidLine();
    }

    public void MoveBoard()
    {
        Board neww = new Board(this.lenA, this.sentinelle);
        neww.Next = sentinelle.Next;
        if (neww.Next != null)
            neww.Next.F = neww;
        nbr -= 1;
    }

    public bool VerifLose()
    {
        return this.nbrL == this.nbr;
    }
}
