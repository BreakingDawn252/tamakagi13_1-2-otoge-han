using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    //���ɗ�����
    //����x�点�ĂȂ炷�i�ꏬ�߁j
    //�����鑬�x���ȂƔ���ꏊ�Ƃ̋���
    //�E����ꏊ�ɗ������ɉ������Ăق����@�����@���x�G����ꏊ�܂ł̋���/�ꏬ�߂̒����i���j
    float speed;
    public int plus;

    //�E�P���߂̎��Ԃ́H
    //�EBPM�P�Q�O�A�S�^�S���q
    //�P���߁@�����@�Q�b

    //����ꏊ�܂ł̋����́H
    //�P�O-�i-�T�O�j���U�O

    public void Start()
    {
        speed = 100+plus;
    }

    void Update()
    {
        transform.Translate(0, -speed*Time.deltaTime, 0);
    }
}
