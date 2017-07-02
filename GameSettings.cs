using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour {

    string[] gridArr = new string[3] {"3x3", "4x4", "5x5" }; // массив допступных полей
    public string gridCur; // текущее поле
    DropMenu dropMenu;

	void Start () {
        dropMenu = GetComponent<DropMenu>();
    }
	
	void Update () {
        //проверка какое поле выбрано в Dropdown
        if (gridCur == "3x3")
        {
            gridCur = gridArr[0];
        }
        else if (gridCur == "4x4")
        {
            gridCur = gridArr[1];
        }
        else if (gridCur == "5x5")
        {
            gridCur = gridArr[2];
        }
    }
}
