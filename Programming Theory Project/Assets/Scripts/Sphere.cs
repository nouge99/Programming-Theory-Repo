using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private Color _sphereColor = Color.green;
    public Color SphereColor
    {
        get { return _sphereColor; }
        set { _sphereColor = value; }
    }

    void Start()
    {
        SphereColor = _sphereColor;
        Material material = GetComponent<Renderer>().material;
        material.color = SphereColor; 
    }

    public override void DisplayText()
    {
        text.text = "Behold, the sphere of madness!";
    }

}
