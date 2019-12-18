using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace DNECore
{

    public abstract class CNode
    {
        /*
        public Rect rect;
        public GUIStyle style = new GUIStyle();
        public CDialogueNodeEditor editor;
        public float width;
        public float height;
        public bool IsDragged;

       
        public CNode(CDialogueNodeEditor editor,Vector2 position)
        {
            SetStyle();
            this.editor = editor;
        }
        

        public CNode(CDialogueNodeEditor editor, NodeInfo info)
        {
            SetStyle();
            this.editor = editor;
        }
        public virtual void Drag(Vector2 delta)
        {
            rect.position += delta;
       }
        public abstract void Init(Vector2 position);
        public abstract void Draw();
        public abstract bool ProcessEvetns(Event e);
        public abstract void SetStyle();
        public abstract List<CConnectionPoint> GetConnectionPoints();
        public abstract NodeInfo getInfo();
        public abstract void Rebuild(List<CConnectionPoint> cp);
        public virtual bool ProcessDefault(Event e)
        {
        switch (e.type)
            {
                case EventType.MouseDown:
                    if(e.button == 0)
                    {
                        if (rect.Contains(e.mousePosition))
                        {
                            IsDragged = true;
                        }
                    }
                    else if(e.button == 1 && rect.Contains (e.mousePosition))
                    {
                        GenericMenu genericMenu = new GenericMenu();
                        // genericMenu.AddItem(new GUIContent("Remove"),false, () => editor)
                        genericMenu.ShowAsContext();
                        e.Use();
                    }
                    break;
                case EventType.MouseUp:
                    IsDragged = false;
                    break;
                case EventType.MouseDrag:
                    if(e.button == 0 && IsDragged)
                    {
                        Drag(e.delta);
                        e.Use();
                        return true;
                    }
                    break;
            }
            return false;
        }
    
    */
    }
}

