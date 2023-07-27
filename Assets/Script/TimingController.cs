using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimingController : MonoBehaviour
{
    //使うスライダーを設定する
    [SerializeField] Slider _slider;
    //止めたのかを判定する
    bool _isStop;
    //最大値を設定する
    [SerializeField] float _maxValue;
    //最大値、最小値の判定
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
        //バーをストップさせる処理
        if(Input.GetMouseButtonDown(0) && _isStop == false)
        {
            Debug.Log("Stop");
            _isStop = true;
            //止まった位置により処理が変更される
            if(_slider.value >= 0.4 && _slider.value <= 0.6)
            {
                Debug.Log("クリティカル");
            }
            else if(_slider.value >= 0.18 && _slider.value <= 0.69)
            {
                Debug.Log("攻撃成功");
            }
            else
            {
                Debug.Log("攻撃失敗");
            }
            Debug.Log(_slider.value);
        }
        //バーをスタートさせる処理
        else if(Input.GetMouseButtonDown(0) && _isStop == true) 
        {
            Debug.Log("Start");
            _isStop = false;
        }
        //バーの移動処理
        if(_slider.value >=  _maxValue)
        {
            _maxMinJuge = true;
        }
        if( _slider.value == 0) 
        {
            _maxMinJuge = false;
        }
        //バーの動く方向の処理
        //バーが左に動く
        if(_maxMinJuge == true && _isStop == false)
        {
            _slider.value -= 0.01f;
        }
        //バーが右に動く
        if(_maxMinJuge == false && _isStop == false)
        {
            _slider.value += 0.01f;
        }


    }
}
