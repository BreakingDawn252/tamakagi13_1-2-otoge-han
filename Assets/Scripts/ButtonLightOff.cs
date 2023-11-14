using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class ButtonLightOff : MonoBehaviour
{
    [SerializeField] GameObject light;

    public void OnLeftLight()
    {
        Debug.Log("ÉâÉCÉgè¡Ç∑ÇÊ");
        light.SetActive(false);
    }
}