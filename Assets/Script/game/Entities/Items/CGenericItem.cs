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
}
