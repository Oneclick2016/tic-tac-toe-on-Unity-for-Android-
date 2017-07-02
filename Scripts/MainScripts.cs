using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainScripts : MonoBehaviour {

    public DropMenu dropMenu; //нужно для получение параметров dropMenu
    public Sprite[] fonArr = new Sprite[4];
    public Image fonImage;

    void Start () {
        Fon(0); //меняем фон на фон без поля
        dropMenu = GetComponent<DropMenu>(); 
    }

    public void CreateGame()
    {
        //выполняем проверки на размер поля
        if (dropMenu.gridCur == "3x3")
        {
            
        }
        if (dropMenu.gridCur == "4x4")
        {
            
        }
        if (dropMenu.gridCur == "5x5")
        {
            
        }
    }

    public void Fon(byte numberFon)
    {
        fonImage.sprite = fonArr[numberFon]; //меняем фон 0 - с полем 1- без поля
    }

    public void ClickButtonMainMenu()
    {

        Fon(1); //включаем поле
    }

    public void ClickButtonGameMenu()
    {
        Fon(0); //выключаем поле
    }
}
