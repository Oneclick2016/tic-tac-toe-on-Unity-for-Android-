using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainScripts : MonoBehaviour {

    void Start () {
        FonChange fonChange = GetComponent<FonChange>(); //нужно для управления фоном
        fonChange.Fon(0); //меняем фон на фон без поля
    }
	
	//void Update () {
	
	//}
}
