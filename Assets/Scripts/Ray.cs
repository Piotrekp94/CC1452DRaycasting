using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Ray : MonoBehaviour
{
    [SerializeField] private GameObject ray = null;

    private GameObject[] walls;
    private void Update()
    {
        destroyChildrens();

        walls = GameObject.FindGameObjectsWithTag("Wall");
        List<LineRenderer> lineRenderers = new List<LineRenderer>();

        foreach (var wall in walls)
        {
            if (wall.GetComponent<LineRenderer>())
            {
                lineRenderers.Add(wall.GetComponent<LineRenderer>());
            }
        }
        foreach (var lineRenderer in lineRenderers)
        {
            for (int i = 0; i < lineRenderer.positionCount; i++)
            {
                GameObject newRay = Instantiate(ray, new Vector3(0,0,0), Quaternion.Euler(0.0f, 0.0f, 0.0f));
                newRay.transform.parent = transform;
                LineRenderer rayLineRenderer = newRay.GetComponent<LineRenderer>();
                rayLineRenderer.SetPosition(
                    rayLineRenderer.positionCount - 1,
                    GetComponent<LineRenderer>().GetPosition(0));
                rayLineRenderer.positionCount++;
                rayLineRenderer.SetPosition(rayLineRenderer.positionCount - 1, new Vector3(lineRenderer.GetPosition(i).x, lineRenderer.GetPosition(i).y, 0.0f));
            }
        }
    }

    private void destroyChildrens()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}