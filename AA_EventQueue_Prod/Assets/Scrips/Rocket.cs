using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour
{

    private bool m_isQuitting;
    private int QueueCounter = 0;
    public GameObject LaunchGO;
    private bool Timer = true;



    private void OnEnable()
    {
        EventBus.StartListening("Launch", Launch);
    }

    void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if(m_isQuitting == false)
        {
            EventBus.StopListening("Launch", Launch);
        }
    }

    void Launch()
    {
        QueueCounter++;
    }

    private void Update()
    {
        if(QueueCounter > 0 && Timer)
        {
            
            Instantiate(LaunchGO, new Vector3(-2, 1.5f, 0), Quaternion.identity);
            QueueCounter--;
            Timer = false;

            StartCoroutine(Timing());
        }

    }

    IEnumerator Timing()
    {
        yield return new WaitForSeconds(1f);
        Timer = true;
    }

}
