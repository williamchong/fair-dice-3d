﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouseRatioX = Input.mousePosition.x * 0.2f/ Screen.width;
        float mouseRatioY = Input.mousePosition.y * 0.2f / Screen.height;

        //now create a new vector3

        var mousePos = new Vector3(mouseRatioX - 0.05f, 0f, mouseRatioY - 0.05f);

        this.transform.position = Vector3.MoveTowards(this.transform.position, mousePos, 0.08f);

    }
}
