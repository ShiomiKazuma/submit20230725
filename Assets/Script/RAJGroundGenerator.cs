using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAJGroundGenerator : MonoBehaviour
{
    [SerializeField] GameObject _groundPrehab;
    [SerializeField] float _firstX = 0;
    [SerializeField] float _firstY = 0;
    [SerializeField] int _groundCount = 100;
    [SerializeField] float _width = 5;
    [SerializeField] float _height = 5;
    [SerializeField] float _maxHeight = 10;
    [SerializeField] float _minHeight = -10;
    [SerializeField] float _groundsizeX = 2;
    [SerializeField] float _groundsizeY = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_groundPrehab,new Vector3(_firstX, _firstY, 0), Quaternion.identity);
    }

    public void GroundGenerato()
    {
        float x = _firstX;
        float y = _firstY;

        for (int i = 1; i < _groundCount; i++)
        {
            float widthX = Random.Range(_groundsizeX, _width);
            x += widthX;
            float heightY = Random.Range(_groundsizeY, _height);
            if(y + heightY >= _maxHeight)
            {
                int judge = Random.Range(0, 2);
                if(judge == 0)
                {
                    y -= heightY;
                }
            }
            else if(y - heightY <= _minHeight)
            {
                int judge = Random.Range(0, 2);
                if (judge == 0)
                {
                    y += heightY;
                }
            }
            else
            {
                int judge = Random.Range(0, 2);
                if (judge == 0)
                {
                    y += heightY;
                }
                else
                {
                    y -= heightY;
                }
            }

            Instantiate(_groundPrehab, new Vector3(x, y, 0), Quaternion.identity);
        }
    }
}
