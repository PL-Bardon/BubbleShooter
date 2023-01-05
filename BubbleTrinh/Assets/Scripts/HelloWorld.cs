using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    public int x = 0;
    void Start()
    {
        Exercise exo = new Exercise();
        //exo.Exo1();
        Debug.Log("exo2");
        exo.Exo2();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log("Hello Wordl " + x + " times");
        x++;
        */
    }
}

public class Exercise
{
    public void Exo1()
    {
        for (int i = 0; i < 6; i++)
        {
            Debug.Log("Radius: " + i + ", Area: " + getAreaCircle(i)); // ((int)(getAreaCircle(i)*100))/100.0);
        }
    }

    public double getAreaCircle(int r)
    {
        return Math.Round(Math.PI *r* r,2);
    }
    
    public void Exo2()
    {
        int Tc, Tf = 0, Tk;
        int[] a = new[] {0, 32, 212};
        for (int i = 0; i < 3; i++)
        {
            Tf = a[i];
            Debug.Log("temperature en Fahrenheit = " + Tf);
            Tc = ConvertFtoC(Tf);
            Debug.Log("temperature en Celsius = " + Tc);
            Tf = ConvertCtoF(Tc);
            Debug.Log("temperature en Fahrenheit = " + Tf);
        }
       
    }

    public int ConvertFtoC(int Tf)
    {
        return (int) ((Tf - 32) / 1.8);
    }

    public int ConvertCtoF(int Tc)
    {
        return (int) (Tc * 1.8) + 32;
    }

    public void Exo3()
    {
        Die die1 = new Die();
        Die die2 = new Die();
        die1.RandP();
        die2.RandP();
        Debug.Log(die1.Face+die2.Face);
    }
}

public class Die
{
    private int face;
    private System.Random r;

    public int Face
    {
        get { return this.face; }
        set
        {
            if (value > 0 && value<= 6)
                this.face = value;
            else
            {
                throw new Exception("Dice value not good");
            }
        }
    }

    public Die()
    {
        this.face = 0;
        this.r = new System.Random();
    }

    public void Roll()
    {
        this.face = this.r.Next(0, 6);
    }

    public void Print()
    {
        if (this.face == 0)
            this.Roll();
        Debug.Log(this.face);
    }

    public void RandP()
    {
        this.Roll();
        this.Print();
    }
}