using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number between " + min + "-" + max + ", but don't tell me what it is...");
        Debug.Log("Is your number higher or lower than " + guess + "?");
        Debug.Log("Push the Up Arrow Key for higher, or push the Down Arrow Key for lower; push the Enter key if the number is correct.");
    }

    // Update is called once per frame
    void Update() {
     if (Input.GetKeyDown(KeyCode.UpArrow)){
         min = guess;
         guess = (max + min) / 2;
         Debug.Log("Is it higher or lower than " + guess + "?");
     }
     else if (Input.GetKeyDown(KeyCode.DownArrow)){
         max = guess;
         guess = (max + min) / 2;
         Debug.Log("Is it higher or lower than " + guess + "?");

     }
     else if (Input.GetKeyDown(KeyCode.Return)){
         Debug.Log("I am a genius.");
     }
    }
}
