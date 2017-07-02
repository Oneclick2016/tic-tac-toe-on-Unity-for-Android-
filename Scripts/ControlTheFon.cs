using UnityEngine;
using System.Collections;

public class ControlTheFon : MonoBehaviour {

    public void ClickButtonMainMenu()
    {
        FonChange fonChange = GetComponent<FonChange>();
        fonChange.Fon(1); //включаем поле
    }

    public void ClickButtonGameMenu()
    {
        FonChange fonChange = GetComponent<FonChange>();
        fonChange.Fon(0); //выключаем поле
    }
}
