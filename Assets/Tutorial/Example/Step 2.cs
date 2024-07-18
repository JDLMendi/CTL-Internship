using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateXR.Guides;
using UltimateXR.Manipulation;

public class Step2 : MonoBehaviour
{

    [SerializeField] private GameObject target;
    [SerializeField] private TutorialManager tutorialManager;
    
    private EnableOutline _enableOutline;
    private UxrGrabbableObject uxrTarget;

    private void Update() {
        if (UxrGrabManager.Instance.IsBeingGrabbed(uxrTarget)) {
            tutorialManager.ProceedToNextStep();
        }
    }

    private void OnEnable() {
        Transform childTransform = target.transform.Find("Enable Outline");
        _enableOutline = childTransform.GetComponent<EnableOutline>();
        uxrTarget = target.GetComponent<UxrGrabbableObject>();

        _enableOutline.enabled = true;
        UxrCompass.Instance.SetTarget(target.transform, UxrCompassDisplayMode.Grab);
    }

    private void OnDisable() {
        _enableOutline.enabled = false;
        UxrCompass.Instance.SetTarget(null);
    }
}
