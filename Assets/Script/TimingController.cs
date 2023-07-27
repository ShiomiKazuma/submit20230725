using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimingController : MonoBehaviour
{
    //�g���X���C�_�[��ݒ肷��
    [SerializeField] Slider _slider;
    //�~�߂��̂��𔻒肷��
    bool _isStop;
    //�ő�l��ݒ肷��
    [SerializeField] float _maxValue;
    //�ő�l�A�ŏ��l�̔���
    bool _maxMinJuge;
    // Start is called before the first frame update
    void Start()
    {
        _slider.value = 0.0f;
        _isStop = false;
        _maxMinJuge = false;
    }

    // Update is called once per frame
    void Update()
    {
        //�o�[���X�g�b�v�����鏈��
        if(Input.GetMouseButtonDown(0) && _isStop == false)
        {
            Debug.Log("Stop");
            _isStop = true;
            //�~�܂����ʒu�ɂ�菈�����ύX�����
            if(_slider.value >= 0.4 && _slider.value <= 0.6)
            {
                Debug.Log("�N���e�B�J��");
            }
            else if(_slider.value >= 0.18 && _slider.value <= 0.69)
            {
                Debug.Log("�U������");
            }
            else
            {
                Debug.Log("�U�����s");
            }
            Debug.Log(_slider.value);
        }
        //�o�[���X�^�[�g�����鏈��
        else if(Input.GetMouseButtonDown(0) && _isStop == true) 
        {
            Debug.Log("Start");
            _isStop = false;
        }
        //�o�[�̈ړ�����
        if(_slider.value >=  _maxValue)
        {
            _maxMinJuge = true;
        }
        if( _slider.value == 0) 
        {
            _maxMinJuge = false;
        }
        //�o�[�̓��������̏���
        //�o�[�����ɓ���
        if(_maxMinJuge == true && _isStop == false)
        {
            _slider.value -= 0.01f;
        }
        //�o�[���E�ɓ���
        if(_maxMinJuge == false && _isStop == false)
        {
            _slider.value += 0.01f;
        }


    }
}
