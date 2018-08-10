using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //食材獲得ボタン押下
    public void PushButtonShokuzai()
    {
        SceneManager.LoadScene("SlotScene");
    }

    //ラーメン造りボタン押下
    public void PushButtonMakeRamen()
    {
        SceneManager.LoadScene("MakeRamenScene");
    }

    //Buzzれぽに投稿ボタン押下
    public void PushButtonBuzzUp()
    {
        SceneManager.LoadScene("BuzzUpScene");
    }

    //保存ボタン押下
    public void PushButtonSave()
    {
        //Save
    }

    //終了ボタン押下
    public void PushSButtonEnd()
    {
        Application.Quit();
    }

    //トッピングボタン押下
    public void PushButtonItem()
    {
        SceneManager.LoadScene("ItemListToppingScene");
    }

    //ラーメン一覧ボタン押下
    public void PushButtonRamen()
    {
        SceneManager.LoadScene("RamenListScene");
    }
}
