using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(Time.deltaTime * 0, -80*Time.deltaTime, 0);
        if (transform.position.y <=-100 )
        {
            Destroy(gameObject);
        }
    }
}
