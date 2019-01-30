using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {
    float random;
    
	// Use this for initialization
	void Start () {
       
        getStrings();

        //Console.WriteLine("Hello World"); //keine Ausgabe in Unity Console
        //Debug.Log("Hello World");

        ////Aufruf Methode
        //float number = getRandom();
        //Debug.Log("number random: " + number);

    }

    //deklaration Methode
    void getStrings()
    {
        string doSomething = "Hallo";

        if (doSomething == "Hallo")
        {
            Debug.Log("Hallo");
        }

        if (doSomething == "Hallo")
        {
            Debug.Log("Hallo1");
        }

        if (doSomething == "Hallo")
        {
            Debug.Log("Hallo2");
        }

        string doSomethingMore = "Tschuess";

        if (doSomethingMore == "Tschuess1")
        {
            Debug.Log("Tschuess");
        }

        else if (doSomethingMore == "Tschuess")
        {
            Debug.Log("Tschuess1");
        }
        else if (doSomethingMore == "Tschuess")
        {
            Debug.Log("Tschuess2");
        }
        else
        {
            Debug.Log("Default");
        }


        //string random = "";
        //float random = 3;
        //random = UnityEngine.Random.Range(0f, 10f);
        //return random; 
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
