using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    //下に落ちる
    //音を遅らせてならす（一小節）
    //落ちる速度を曲と判定場所との距離
    //・判定場所に来た時に音が鳴ってほしい　＝＞　速度；判定場所までの距離/一小節の長さ（ｓ）
    float speed;
    public int plus;

    //・１小節の時間は？
    //・BPM１２０、４／４拍子
    //１小節　＝＞　２秒

    //判定場所までの距離は？
    //１０-（-５０）＝６０

    public void Start()
    {
        speed = 100+plus;
    }

    void Update()
    {
        transform.Translate(0, -speed*Time.deltaTime, 0);
    }
}
