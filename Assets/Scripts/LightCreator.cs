using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCreator : MonoBehaviour
{
    [SerializeField] private GameObject lightSource = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) //Or use GetKeyDown with key defined with mouse button
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(lightSource, mousePosition, Quaternion.Euler(0.0f, 0.0f, 0.0f));
        }
    }
}
