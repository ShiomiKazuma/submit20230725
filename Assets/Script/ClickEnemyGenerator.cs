using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEnemyGenerator : MonoBehaviour, IPause
{
    //エネミープレハブを設定
    [SerializeField] ClickEnemy _enemyPrefab;
    //タイマー
    float _timer;
    //生成間隔の設定
    [SerializeField] float _interval = 1.0f;
    //エネミーの生成上限
    [SerializeField] int _enemyCount = 5;
    int _enemyCounter = 0;

    private void Start()
    {
        _timer = _interval;
    }
    private void FixedUpdate()
    {
        _timer += Time.deltaTime;
        if (_timer > _interval && _enemyCounter < _enemyCount)
        {
            _timer = 0;
            var e = Instantiate(_enemyPrefab, this.transform.position, _enemyPrefab.transform.rotation);
            e.Init(this);
            CountEnmey(1);
        }
    }

    public void CountEnmey(int count)
    {
        _enemyCounter += count;
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
}
