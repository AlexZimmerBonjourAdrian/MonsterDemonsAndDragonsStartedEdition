using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CGenericItem : MonoBehaviour
{
    [SerializeField]
    protected CItemData item;
    [SerializeField]
    protected string nameText;
    [SerializeField]
    protected string descriptionText;
    [SerializeField]
    protected float healthRecover;
    [SerializeField]
    protected float delayRegen;
    [SerializeField]
    protected float regenerateTime;
    [SerializeField]
    protected int invulnerabilitytime;
    [SerializeField]
    protected int damageMultiply;

    protected virtual void Start()
    {
        nameText = item.name;
        descriptionText = item.description;

        healthRecover = item.healthRecover;
        delayRegen = item.delayRegen;
        regenerateTime = item.regenerateTime;
        invulnerabilitytime = item.invulnerabilitytime;
        damageMultiply = item.damageMultiply;

    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject != gameObject)
        {
            Debug.Log("Ignorame");
        }
        else if (collision.gameObject.tag == "Player")
        {
            //Funcion ejecucion de particululas o effectos.
            Debug.Log("Se Dstrullo La Balla");
            Destroy(this);
        }

    }
}
