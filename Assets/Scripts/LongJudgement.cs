using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LongJudgement : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] GameManager gameManager = default;
    [SerializeField] KeyCode keyCode;
    [SerializeField] Text noteJudge = default;

    void Update()
    {
        if (Input.GetKey(keyCode))
        {
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
            if(hit2D)
            {
                if(hit2D.collider.CompareTag("Long"))
                {
                    Destroy(hit2D.collider.gameObject);
                    Debug.Log("perfect");
                    gameManager.AddScore(100);
                    noteJudge.text = "perfect";
                    gameManager.AddComboPerfect(1);
                    gameManager.AddCombo(1);
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
