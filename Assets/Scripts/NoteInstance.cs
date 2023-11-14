using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{
    float i;
    [SerializeField] NoteGenerator noteGenerator = default;
    public void NoteEvent()
    {
        if (i == 0)
        {
            Debug.Log("‰¹‚ª–Â‚é‚æ");
            noteGenerator.SpawnNote();
            i += 1;
        }
        else
        {
            i -= 1;
        }
    }
}
