using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDestroy : MonoBehaviour
{
    //クリック時にログを出す
    public void OnClickObj()
    {
        Debug.Log("クリックされた");
        ClickGameManager clickGameManager = GameObject.Find("GameManager").GetComponent<ClickGameManager>();
        clickGameManager.AddScore();
        Destroy(gameObject);
    }
}
