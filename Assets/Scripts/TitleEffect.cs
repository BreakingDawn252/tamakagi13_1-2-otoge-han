using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleEffect : MonoBehaviour
{
    [SerializeField] private GameObject notePrefab;
    private float time;
    private int vecX;

    private void Update()
    {
        time -= Time.deltaTime;
        
        if(time <= 0.0f)
        {
            vecX = Random.Range(-120, 120);
            Instantiate(notePrefab, new Vector3(vecX, 80, 1), Quaternion.identity);
            time = 0.1f;
        }
    }
}