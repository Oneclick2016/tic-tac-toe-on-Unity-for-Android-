using UnityEngine;
using System.Collections;

public class ControlTheFon : MonoBehaviour {

    public FonChange fonChange;

    void Start()
    {
        fonChange = GetComponent<FonChange>();
    }

    public void ClickButtonMainMenu()
    { 
    
        fonChange.Fon(1); //включаем поле
    }

    public void ClickButtonGameMenu()
    {
        fonChange.Fon(0); //выключаем поле
    }
}
