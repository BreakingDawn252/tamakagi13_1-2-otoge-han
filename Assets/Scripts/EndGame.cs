using UnityEngine;

public class EndGame : MonoBehaviour
{
    void Update()
    {
        EndGames();
    }

    //�Q�[���I��
    private void EndGames()
    {
        //Esc�������ꂽ��
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
        }

    }
}