using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComplete : MonoBehaviour
{
    public void Quit(){
        Debug.Log("Quit");
        Application.Quit();
    }
}
