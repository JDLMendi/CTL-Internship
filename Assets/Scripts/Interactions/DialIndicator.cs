using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialIndicator : MonoBehaviour
{
    
    public GameObject dial;

    private Renderer indicatorRenderer;
    private float dialValue = 0;

    void Start()
    {
        indicatorRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        dialValue = dial.transform.rotation.eulerAngles.y;
        float normalisedRotation = dialValue/360f;
        Color newColor = Color.Lerp(Color.white, Color.black, normalisedRotation);

        indicatorRenderer.material.color = newColor;
    }
}
