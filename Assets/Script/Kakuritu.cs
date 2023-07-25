using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kakuritu : MonoBehaviour
{
    [SerializeField] int _sucess = 70;
    //private void Start()
    //{
        
    //}
    public void Tairyoku()
    {
        int randam = Random.Range(0, 101);

        if(randam <= _sucess)
        {
            Debug.Log("¬Œ÷");
        }
        else
        {
            Debug.Log("Ž¸”s");
        }
    }
}
