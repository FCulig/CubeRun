using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public bool isTriggered = false;

    void OnTriggerEnter()
    {
        isTriggered = true;
    }
}
