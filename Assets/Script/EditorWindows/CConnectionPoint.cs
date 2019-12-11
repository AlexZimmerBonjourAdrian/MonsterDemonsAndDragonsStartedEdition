
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum CConnectionPointType {In, Out}

public class CConnectionPoint 
{
    public Rect rect;
    public CConnectionPointType type;
    public CNode node;
    public GUIStyle style;

    public Action<CConnectionPoint> OnClickConnectionPoint;

    public CConnectionPoint(CNode node, CConnectionPointType type,GUIStyle style, Action<CConnectionPoint>OnClickConnectionPoint)
    {
        this.node = node;
        this.type = type;
        this.style = style;
        this.OnClickConnectionPoint = OnClickConnectionPoint;
        rect = new Rect(0, 0, 10f, 20f);

    }

    public void Draw()
    {
        rect.y = node.rect.y + (node.rect.height * 0.5f) - rect.height * 0.5f;
        switch(type)
        {
            case CConnectionPointType.In:
                rect.x = node.rect.x - rect.width + 8f;
                break;

            case CConnectionPointType.Out:
                rect.x = node.rect.x + node.rect.width - 8f;
                break;
        }
        if (GUI.Button(rect, "", style))
        {
            if(OnClickConnectionPoint != null)
            {
                OnClickConnectionPoint(this);
            }
        }

    }

}
