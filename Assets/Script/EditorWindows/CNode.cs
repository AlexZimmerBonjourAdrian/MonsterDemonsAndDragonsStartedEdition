using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class CNode 
{
    public Rect rect;
    public string title;

    public GUIStyle style;

    public bool isDragged;
    public bool isSelected;
    public CConnectionPoint inPoint;
    public CConnectionPoint outPoint;

    public Action<CNode> OnRemoveNode;
    public GUIStyle defaultNodesStyles;
    public GUIStyle selectedNodeStyle;
    public GUIStyle defaultNodeStyle;
   
    public CNode(Vector2 position, float width, float height, GUIStyle nodeStyle,GUIStyle selectedStyle,GUIStyle inPointStyle, GUIStyle outPointStyle, Action<CConnectionPoint> OnClickInPoint,Action<CConnectionPoint> OnClickOutPoint,Action<CNode> OnClickRemoveNode)
    {
        rect = new Rect(position.x, position.y, width, height);
        style = nodeStyle;
        inPoint = new CConnectionPoint(this, CConnectionPointType.In, inPointStyle, OnClickInPoint);
        outPoint = new CConnectionPoint(this, CConnectionPointType.Out, outPointStyle, OnClickInPoint);
        defaultNodesStyles = nodeStyle;
        selectedNodeStyle = selectedStyle;
        OnRemoveNode = OnClickRemoveNode;
    }
    public void Drag(Vector2 delta)
    {
        rect.position += delta;
    }

    public void Draw()
    {
        inPoint.Draw();
        outPoint.Draw();
        GUI.Box(rect, title, style);

    }
    public bool ProcessEvents(Event e)
    {
        

        switch (e.type)
        {
            case EventType.MouseDown:
            if(e.button == 0)
                {
                    if(rect.Contains(e.mousePosition))
                    {
                        isDragged = true;
                        GUI.changed = true;
                        isSelected = true;
                        style = selectedNodeStyle;
                    }
                    else
                    {
                        GUI.changed = true;
                        isSelected = false;
                        style = defaultNodesStyles;
                    }
                }
                if (e.button == 1 && isSelected && rect.Contains(e.mousePosition))
                {
                    ProcessContexMenu();
                    e.Use();
                }
                break;
            case EventType.MouseUp:
                isDragged = false;
                break;

            case EventType.MouseDrag:
                if(e.button == 0 && isDragged)
                {
                    Drag(e.delta);
                    e.Use();
                    return true;
                }
                break;
        }
        return false;
    }
    private void ProcessContexMenu()
    {
        GenericMenu genericMenu = new GenericMenu();
        genericMenu.AddItem(new GUIContent("Remove Node"), false, OnClickRemoveNode);
        genericMenu.ShowAsContext();
    }
    private void OnClickRemoveNode()
    {
        if(OnRemoveNode != null)
        {
            OnRemoveNode(this);
        }
    }
}
