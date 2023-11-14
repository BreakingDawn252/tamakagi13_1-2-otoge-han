using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] float radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
        if (hit2D)
        {
            float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y);
            if(distance < 1000)
            {
                Destroy(hit2D.collider.gameObject);
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
