using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "New Bullet" , menuName = "MonstersDemonsAndDragons/Bullet")]
public class CBulletData : ScriptableObject
{
    // Start is called before the first frame update
    public new string name;
    [TextArea(10, 10)]
    public string descripcion;
    //public float damage;
    [Range(0f, 1000f)]
    public float speed;
    public float damage;

   
}
