﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CNodeBaseEditor : EditorWindow
{
    private List<CNode> nodes;

    private GUIStyle nodeStyle;
    [MenuItem("Window/Node Based Editor")]
    private static void OpenWindow()
    {
        CNodeBaseEditor window = GetWindow<CNodeBaseEditor>();
        window.titleContent = new GUIContent("Node Based Editor");
    }

    private void OnEnable()
    {
        nodeStyle = new GUIStyle();
        nodeStyle.normal.background = EditorGUIUtility.Load("builtin skins/darkskin/images/node1.png") as Texture2D;
        nodeStyle.border = new RectOffset(12, 12, 12, 12);
    }
    private void OnGUI()
    {
        DrawNodes();
        ProcessNodeEvents(Event.current);
        ProcessEvents(Event.current);
        if (GUI.changed) Repaint();
    }
    // Start is called before the first frame update
   private void DrawNodes()
    {
        if(nodes != null)
        {
            for (int i=0; i<nodes.Count; i++)
            {
                nodes[i].Draw();
            }
        }
    }
    private void ProcessEvents(Event e)
    {
        switch (e.type)
        {
            case EventType.MouseDown:
                if(e.button== 1)
                {
                    ProcessContextMenu(e.mousePosition);
                }
                break;
        }

    }
    private void ProcessContextMenu(Vector2 mousePosition)
    {
        GenericMenu genericMenu = new GenericMenu();
        genericMenu.AddItem(new GUIContent("Add node"), false, () => OnClickNode(mousePosition));
    }
    private void OnClickNode(Vector3 mousePosition)
    {
        if(nodes== null)
        {
            nodes = new List<CNode>();
        }
        nodes.Add(new CNode(mousePosition, 200, 50, nodeStyle));
    }
    private void ProcessNodeEvents(Event e)
    {
        if(nodes != null)
        {
            for(int i = nodes.Count - 1; i >= 0; i--)
            {
                bool guiChanged = nodes[i].ProcessEvents(e);
                if(guiChanged)
                {
                    GUI.changed = true;
                }
            }
        }
    }
}