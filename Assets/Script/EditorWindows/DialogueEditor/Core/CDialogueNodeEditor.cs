using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
//Investigar esta biblioteca
using System.Linq;
//Investigar esta viblioteca
using System.Reflection;
//Esto es es una clase sin metodo propio una abstracta que es definida
//usando [NameSpace]
using DNECore;
using DNE;


public class CDialogueNodeEditor : EditorWindow
{
    /*
    private List<CNode> nodes;
    private List<CConnection> connections;

    private CConnectionPoint selectedInPoint;
    private CConnectionPoint selectedOutPoint;

    
    //private List
    // Start is called before the first frame update

    private Vector2 offset;
    private Vector2 drag;



    [MenuItem("Dialog Node Editor/canvas")]
    private static void OpenWindos()
    {
        CDialogueNodeEditor window = GetWindow<CDialogueNodeEditor>();
        window.titleContent = new GUIContent("Dialog Node Editor");
    }

   private void OnDrag(Vector2 delta)
    {
        drag = Vector2.zero + delta;
        if(nodes != null)
        {
            for (int i = 0; i < nodes.Count; i ++)
            {
                nodes[i].Drag(delta);
            }
        }
        GUI.changed = true;
    }
    public void OnclickRemoveNode(Node node)
    {
        if (connections != null)
        {
            List<CConnection> connectiontoRemove = new List<CConnection>();
            for (int i = 0; i < connections.Count; i++)
            {
            if(connections[i].inPoint.node == node || connections[i].outPoint.node == node)
                {
                   con
                }
        }
    }
    
    private void AddNode(CNode node)
    {
        if(nodes == null)
        {
            nodes = new List<CNode>();
        }
        if(node.GetType() == typeof(StarNode))
    }
    
    private void DrawNodes()
    {
        if(nodes != null)
            for(int i = 0; i< nodes.Count; i++)
            {
                nodes[i].Draw();
            }
    }
    
    private void DrawConnection()
    {
        if(connections != null)
        {
            for(int i = 0; i < connections.Count; i++)
            {
                connections[i].Draw();
            }
        }
        
    }
    
    private void ProcessNodes(Event e)
    {
        if (nodes != null)
        {
            for (int i = nodes.Count - 1; i >= 0; i--)
            {
                bool guiChanged = nodes[i].ProcessEvetns(e);

                if (guiChanged)
                {
                    GUI.changed = true;
                }
            }
        }
    }

    private void DrawCanvas(float gridSpacing, float gridOpacity, Color gridColor)
    {
        int widthdivs = Mathf.CeilToInt(position.width / gridSpacing);
        int heightDivs = Mathf.CeilToInt(position.height / gridSpacing);

        Handles.BeginGUI();
        Handles.color = new Color(gridColor.r, gridColor.g, gridColor.b, gridOpacity);

        offset += drag * 0.5f;
        Vector3 newoffset = new Vector3(offset.x % gridSpacing, offset.y % gridSpacing, 0);

        for(int i = 0; i < widthdivs; i++)
        {
            Handles.DrawLine(new Vector3(gridSpacing * i, -gridSpacing, 0) + newoffset, new Vector3(gridSpacing * i, position.height,0f) + newoffset);
        }

        for( int i = 0; i < heightDivs; i++)
        {
            Handles.DrawLine(new Vector3(-gridSpacing, gridSpacing * i, 0) + newoffset, new Vector3(position.width, gridSpacing * i, 0f) + newoffset);
        }

        Handles.color = Color.white;
        Handles.EndGUI();

    }
    
    private void DrawConnectionLine(Event e)
    {

    }
    
    
    private void ProccesNode(Event e)
    {
        if(nodes != null)
        {
            for(int i = nodes.Count - 1; i >= 0; i--)
            {
                bool guiChanged = nodes[i].ProcessEvetns(e);

                if(guiChanged)
                {
                    GUI.changed = true;
                }
            }
        }
    }
    
    private void ProcessConnections(Event e)
    {
        if(connections != null)
        {
            for(int i = connections.Count - 1; i >= 0; i--)
                connections[i].
            {
            }
        }
    }
    
    
    public string SaveCanvas(string path)
    {
        try
        {
            if (nodes == null) nodes = new List<CNode>();
            if (connections == null) connections = new List<CConnection>();
            CEditorSaveObject save = 
        }
    }
    
    
    public void BuildCanvas(string path)
    {
        if (nodes == null) nodes = new List<CNode>();
        if (connections == null) connections = new List<CConnection>();
        List<BuildNode> buildNodes = new List<BuildNode>();

        List<CNode> node_index_reference = new List<CNode>();
        for(int i = 0; i < nodes.Count; i++)
        {
            if(nodes[i].GetType() == typeof(Cd))
        }
    }
    */


}
