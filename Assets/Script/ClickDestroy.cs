using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDestroy : MonoBehaviour
{
    //�N���b�N���Ƀ��O���o��
    public void OnClickObj()
    {
        Debug.Log("�N���b�N���ꂽ");
        ClickGameManager clickGameManager = GameObject.Find("GameManager").GetComponent<ClickGameManager>();
        clickGameManager.AddScore();
        Destroy(gameObject);
    }
}
