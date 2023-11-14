using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchJudgement : MonoBehaviour
{
    //ノーツが落ちてきたときに、キーボードを押したら判定したい
    //判定の結果も表示したい
    [SerializeField] Text noteJudge = default;
    //・キー入力
    //・近くにノーツがあるか:rayをとばして当たったら近い
    //・どれくらいの近さなのか＝＞評価
    [SerializeField] float radius;
    //AddScoreを実行する
    [SerializeField] GameManager gameManager = default;
    //Addcomboを実行する
    public float combo;
    [SerializeField] Text comboText;
    [SerializeField] Text comboperfect;
    [SerializeField] Text combogreat;
    [SerializeField] Text combobad;
    [SerializeField] Text combomiss;

    [SerializeField] GameObject effectPrefab;

    public void OnClick()
    {

        RaycastHit2D[] hits2D = Physics2D.CircleCastAll(transform.position, radius, Vector3.zero);
        //一番下を消す

        if (hits2D.Length == 0)
        {
            return;
        }
        //一度y座標が小さいもの順で並べ替える（ソートする）
        List<RaycastHit2D> raycastHit2Ds = hits2D.ToList();
        raycastHit2Ds.Sort((a, b) => (int)(a.transform.position.y - b.transform.position.y));
        //０番目の要素を消す
        RaycastHit2D hit2D = raycastHit2Ds[0];


        if (hit2D)
        {
            float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y);
            if (distance < 8)
            {
                Debug.Log("perfect");
                gameManager.AddScore(1000);
                noteJudge.text = "perfect";
                gameManager.AddComboPerfect(1);
                gameManager.AddCombo(1);
                SpawnEffect(hit2D.transform.position);
            }
            else if (distance < 16)
            {
                Debug.Log("great");
                gameManager.AddScore(100);
                noteJudge.text = "great";
                gameManager.AddComboGreat(1);
                gameManager.AddCombo(1);
                SpawnEffect(hit2D.transform.position);
            }
            else
            {
                Debug.Log("bad");
                gameManager.AddScore(10);
                noteJudge.text = "bad";
                gameManager.AddComboBad(1);
                gameManager.ResetCombo();
                comboText.text = "0";
                SpawnEffect(hit2D.transform.position);
            }
            //ぶつかったものを破壊する
            Destroy(hit2D.collider.gameObject);
        }

        RaycastHit2D hit2Ds = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
        if (hit2Ds)
        {
            float distance = hit2Ds.transform.position.y - transform.position.y;
            if (distance < -24)
            {
                noteJudge.text = "miss";
                Debug.Log("miss");
                gameManager.AddComboMiss(1);
                gameManager.ResetCombo();
                comboText.text = "0";
            }
        }
    }

    void SpawnEffect(Vector3 position)
    {
        GameObject effect = Instantiate(effectPrefab, position, Quaternion.identity);
        Destroy(effect, 0.3f);
    }


    //可視化ツール
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
