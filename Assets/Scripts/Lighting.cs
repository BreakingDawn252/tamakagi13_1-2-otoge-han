using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class Lighting : MonoBehaviour
{
    [SerializeField] GameObject light;
    [SerializeField] KeyCode keyCode = default;

    void Update()
    {
        if(Input.GetKeyDown(keyCode))
        {
            Debug.Log("ライトつけるよ");
            light.SetActive(true);
        }

        if(Input.GetKeyUp(keyCode))
        {
            Debug.Log("ライト消すよ");
            light.SetActive(false);
        }
    }
}