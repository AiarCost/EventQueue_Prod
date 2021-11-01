using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    private bool m_isQuitting;
    private int QueueCount = 0;
    public GameObject ShootingGO;
    private bool Timer = true;


    private void OnEnable()
    {
        EventBus.StartListening("Shoot", Shoot);
    }

    void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if (m_isQuitting == false)
        {
            EventBus.StopListening("Shoot", Shoot);
        }
    }

    void Shoot()
    {
        QueueCount++;
        
    }

    private void Update()
    {
        if( QueueCount >0 && Timer)
        {
            Instantiate(ShootingGO, new Vector3(2, 2, 0), Quaternion.identity);
            QueueCount--;
            Timer = false;

            StartCoroutine(Timing());

        }
    }

    IEnumerator Timing()
    {
        yield return new WaitForSeconds(.25f);
        Timer = true;
    }
}