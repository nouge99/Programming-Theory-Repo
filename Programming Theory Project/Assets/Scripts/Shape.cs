using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour, IClickable
{
    [SerializeField] protected TextMeshProUGUI text;

    public void OnClick()
    {
        DisplayText();
    }

    public abstract void DisplayText();

}
