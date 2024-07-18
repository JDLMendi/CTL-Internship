using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateXR.Guides;
public class GrabMe : MonoBehaviour
{
    [SerializeField] private GameObject myObject;
    [SerializeField] private EnableOutline enableOutline;
    private void OnEnable() {
        UxrCompass.Instance.SetTarget(myObject.transform, UxrCompassDisplayMode.Grab);
        enableOutline.enabled = true;
    }

    private void OnDisable() {
        UxrCompass.Instance.SetTarget(null);
        enableOutline.enabled = false;
    }
}
