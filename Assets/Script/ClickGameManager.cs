using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ClickGameManager : MonoBehaviour
{
    //スコア
    int _score;
    //スコアを表示するテキスト
    [SerializeField] Text _scoreText;
    //ゲームクリア時のテキスト
    [SerializeField] GameObject _clearText;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        _scoreText.text = "Score:" + _score;
        _clearText.SetActive(false);
    }

    private void Update()
    {
        if( _score >= 5 )
        {
            GameClear();
        }
    }

    public void AddScore()
    {
        _score++;
        _scoreText.text = "Score:" + _score;
    }

    void GameClear()
    {
        //エネミーとエネミージェネレーターを止める
        var objects = FindObjectsOfType<GameObject>();

        foreach ( var obj in objects)
        {
            IPause i = obj.GetComponent<IPause>();
            i?.Pause();
        }
        //クリア時の文字を表示する
        _clearText.SetActive (true);
    }
}
