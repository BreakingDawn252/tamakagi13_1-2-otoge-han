using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    //�X�^�[�g�{�^��������������s����
    public void OnStartGame()
    {
        SceneManager.LoadScene("SelectScene");
    }
}