using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCreator : MonoBehaviour
{
    [SerializeField] private GameObject light;
    private Vector2 mousePosition;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) //Or use GetKeyDown with key defined with mouse button
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(light, mousePosition, Quaternion.Euler(0.0f, 0.0f, 0.0f));
        }
    }
}
