using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonIndicator : MonoBehaviour
{
    private Renderer indicatorRenderer;

    // Start is called before the first frame update
    void Start()
    {
        indicatorRenderer = GetComponent<Renderer>();
    }

    public void Activate() {
        indicatorRenderer.material.color = Color.black;
    }

    public void DeActivate() 
    {
        indicatorRenderer.material.color = Color.white;
    }
}
