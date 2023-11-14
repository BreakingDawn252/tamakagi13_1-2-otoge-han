using UnityEngine;

public class EndGame : MonoBehaviour
{
    void Update()
    {
        EndGames();
    }

    //ゲーム終了
    private void EndGames()
    {
        //Escが押された時
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
        }

    }
}