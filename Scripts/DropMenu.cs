using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DropMenu : MonoBehaviour {

    public GameObject[] buttonArr = new GameObject[4]; //создаём массив с 4 объектов (кнопок)
    public Text[] textArr = new Text[4]; //создаём массив с 4 объектов (текст)
    public string gridCur; // переменная к оторой текущая сетка

    void Start () {
        textArr[0].text = textArr[1].text; // присваиваем тексту верхней (главной) кнопке значение второй (3x3)
        for (int i = 1; i <= 3; i++)
        {
            buttonArr[i].SetActive(false); //выключаем 3 нижних кнопки
        }
	}

    public void TapMenu()
    {
        for (int i = 1; i <= 3; i++)
        {
            buttonArr[i].SetActive(true); // при нажатии на верхнюю включаем 3 нижних кнопки
        }
    }

    public void Grid(string grid)
    {
        gridCur = grid; //присваеваем gridCur выбранную решётку в насстрпойках
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
