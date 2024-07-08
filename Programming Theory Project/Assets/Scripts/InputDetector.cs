using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class InputDetector : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    Scene currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentScene.buildIndex == 0) {
                SceneManager.LoadScene(1);
            }
            DetectClickableObject();
        }

        if (Input.anyKeyDown && currentScene.buildIndex == 0)
        {
            SceneManager.LoadScene(1);
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
