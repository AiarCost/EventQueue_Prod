using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            EventBus.TriggerEvent("Shoot");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            EventBus.TriggerEvent("Launch");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            EventBus.TriggerEvent("Talk");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            EventBus.TriggerEvent("Hide");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            EventBus.TriggerEvent("Best");
        }
    }
}