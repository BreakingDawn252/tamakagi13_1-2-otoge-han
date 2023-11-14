using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchLong : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] GameManager gameManager = default;
    [SerializeField] Text noteJudge = default;

    private bool isTouchDown = false;

    void Update()
    {
        if(isTouchDown)
        {
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
            if (hit2D)
            {
                if (hit2D.collider.CompareTag("Long"))
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
    public void OnTouchDown()
    {
        isTouchDown = true;
    }

    // Event Triggerの「Pointer Up」に割り当てるメソッド
    public void OnTouchUp()
    {
        isTouchDown = false;
    }
}
