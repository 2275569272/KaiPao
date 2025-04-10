﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniFramework.Event;
using YooAsset;

public class GameManager
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameManager();
            return _instance;
        }
    }

    private readonly EventGroup _eventGroup = new EventGroup();

    /// <summary>
    /// 协程启动器
    /// </summary>
    public MonoBehaviour Behaviour;


    private GameManager()
    {
        // 注册监听事件
        _eventGroup.AddListener<SceneEventDefine.StartingScene>(OnHandleEventMessage);
        _eventGroup.AddListener<SceneEventDefine.Scene1_1>(OnHandleEventMessage);
    }

    /// <summary>
    /// 开启一个协程
    /// </summary>
    public void StartCoroutine(IEnumerator enumerator)
    {
        Behaviour.StartCoroutine(enumerator);
    }

    /// <summary>
    /// 接收事件
    /// </summary>
    private void OnHandleEventMessage(IEventMessage message)
    {
        SceneHandle operationHandle = null;
        string uiName = null;
        if (message is SceneEventDefine.StartingScene)
        {
//<<<<<<< HEAD
            operationHandle = YooAssets.LoadSceneAsync("StartGameScene");
            uiName = "StartGamePanel";
//=======
//            operationHandle = YooAssets.LoadSceneAsync("Battle");
//            uiName = "Battle";
//>>>>>>> 8d3c84d4212065a1ece083619a3c9b21d182047e
        }
        else if (message is SceneEventDefine.Scene1_1)
        {
            operationHandle = YooAssets.LoadSceneAsync("Scene1_1");
            uiName = "LoadingPanel";
        }
        if (operationHandle == null) return;
        operationHandle.Completed += (op) =>
        {
            if (op.Status == EOperationStatus.Succeed)
            {
                //打开界面
                //    UIManager.Instance.OpenWindow(uiName);
                Debug.Log("打开界面");
            }
            else
            {
                Debug.LogError("Scene Failed to Load");
            }
        };
    }
}