using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (gameObject.name == "icon eraser")
        {
            paintGM.toolType = "eraser";
        }
        if (gameObject.name == "icon pencil")
        {
            paintGM.toolType = "pencil";
        }
        if (gameObject.name == "sizeUp")
        {
            paintGM.currentScale += .05f;
        }
        //Debug.Log("eraser selected");
    }
}
