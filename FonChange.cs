using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FonChange : MonoBehaviour {

    public Sprite[] fonArr = new Sprite[2];
    public Image fonImage;

	public void Fon (byte numberFon) {
        fonImage.sprite = fonArr[numberFon];
    }
	
}
