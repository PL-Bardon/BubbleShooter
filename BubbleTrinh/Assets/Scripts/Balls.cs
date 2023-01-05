using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public enum Color
    {
        Red,
        Blue,
        Green,
        Yellow,
    }

    private Color c;

    public Color C
    {
        get { return this.c; }
        set { this.c = value; }
    }
    public Balls()
    {
        this.c = this.GetRandom();
    }

    private Color GetRandom()
    {
        System.Random r = new System.Random();
        int x = r.Next(0, 3);
        return (Color) x;
    }
}
