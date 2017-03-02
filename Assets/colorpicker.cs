using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorpicker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        paintGM.currentColor = GetComponent<SpriteRenderer>().color;//смена цвета
        Debug.Log(paintGM.currentColor);
        paintGM.currentOrder += 1;//добавляет слои
    }
}
