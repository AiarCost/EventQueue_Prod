using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingGO : MonoBehaviour
{
    private SpriteRenderer Sr;

    private void Start()
    {
        Sr = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {

        if(Sr.color.a == 0)
        {
            Destroy(gameObject);
        }
    }
}
