using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Best : MonoBehaviour
{

    private bool m_isQuitting;
    private bool m_IsLaunched = false;


    private void OnEnable()
    {
        EventBus.StartListening("Best", BestTeacher);
    }

    void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if (m_isQuitting == false)
        {
            EventBus.StopListening("Best", BestTeacher);
        }
    }

    void BestTeacher()
    {
        if (m_IsLaunched == false)
        {
            m_IsLaunched = true;
            Debug.Log("Recieved The best teacher event : Answer Slease!");
        }
    }
}
