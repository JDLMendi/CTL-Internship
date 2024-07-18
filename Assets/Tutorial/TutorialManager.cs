using UnityEngine;
using System.Collections.Generic;

public class TutorialManager : MonoBehaviour
{
    public List<GameObject> steps;
    public int currentStepIndex = 0;

    void Start()
    {
        if (steps.Count > 0)
        {
            steps[0].SetActive(true);
        }
    }

    public void ProceedToNextStep()
    {
        if (currentStepIndex < steps.Count)
        {
            steps[currentStepIndex].SetActive(false);
            currentStepIndex++;
            if (currentStepIndex < steps.Count)
            {
                steps[currentStepIndex].SetActive(true);
            }
        }
    }
}
