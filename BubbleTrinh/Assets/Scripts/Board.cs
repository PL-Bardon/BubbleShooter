using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private List<Balls> a;
    private Board next;
    private Board f;
    private int max;
    /*
     public List<Balls> BallsList
    {
        get { return this.a; }
        set { this.a = value; }
    }

    public int Max
    {
        get { return this.max; }
        set { this.max = value; }
    }*/
    public Board Next 
    {
            get { return this.next; }
            set { this.next = value; }
    }
    public Board F
    {
        get { return this.f; } 
        set { this.f = value; }
    }
    public Board(int max,Board father)
    {
        this.a = GetNewList();
        this.next = null;
        this.max = max;
        this.f = father;
    }
    
    public Board()
    {
        this.next = null;
        this.max = 0;
        this.a = null;
        this.f = null;
    }
        
    private List<Balls> GetNewList()
    {
        List<Balls> a = new List<Balls>();
        for (int len = this.max; len > 0; len--)
        {
            a.Add(new Balls());
        }
    
        return a;
    }
    
    public int VerifVoidLine()
    {
        bool z = true;
        for (int i = 0; i < this.max; i++)
        {
            if (this.a[i] != null)
            { 
                z = false;
                break;
            }
        }
    
        if (z)
        {
            this.f.Next = null;
            return 0;
        }
        else
            return 1 + this.next.VerifVoidLine();
             
    }
    public void DestroyNearby(int i)
    {
        if (this.a == null)
            return;
        Balls.Color c = this.a[i].C;
        this.a[i] = null;
        if (i > 0)
        {
            if (this.a[i-1].C == c)
                DestroyNearby(i-1);
                
        }
        if (i < this.max - 2)
        {
            if (this.a[i+1].C == c)
                DestroyNearby(i+1);
        }
    
        if (this.f != null)
        {
            DestroyNearby(i);
        } 
    }
}