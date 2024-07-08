using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private Color _cylinderColor = Color.blue;
    public Color CylinderColor
    {
        get { return _cylinderColor; }
        set { _cylinderColor = value; }
    }

    void Start()
    {
        CylinderColor = _cylinderColor;
        Material material = GetComponent<Renderer>().material;
        material.color = CylinderColor; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void DisplayText()
    {
        text.text = "Witness, the cylinder of despair...";
    }
}
