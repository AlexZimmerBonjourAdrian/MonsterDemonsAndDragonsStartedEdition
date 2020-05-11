using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Enemy" , menuName = "MonstersDemonsAndDragons/Enemy")]
public class CEnemyData : ScriptableObject
{
    public new string name;
    [TextArea(10, 10)]
    public string descripcion;
    public float Health;
    public float SpeedMovement;
    public float Damage;
    public float invulnerabilitytime;
    public float DamageMelee;
    public float DelayChangeState;
    public bool IsDistance;
  
 
    
    // Start is called before the first frame update

}
