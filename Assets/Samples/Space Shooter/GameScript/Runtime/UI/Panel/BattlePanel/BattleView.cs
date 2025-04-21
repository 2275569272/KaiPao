using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YooAsset;
using YooAsset.Editor;

public class BattleView : ViewBase
{
    GameObject EnemyCreate;
    GameObject PlayerCreate;
    GameObject Player;
    private AssetHandle play;
    List<GameObject> EnemyList = new List<GameObject>();
    public override void Init(UIWindow uiBase)
    {
        base.Init(uiBase);
        Debug.Log("BattleView Init");
        EnemyCreate = uiBase.transform.Find("EnemyCreate").gameObject;
        PlayerCreate = uiBase.transform.Find("PlayerCreate").gameObject;
        play = YooAssets.LoadAssetSync<GameObject>("Player");
        Debug.Log(play);
    }

    public void CreateEnemy()
    {
        
    }

    public void CreatePlayer()
    {
        
    }
}

