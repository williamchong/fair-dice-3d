using System.Collections;
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

        float mouseRatioX = Input.mousePosition.x * 25/ Screen.width;
        float mouseRatioY = Input.mousePosition.y * 25/ Screen.height;

        //now create a new vector3

        var mousePos = new Vector3(mouseRatioX - 0.5f, 0f, mouseRatioY - 0.5f);

        this.transform.position = mousePos;

    }
}
