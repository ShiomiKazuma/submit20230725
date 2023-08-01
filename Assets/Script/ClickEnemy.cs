using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEnemy : MonoBehaviour, IPause
{
    //�����������I�u�W�F�N�g������
    [SerializeField] GameObject _enemy;
    //�ړ��X�s�[�h�����肷��
    [SerializeField] float _speed = 5.0f;
    //�I�u�W�F�N�g�̖ړI�n��ۑ�
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
        //�ړI�n�ɓ�������ƖړI�n���Đݒ肷��
        if(_movePosition == _enemy.transform.position)
        {
            _movePosition = RandomMove();
        }
        //�ړI�n�ɒ��i����
        _enemy.transform.position = Vector3.MoveTowards(_enemy.transform.position, _movePosition, _speed * Time.deltaTime);
    }
    //�ړI�n�������_����������
    Vector3 RandomMove()
    {
        Vector3 randomPos = new Vector3(Random.Range(-7, 7), Random.Range(-4, 4), 0);
        return randomPos;
    }

    public void OnClickObj()
    {
        Debug.Log("�N���b�N���ꂽ");
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
