using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEnemy : MonoBehaviour
{
    //�����������I�u�W�F�N�g������
    [SerializeField] GameObject _enemy;
    //�ړ��X�s�[�h�����肷��
    [SerializeField] float _speed = 5.0f;
    //�I�u�W�F�N�g�̖ړI�n��ۑ�
    Vector3 _movePosition;
    // Start is called before the first frame update
    void Start()
    {
        _movePosition = RandomMove();
    }

    // Update is called once per frame
    void Update()
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
}
