using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnpoint = default;
    [SerializeField] private GameObject notePrefab = default;
    //Noteを生成する
    //Prefab:Instantiate

    public void SpawnNote()
    {
        GameObject randomPoint = spawnpoint[Random.Range(0, spawnpoint.Length)];
        //Instantiate(生成したいもの,場所,角度）;
        Instantiate(notePrefab, randomPoint.transform.position, Quaternion.identity);
        Debug.Log("ノーツが出たよ");
    }
}
 
