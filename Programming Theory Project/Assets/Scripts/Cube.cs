using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private Color _cubeColor = Color.red;
    public Color CubeColor
    {
        get { return _cubeColor; }
        set { _cubeColor = value; }
    }

    void Start()
    {
        CubeColor = _cubeColor;
        Material material = GetComponent<Renderer>().material;
        material.color = CubeColor; 
    }

    public override void DisplayText()
    {
        text.text = "Observe, the cube of clarity.";
    }
}
