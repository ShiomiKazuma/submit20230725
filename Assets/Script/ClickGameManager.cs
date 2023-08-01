using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ClickGameManager : MonoBehaviour
{
    //�X�R�A
    int _score;
    //�X�R�A��\������e�L�X�g
    [SerializeField] Text _scoreText;
    //�Q�[���N���A���̃e�L�X�g
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
        //�G�l�~�[�ƃG�l�~�[�W�F�l���[�^�[���~�߂�
        var objects = FindObjectsOfType<GameObject>();

        foreach ( var obj in objects)
        {
            IPause i = obj.GetComponent<IPause>();
            i?.Pause();
        }
        //�N���A���̕�����\������
        _clearText.SetActive (true);
    }
}
