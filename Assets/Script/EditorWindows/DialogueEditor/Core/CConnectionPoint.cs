using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
namespace DNECore
{
    public enum ConnectPointType { In,Out}
    public class CConnectionPoint
    {
        public Rect rect;
        public Node node;
        public ConnectionPointType type;
        public GUIStyle style = new GUIStyle();

        public Action<CConnectionPoint> OnclickConnectionPoint;
       public bool isClicked = false;

        //public CConnectionPoint(CNode node, CConnectionPointType type, )

        // Update is called once per frame
        public CConnectionPoint()
        {
            //SetStyle();
            rect = new Rect(0, 0, 10f, 10f);

        }
        public void ProcessEvents(Event e)
        {
            if(isClicked)
            {
                if(OnclickConnectionPoint != null)
                {
                    OnclickConnectionPoint(this);
                }
            }
        }

        public void Draw(float y)
        {
            rect.y = y;

            switch(type)
            {
                case ConnectionPointType.In:
                    rect.x = node.rect.x - rect.width + 0f;
                    break;
                case ConnectionPointType.Out:
                    rect.x = node.rect.x + node.rect.width - 0f;
                    break;
            }
            isClicked = GUI.Button(rect, "", style);
        }
        public void Draw()
        {
            Draw(node.rect.y + (node.rect.height * 0.5f) - (rect.height * 0.5F));

        }
        public void SetStyle()
        {
            style.normal.background = AssetDatabase.LoadAssetAtPath("Assets/Sprites/Editors/Textures/grayTex.png", typeof(Texture2D)) as Texture2D;
            style.active.background = AssetDatabase.LoadAssetAtPath("Assets/Sprites/Editors/Textures/grayDarkTex.png", typeof(Texture2D)) as Texture2D;
        }

        public void Rebuild(Node node, ConnectionPointType type, Action<CConnectionPoint> OnClickConnectionPoint)
        {
            this.node = node;
            this.type = type;
            this.OnclickConnectionPoint = OnClickConnectionPoint;
        }
    }

} 