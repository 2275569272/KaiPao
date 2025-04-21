using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameView : ViewBase
{
    Button StartGameBtn;//开始游戏按钮

    Button ShouChongBtn;//首充按钮
    Button XianFengBtn;//先锋宝藏按钮
    Button LoginBtn;//登录好礼按钮

    Button PostBtn; //邮件按钮
    Button FriendBtn; //好友按钮
    Button TaskBtn; //任务按钮

    Button ShangChengBtn; //商城按钮
    Button JueSeBtn; //角色按钮
    Button ZhanDouBtn; //战斗按钮
    Button HeXinBtn; //核心按钮
    Button JiDiBtn; //基地按钮

    public override void Init(UIWindow uiBase)
    {
        base.Init(uiBase);
        FindAllBtn();

        
        StartGameBtn.onClick.AddListener(() =>
        {
            //跳转到战斗场景
            SceneEventDefine.BattleScene.SendEventMessage();
            UIManager.Instance.CloseWindow("StartGamePanel");
            Debug.Log("跳转到战斗场景");
        });
    }

    private void FindAllBtn()
    {
        StartGameBtn = uiBase.transform.Find("Buttom/StartGame").GetComponent<Button>();
    }
}
