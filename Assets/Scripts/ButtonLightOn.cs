using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class ButtonLightOn : MonoBehaviour
{
    [SerializeField] GameObject light;

    public void OnClickLight()
    {
        Debug.Log("���C�g�����");
        light.SetActive(true);
    }
}