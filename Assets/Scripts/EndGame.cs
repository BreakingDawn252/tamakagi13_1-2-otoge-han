using UnityEngine;

public class EndGame : MonoBehaviour
{
    void Update()
    {
        EndGames();
    }

    //Q[IΉ
    private void EndGames()
    {
        //Escͺ³κ½
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//Q[vCIΉ
#else
    Application.Quit();//Q[vCIΉ
#endif
        }

    }
}