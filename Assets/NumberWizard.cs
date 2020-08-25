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
    }

    // Update is called once per frame
    void Update() {
     if (Input.GetKeyDown(KeyCode.UpArrow)){
         min = guess;
         Debug.Log(guess);
     }
     else if (Input.GetKeyDown(KeyCode.DownArrow)){
         max = guess;
         Debug.Log(guess);
     }
     else if (Input.GetKeyDown(KeyCode.Return)){
         Debug.Log("Return key was pressed.");
     }
    }
}
