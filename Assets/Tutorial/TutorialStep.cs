using UnityEngine;

public class TutorialStep : MonoBehaviour
{
    public string instructionText;
    public GameObject[] objectsToActivate;
    public GameObject[] objectsToDeactivate;

    public void Activate()
    {
        // UIManager.Instance.ShowText(instructionText);
        foreach (var obj in objectsToActivate)
        {
            obj.SetActive(true);
        }
        foreach (var obj in objectsToDeactivate)
        {
            obj.SetActive(false);
        }
    }

    public void Deactivate()
    {
        foreach (var obj in objectsToActivate)
        {
            obj.SetActive(false);
        }
        foreach (var obj in objectsToDeactivate)
        {
            obj.SetActive(true);
        }
    }
}
