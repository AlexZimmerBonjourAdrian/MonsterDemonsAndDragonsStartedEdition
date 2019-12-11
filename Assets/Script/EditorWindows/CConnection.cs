using System;
using UnityEditor;
using UnityEngine;

public class CConnection : MonoBehaviour
{
    public CConnectionPoint inPoint;
    public CConnectionPoint OutPoint;
    public Action<CConnection> OnClickRemoveConnection;
    
    public  CConnection(CConnectionPoint inPoint, CConnectionPoint OutPoint, Action<CConnection> OnClickRemoveConnection)
    {
        this.inPoint = inPoint;
        this.OutPoint = OutPoint;
        this.OnClickRemoveConnection = OnClickRemoveConnection;
    }

    public void Draw()
    {
        Handles.DrawBezier(inPoint.rect.center, OutPoint.rect.center, inPoint.rect.center + Vector2.left * 50f, OutPoint.rect.center - Vector2.left * 50f,
            Color.white, null, 2f);

        if(Handles.Button((inPoint.rect.center + OutPoint.rect.center)*0.5f, Quaternion.identity, 4, 8,Handles.RectangleHandleCap))
        {
            if(OnClickRemoveConnection != null)
            {
                OnClickRemoveConnection(this);
            }
        }
    }
  
}
