using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{

    private bool m_isQuitting;
    private bool m_IsHidden = false;


    private void OnEnable()
    {
        EventBus.StartListening("Hide", Hiding);
    }

    void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if (m_isQuitting == false)
        {
            EventBus.StopListening("Hide", Hiding);
        }
    }

    void Hiding()
    {
        if (m_IsHidden == false)
        {
            m_IsHidden = true;
            gameObject.SetActive(false);
        }
    }
}
