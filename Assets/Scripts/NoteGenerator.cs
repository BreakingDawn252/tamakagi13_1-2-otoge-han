using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnpoint = default;
    [SerializeField] private GameObject notePrefab = default;
    //Note�𐶐�����
    //Prefab:Instantiate

    public void SpawnNote()
    {
        GameObject randomPoint = spawnpoint[Random.Range(0, spawnpoint.Length)];
        //Instantiate(��������������,�ꏊ,�p�x�j;
        Instantiate(notePrefab, randomPoint.transform.position, Quaternion.identity);
        Debug.Log("�m�[�c���o����");
    }
}
 
