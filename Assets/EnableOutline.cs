using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOutline : MonoBehaviour
{
    public GameObject outlineTarget;
    private MonoBehaviour outlineScript;

    private void OnEnable() {
        outlineScript = outlineTarget.GetComponent<Outline>();
        outlineScript.enabled = true;
    }

    private void OnDisable() {
        outlineScript.enabled = false;
    }
}
