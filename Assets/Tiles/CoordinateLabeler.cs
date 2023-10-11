using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{

    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();
    void Awake()
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinate(); // to be able to see the coordinates when playing mode
    }

    void Update()
    {
        if(!Application.isPlaying)
        {
            DisplayCoordinate();
            UpdateObjectName();
        }
    }

    void DisplayCoordinate()
    {
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z); // zed since we are using x and z 2D plane position

        label.text = coordinates.x + "," + coordinates.y; // this is where the output is done.
    }

    void UpdateObjectName() // this is for the Prefabs update its name when it is change coordinates and change also in the interface.
    {
        transform.parent.name = coordinates.ToString();
    }

}

// /  UnityEditor.EditorSnapSettings.move.x this to divide the 10 in the coordinates so it will become 1. Eg. (10,0) to (1,0)
