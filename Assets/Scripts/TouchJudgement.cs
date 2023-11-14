using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchJudgement : MonoBehaviour
{
    //�m�[�c�������Ă����Ƃ��ɁA�L�[�{�[�h���������画�肵����
    //����̌��ʂ��\��������
    [SerializeField] Text noteJudge = default;
    //�E�L�[����
    //�E�߂��Ƀm�[�c�����邩:ray���Ƃ΂��ē���������߂�
    //�E�ǂꂭ�炢�̋߂��Ȃ̂������]��
    [SerializeField] float radius;
    //AddScore�����s����
    [SerializeField] GameManager gameManager = default;
    //Addcombo�����s����
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
        //��ԉ�������

        if (hits2D.Length == 0)
        {
            return;
        }
        //��xy���W�����������̏��ŕ��בւ���i�\�[�g����j
        List<RaycastHit2D> raycastHit2Ds = hits2D.ToList();
        raycastHit2Ds.Sort((a, b) => (int)(a.transform.position.y - b.transform.position.y));
        //�O�Ԗڂ̗v�f������
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
            //�Ԃ��������̂�j�󂷂�
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


    //�����c�[��
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
