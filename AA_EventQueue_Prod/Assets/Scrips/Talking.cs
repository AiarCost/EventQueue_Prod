using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talking : MonoBehaviour
{

    private bool m_isQuitting;
    private int QueueCounter = 0;
    private bool Timer1 = true;
    private bool Timer2 = true;
    public GameObject TalkingGO;



    private void OnEnable()
    {
        EventBus.StartListening("Talk", Talk);
    }

    void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if (m_isQuitting == false)
        {
            EventBus.StopListening("Talk", Talk);
        }
    }

    void Talk()
    {
        QueueCounter++;
    }

    private void Update()
    {
        if(QueueCounter >0 && Timer1)
        {
            Instantiate(TalkingGO, new Vector3(-3, 1.5f, 0), Quaternion.identity);
            Timer1 = false;
            QueueCounter--;
            StartCoroutine(TalkingOne());
        }

        else if(QueueCounter > 0 && Timer2)
        {
            Instantiate(TalkingGO, new Vector3(-1, 1.5f, 0), Quaternion.Euler(0,180,0));
            Timer2 = false;
            QueueCounter--;
            StartCoroutine(TalkingTwo());
        }
    }

    IEnumerator TalkingOne()
    {
        yield return new WaitForSeconds(3f);
        Timer1 = true;
    }

    IEnumerator TalkingTwo()
    {
        yield return new WaitForSeconds(3f);
        Timer2 = true;
    }
}
