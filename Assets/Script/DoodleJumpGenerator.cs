using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodleJumpGenerator : MonoBehaviour
{
    [SerializeField] GameObject _groundPrehab;
    [SerializeField] int _groundNum = 200;
    [SerializeField] float _windth = 3.0f;
    [SerializeField] float _hightMax = 0.2f;
    [SerializeField] float _hightMin = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPos = new Vector3();
        for(int i = 0; i < _groundNum; i++)
        {
            spawnPos.x = Random.Range(-_windth, _windth);
            spawnPos.y += Random.Range(_hightMin, _hightMax);
            Instantiate(_groundPrehab, spawnPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
