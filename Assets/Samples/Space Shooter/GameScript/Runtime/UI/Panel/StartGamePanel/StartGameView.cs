using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartGameView : ViewBase
{
    Button _startBtn;
    public override void Init(UIWindow uiBase)
    {
        base.Init(uiBase);
        Debug.Log("123");
        _startBtn = uiBase.transform.GetChild(3).Find("StartGame").GetComponent<Button>();
        _startBtn.onClick.AddListener(() =>
        {

            //跳转到第一关 Scene1_1
            SceneEventDefine.Battle.SendEventMessage();
            UIManager.Instance.CloseWindow("StartGamePanel");
        });
    }
}
