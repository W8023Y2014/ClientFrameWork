﻿//========================================================================
// Copyright(C): ***********************
//
// CLR Version : 4.0.30319.42000
// NameSpace : Assets.Script.Framework.EditorRuntimeScript.ActionEditor
// FileName : ActionEditorMain
//
// Created by : LeoLi (742412055@qq.com) at 2015/10/29 16:49:30
//
//
//========================================================================
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters;
using System.Collections;

public class ActionEditorMain : SingletonTemplateMon<ActionEditorMain>
{
    #region Property

    #endregion

    #region Field
    //readonly
    private readonly string SCENE_CAMERANAME = "SceneCamera";
    //
    private GameObject m_ObjMapInstance;
    private Camera m_SceneCamera;
    private Action m_ClearEditorWindowCallBack;
    private Action m_CloseEditorWindowCallBack;
    private Action<Vector3> m_RaycastCallBack;
    #endregion

    #region MonoBehavior
    void Awake()
    {
        _instance = this;
    }

    // Use this for initialization
    void Start()
    {
        ResourceManager.Instance.Initialize();
        LogManager.Instance.Initialize(true, true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion

    #region Public Interface
    public void SetSceneCamera(GameObject instance)
    {
        m_ObjMapInstance = instance;
        m_SceneCamera = m_ObjMapInstance.GetComponentInChildren<Camera>();
        if (m_SceneCamera == null) {
            Debuger.LogError("Scene Camera Not Found");
            return;
        }
        if (EditorCameraMovement.Instance != null && m_SceneCamera.gameObject.name == SCENE_CAMERANAME)
        {
            EditorCameraMovement.Instance.SetSceneCamera(m_SceneCamera);
        }
    }

    public void SetClearWindow(Action clear)
    {
        m_ClearEditorWindowCallBack = clear;
    }
    public void SetCloseWindow(Action closeWindow)
    {
        m_CloseEditorWindowCallBack = closeWindow;
    }
    #endregion

    #region System Function
    private void OnApplicationQuit()
    {
        if (null != m_ClearEditorWindowCallBack)
        {
            m_ClearEditorWindowCallBack();
        }
        if (null != m_CloseEditorWindowCallBack)
        {
            m_CloseEditorWindowCallBack();
        }
    }
    #endregion
}
