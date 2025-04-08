using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameView : ViewBase
{
    Button StartGameBtn;//��ʼ��Ϸ��ť

    Button ShouChongBtn;//�׳䰴ť
    Button XianFengBtn;//�ȷ汦�ذ�ť
    Button LoginBtn;//��¼����ť

    Button PostBtn; //�ʼ���ť
    Button FriendBtn; //���Ѱ�ť
    Button TaskBtn; //����ť

    Button ShangChengBtn; //�̳ǰ�ť
    Button JueSeBtn; //��ɫ��ť
    Button ZhanDouBtn; //ս����ť
    Button HeXinBtn; //���İ�ť
    Button JiDiBtn; //���ذ�ť

    public override void Init(UIWindow uiBase)
    {
        base.Init(uiBase);
        FindAllBtn();

        
        StartGameBtn.onClick.AddListener(() =>
        {
            //��ת��ս������
            SceneEventDefine.BattleScene.SendEventMessage();
            UIManager.Instance.CloseWindow("StartGamePanel");
            Debug.Log("��ת��ս������");
        });
    }

    private void FindAllBtn()
    {
        StartGameBtn = uiBase.transform.Find("Buttom/StartGame").GetComponent<Button>();
    }
}
