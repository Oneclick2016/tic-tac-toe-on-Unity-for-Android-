using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DropMenu : MonoBehaviour {

    public GameObject[] buttonArr = new GameObject[4]; //создаём массив с 4 объектов (кнопок)
    public Text[] textArr = new Text[4]; //создаём массив с 4 объектов (кнопок)
    GameSettings gameSettings; // создаём переменную gameSettings для общения с классом

    void Start () {
        gameSettings = GetComponent<GameSettings>();
        textArr[0].text = textArr[1].text;
        for (int i = 1; i <= 3; i++)
        {
            buttonArr[i].SetActive(false); //выключаем 3 нижних кнопки
        }
	}

    public void TapMenu()
    {
        for (int i = 1; i <= 3; i++)
        {
            buttonArr[i].SetActive(true); // при нажатии на верхнюю включаем
        }
    }

    public void Grid(string grid)
    {
        gameSettings.gridCur = grid;
        switch (grid)
        {
            case "3x3":
                textArr[0].text = textArr[1].text;
                for (int i = 1; i <= 3; i++)
                {
                    buttonArr[i].SetActive(false); //выключаем 3 нижних кнопки
                }
                break;
            case "4x4":
                textArr[0].text = textArr[2].text;
                for (int i = 1; i <= 3; i++)
                {
                    buttonArr[i].SetActive(false); //выключаем 3 нижних кнопки
                }
                break;
            case "5x5":
                textArr[0].text = textArr[3].text;
                for (int i = 1; i <= 3; i++)
                {
                    buttonArr[i].SetActive(false); //выключаем 3 нижних кнопки
                }
                break;
        }
    }
}
