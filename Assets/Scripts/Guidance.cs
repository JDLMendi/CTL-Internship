using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateXR.Guides;
using UltimateXR.Manipulation;

using UnityEngine;

public class Guidance : MonoBehaviour {
    
    public GameObject target;
    public GameObject target2;
    private MonoBehaviour targetOutline;
    private MonoBehaviour target2Outline;

    private UxrGrabbableObject uxrTarget;
    private UxrGrabbableObject uxrTarget2;

    private void Start() {
        targetOutline = target.GetComponent<Outline>();
        targetOutline.enabled = false;
        uxrTarget = target.GetComponent<UxrGrabbableObject>();

        target2Outline = target2.GetComponent<Outline>();
        target2Outline.enabled = false;
        uxrTarget2 = target2.GetComponent<UxrGrabbableObject>();

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            UxrCompass.Instance.SetTarget(target.transform, UxrCompassDisplayMode.Grab);
            targetOutline.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            targetOutline.enabled = false;
            UxrCompass.Instance.SetTarget(null);
        }

        if (uxrTarget.IsBeingGrabbed) {
            targetOutline.enabled = false;
            UxrCompass.Instance.SetTarget(null);
            
            UxrCompass.Instance.SetTarget(target2.transform, UxrCompassDisplayMode.Grab);
            target2Outline.enabled = true;
        }
    }
}