using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class BuzzUpManager : MonoBehaviour {

    public GameObject messageObj;   //メッセージオブジェクト
    public GameObject messageText;  //メッセージエリア
    public GameObject buttonYes;    //はいボタン
    public GameObject buttonNo;     //いいえボタン
    public GameObject buttonOk;     //Okボタン

    [SerializeField]

    private GameObject btnPref;  //ボタンプレハブ

    //ボタン表示数
    const int BUTTON_COUNT = 10;

    // Use this for initialization
    void Start () {
        buttonOk.SetActive(false);
        messageObj.SetActive(false);

        //Content取得(ボタンを並べる場所)
        RectTransform content = GameObject.Find("CanvasGame/PanelWalls/Scroll View/Viewport/Content").GetComponent<RectTransform>();

        //Contentの高さ決定

        //(ボタンの高さ+ボタン同士の間隔)*ボタン数

        float btnSpace = content.GetComponent<VerticalLayoutGroup>().spacing;

        float btnHeight = btnPref.GetComponent<LayoutElement>().preferredHeight;

        content.sizeDelta = new Vector2(0, (btnHeight + btnSpace) * BUTTON_COUNT);

        for (int i = 0; i < BUTTON_COUNT; i++)
        {

            int no = i;
            DateTime dt = DateTime.Now;

            //ボタン生成
            GameObject btn = (GameObject)Instantiate(btnPref);

            //ボタンをContentの子に設定
            btn.transform.SetParent(content, false);

            //ボタンのテキスト変更
            btn.transform.GetComponentInChildren<Text>().text = (no + 1).ToString() + ":ラーメン名" + "\n" + dt.ToString("yyyy/MM/dd HH:mm:ss");

            //ボタンのクリックイベント登録
            btn.transform.GetComponent<Button>().onClick.AddListener(() => OnClick(no));

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick(int no)
    {

        Debug.Log(no);

    }

    //投稿ボタン押下
    public void PushButtonUp()
    {
        messageObj.SetActive(true);
    }

    //投稿-はい押下
    public void PushButtonYes()
    {
        
        //可変にする
        messageText.GetComponent<Text>().text = "1000" + "いいねを獲得しました！！";

        buttonYes.SetActive(false);
        buttonNo.SetActive(false);
        buttonOk.SetActive(true);
    }

    //投稿-いいえ押下
    public void PushButtonNo()
    {
        messageObj.SetActive(false);
    }

    //投稿後-OK押下
    public void PushButtonOk()
    {
        //らーめんリスト更新

        //メニュー画面へ遷移する
        SceneManager.LoadScene("MenuScene");
    }

    //戻るボタン押下
    public void PushButtonEnd()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
