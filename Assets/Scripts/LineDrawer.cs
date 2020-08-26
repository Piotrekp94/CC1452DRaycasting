using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LineDrawer : MonoBehaviour
{
    private LineRenderer line;
    private Vector2 mousePosition;

    [SerializeField] private bool simplifyLine = false;
    [SerializeField] private float simplifyTolerance = 0.02f;
    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(line.positionCount == 1)
            {
                line.SetPosition(line.positionCount - 1, mousePosition);
            }
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, mousePosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (simplifyLine)
            {
                line.Simplify(simplifyTolerance);
            }
            enabled = false;
        }

        line.tag = "Wall";
    }
}