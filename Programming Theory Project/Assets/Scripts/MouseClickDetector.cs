using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MouseClickDetector : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DetectClickableObject();
        }        
    }

    void DetectClickableObject()
    {
        var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                IClickable clickAction = hit.collider.GetComponent<IClickable>();
                if (clickAction != null)
                {
                    clickAction.OnClick();
                }
            }
        }
    }
}
