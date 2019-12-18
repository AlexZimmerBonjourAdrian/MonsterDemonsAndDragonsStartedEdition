using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using DNECore;

namespace DNECore
{
    /*
    public class StartNode : CNode
    {
        
        public CConnectionPoint startPoint;

        public StartNode(CDialogueNodeEditor editor, Vector2 position) : base(editor, position)
        {
            Init(position);
        }
        public StartNode(CDialogueNodeEditor editor, NodeInfo info) : base(editor,info)
        {
            Init(new Vector2(info.rect.x, info.rect.y));
        }

        public override void Init(Vector2 position)
        {
           // throw new NotImplementedException("No esta inicializado");
            width = 200;
            height = 100;
            rect = new Rect(position.x, position.y, width, height);
            startPoint = new CConnectionPoint(this, ConnectionPointType.Out, editor.)
            
        }
        
        public override void Draw()
        {
            GUI.Box(rect, "", style);
            GUI.Label(rect, "start", style);
        }
        public override void SetStyle()
        {
            style.normal.background = AssetDatabase.LoadAssetAtPath("Assets/Sprites/Editors/Textures/greenTex.png", typeof(Texture2D)) as Texture2D;
            style.normal.textColor = Color.white;
            style.fontSize = 32;
            style.alignment = TextAnchor.MiddleCenter;
        }

        public override bool ProcessEvetns(Event e)
        {
            ProcessDefault(e);
            startPoint.ProcessEvents(e);
            return false;
        }
         
       
        public StartNode Clone()
        {
            return (StartNode)MemberwiseClone();
        }

        public override NodeInfo getInfo()
        {
            return new NodeInfo(GetType().FullName, rect);

        }
        
        public override void Rebuild(List<CConnectionPoint> cp)
        {
            startPoint = cp[0];
            startPoint.Rebuild(this,ConnectionPointType.Out,editor.O)
        }
       
    }
    */
    
}
