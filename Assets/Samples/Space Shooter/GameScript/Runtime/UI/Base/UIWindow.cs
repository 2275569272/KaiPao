using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ű�������UI��
/// </summary>
public class UIWindow : MonoBehaviour
{
    [HideInInspector]
    public string m_Name = ""; //ui����
    public UIType m_Type; //ui����
    public ShowType m_ShowType; //ui�򿪵�����
    public ModelBase model; //������ڵ�model�ű�
    public ViewBase view; //������ڵ�view�ű�
    public ControlBase control; //������ڵ�control�ű�
    CanvasGroup canvasGroup;

    public List<GameObject> enemyPrefabs;

    void Start()
    {
        Init();
        //StartSpawningEnemies();
    }

    /// <summary>
    /// ��ʼ��mvc�����ű� �൱��ִ����mvc�����ű���Awake
    /// </summary>
    public void Init()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
            Debug.Log("��ǰUIû�й���CanvasGroup�ű�");
        if (model != null)
            model.Init(this);
        if (view != null)
            view.Init(this);
        if (control != null)
            control.Init(this);
    }

    /// <summary>
    /// mvc�����ű���OnEnable
    /// </summary>
    public void Enable()
    {
        if (model != null)
            model.OnEnable();
        if (view != null)
            view.OnEnable();
        if (control != null)
            control.OnEnable();
    }

    /// <summary>
    /// mvc�����ű���OnDestroy
    /// </summary>
    public void Destory()
    {
        if (model != null)
            model.OnDestory();
        if (view != null)
            view.OnDestory();
        if (control != null)
            control.OnDestory();
    }

    public void Update()
    {
        if (view != null)
            view.Update();
    }

    internal void Hide()
    {
        transform.name = m_Name + "_Hide";
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
        Destory();
    }

    internal void Show()
    {
        transform.name = m_Name + "_Show";
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
        Enable();
    }

    internal void OpenAsTop()
    {
        transform.SetAsLastSibling();
        Show();
    }

    /// <summary>
    /// ������������Э��
    /// </summary>
    //public void StartSpawningEnemies()
    //{
    //    StartCoroutine(SpawnEnemyWaves());
    //}

    /// <summary>
    /// ÿ��ʮ������һ������
    /// </summary>
    //private IEnumerator SpawnEnemyWaves()
    //{
    //    while (true)
    //    {
    //        SpawnDifferentEnemies();
    //        yield return new WaitForSeconds(10f);
    //    }
    //}

    /// <summary>
    /// ��EnemyCreate�սڵ������ɲ�ͬ�ĵ���
    /// </summary>
    //private void SpawnDifferentEnemies()
    //{
    //    GameObject enemyCreateNode = GameObject.Find("EnemyCreate");
    //    if (enemyCreateNode == null)
    //    {
    //        Debug.LogError("EnemyCreate node not found in the scene.");
    //        return;
    //    }

    //    for (int i = 0; i < enemyPrefabs.Count; i++)
    //    {
    //        GameObject enemy = GameObject.Instantiate(enemyPrefabs[i], enemyCreateNode.transform);
    //       // enemy.transform.position = new Vector3(i * 2.0f, 0, 0); // ���õ��˵�λ��
    //        enemy.transform.localScale = new Vector3(50, 50, 1); // ���õ��˵Ĵ�С
    //    }
    //}
}

