using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEnemy : MonoBehaviour, IPause
{
    //動かしたいオブジェクトを入れる
    [SerializeField] GameObject _enemy;
    //移動スピードを決定する
    [SerializeField] float _speed = 5.0f;
    //オブジェクトの目的地を保存
    Vector3 _movePosition;
    ClickEnemyGenerator _owner = null;
    public void Init(ClickEnemyGenerator owner)
    {
        _owner = owner;
        _movePosition = RandomMove();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //目的地に到着すると目的地を再設定する
        if(_movePosition == _enemy.transform.position)
        {
            _movePosition = RandomMove();
        }
        //目的地に直進する
        _enemy.transform.position = Vector3.MoveTowards(_enemy.transform.position, _movePosition, _speed * Time.deltaTime);
    }
    //目的地をランダム生成する
    Vector3 RandomMove()
    {
        Vector3 randomPos = new Vector3(Random.Range(-7, 7), Random.Range(-4, 4), 0);
        return randomPos;
    }

    public void OnClickObj()
    {
        Debug.Log("クリックされた");
        ClickGameManager clickGameManager = GameObject.Find("GameManager").GetComponent<ClickGameManager>();
        clickGameManager.AddScore();
        _owner.CountEnmey(-1);
        Destroy(gameObject);
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
}
