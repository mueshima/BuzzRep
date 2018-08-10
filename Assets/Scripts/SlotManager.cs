using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour {

    public GameObject messageObj;   //メッセージオブジェクト

    public GameObject messageObj2;   //スロット回転メッセージオブジェクト
    public GameObject messageText;  //メッセージエリア

    public GameObject buttonYes;    //はいボタン
    public GameObject buttonNo;     //いいえボタン
    public GameObject buttonOk;     //Okボタン

    //アイテム定数
    public const int ITEM_EGG = 0;
    public const int ITEM_NEGI = 1;
    public const int ITEM_MIRA = 2;

    //
    public GameObject[] ItemList = new GameObject[6];

    //アイテム画像
    public Sprite[] ItemPicture = new Sprite[3];

	// Use this for initialization
	void Start () {
        buttonOk.SetActive(false);
        messageObj2.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}

    //街スロットボタン押下
    public void PushButtonMati()
    {
        messageObj.SetActive(false);
    }

    //海スロットボタン押下
    public void PushButtonUmi()
    {
        messageObj.SetActive(false);
    }

    //祭スロットボタン押下
    public void PushButtonMaturi()
    {
        messageObj.SetActive(false);
    }


    //回すボタン押下
    public void ButtonExe()
    {
        buttonYes.SetActive(true);
        buttonNo.SetActive(true);
        buttonOk.SetActive(false);

        messageText.GetComponent<Text>().text = "100"+"いいね使用します。\nよろしいですか？";
        messageObj2.SetActive(true);
    }

    //作成-はい押下
    public void PushButtonYes()
    {

        int buttonNO;
        buttonNO = 0;

        //可変にする
        ItemList[buttonNO].GetComponent<Image>().sprite = ItemPicture[ITEM_EGG];

        messageText.GetComponent<Text>().text = "アイテムをGetしました！！\n" + 
                                                "<新発見>たまご\n" +
                                                "<獲得済み>ねぎ\n";


        buttonYes.SetActive(false);
        buttonNo.SetActive(false);
        buttonOk.SetActive(true);
    }

    //作成-いいえ押下
    public void PushButtonNo()
    {
        messageObj2.SetActive(false);
    }

    //作成後-OK押下
    public void PushButtonOk()
    {
        messageObj2.SetActive(false);
    }

    //戻るボタン押下
    public void PushButtonEnd()
    {
        SceneManager.LoadScene("MenuScene");
    }

}
