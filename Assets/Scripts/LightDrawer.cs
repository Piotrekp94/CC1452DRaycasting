using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDrawer : MonoBehaviour
{ 
    private void Start()
    {
        LineRenderer line = GetComponent<LineRenderer>();
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePositionOffset = mousePosition;
        mousePositionOffset.x += 0.05f;
        mousePositionOffset.y += 0.05f;
        mousePosition.x -= 0.05f;
        mousePosition.y -= 0.05f;
        line.SetPosition(0, mousePosition);
        line.SetPosition(1, mousePositionOffset);
    }


}

