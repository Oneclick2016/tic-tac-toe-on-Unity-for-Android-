using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainScripts : MonoBehaviour {

    public GameSettings gameSettings; //нужно для получение параметров создаваемой игры

    void Start () {
        FonChange fonChange = GetComponent<FonChange>(); //нужно для управления фоном
        fonChange.Fon(0); //меняем фон на фон без поля

        gameSettings = GetComponent<GameSettings>(); //нужно для получение параметров создаваемой игры
    }
	
	void Update () {

    }

    public void CreateGame()
    {
        //выполняем проверки на размер поля
        if (gameSettings.gridCur == "3x3")
        {
            
        }
        if (gameSettings.gridCur == "4x4")
        {
            
        }
        if (gameSettings.gridCur == "5x5")
        {
            
        }
    }
}
