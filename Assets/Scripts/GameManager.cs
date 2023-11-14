using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    //UIの反映
    //・カウントダウンのテキスト
    [SerializeField] Text countDownText = default;
    //・ゲーム終了時のリザルト
    [SerializeField] GameObject resultPanel = default;
    //リトライボタン：シーンの再読み込み

    //ジャッジを非表示にする
    [SerializeField] Text noteJudge = default;

    //・ゲーム中のスコア表示
    [SerializeField] Text scoreText = default;
    [SerializeField] Text scoretext = default;

    //コンボのカウント
    [SerializeField] Text comboText = default;
    [SerializeField] Text comboTextPerfect = default;
    [SerializeField] Text comboTextGreat = default;
    [SerializeField] Text comboTextBad = default;
    [SerializeField] Text comboTextMiss = default;
    //・タイトルへ


    //タイムラインを再生したい
    [SerializeField] PlayableDirector playableDirector;

    int score;
    public float combo;
    float comboperfect;
    float combogreat;
    float combobad;
    float combomiss;

    private void Start()
    {
        StartCoroutine(GameMain());
        noteJudge.text = "";
    }

    IEnumerator GameMain()
    {
        countDownText.text = "3";
        yield return new WaitForSeconds(1);
        countDownText.text = "2";
        yield return new WaitForSeconds(1);
        countDownText.text = "1";
        yield return new WaitForSeconds(1);
        countDownText.text = "GO!";
        yield return new WaitForSeconds(0.5f);
        countDownText.text = "";
        playableDirector.Play();
    }

    public void AddScore(int point)
    {
        score += point;
        scoreText.text = score.ToString();
        scoretext.text = score.ToString();
    }

    public void AddComboPerfect(float point)
    {
        comboperfect += point;
        comboTextPerfect.text = comboperfect.ToString();
    }

    public void AddComboGreat(float point)
    {
        combogreat += point;
        comboTextGreat.text = combogreat.ToString();
    }

    public void AddComboBad(float point)
    {
        combobad += point;
        comboTextBad.text = combobad.ToString();
    }

    public void AddComboMiss(float point)
    {
        combomiss += point;
        comboTextMiss.text = combomiss.ToString();
    }

    public void AddCombo(float point)
    {
        combo += point;
        comboText.text = combo.ToString();
        Debug.Log("コンボついか");
    }

    public void ResetCombo()
    {
        combo = 0;
    }

    public void OnEndEvent()
    {
        Debug.Log("ゲーム終了：結果表示");
        resultPanel.SetActive(true);
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnGoHome()
    {
        SceneManager.LoadScene("OpeningScene");
    }
}
