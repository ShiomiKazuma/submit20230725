using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEnemyGenerator : MonoBehaviour, IPause
{
    //�G�l�~�[�v���n�u��ݒ�
    [SerializeField] ClickEnemy _enemyPrefab;
    //�^�C�}�[
    float _timer;
    //�����Ԋu�̐ݒ�
    [SerializeField] float _interval = 1.0f;
    //�G�l�~�[�̐������
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
