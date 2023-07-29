using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickGameManager : MonoBehaviour
{
    //�X�R�A
    int _score;
    //�X�R�A��\������e�L�X�g
    [SerializeField] Text _scoreText;

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        _scoreText.text = "Score:" + _score;
    }

    public void AddScore()
    {
        _score++;
        _scoreText.text = "Score:" + _score;
    }
}
