using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyGeneric : MonoBehaviour, ICollision
{
    // Start is called before the first frame update
    protected float life;
    protected float Damage;

    // protected float 
    public void OnCollision()
    {
        List<CGenericBullet> var = CBulletManager.Inst.GetList();  
        
    }

    public virtual void setLife(float life)
    {
        this.life = life;
    }

    public virtual float getLife()
    {
        return this.life;
    }

    public virtual void setDamage(float damage)
    {
        this.Damage = damage;
    }
    public virtual float getDamage()
    {
        return this.Damage;
    }
    public void Update()
    {
        CheckLife();
    }
    private void CheckLife()
    {
        if (getLife() >= 100f)
        {
            Debug.Log("La vida es normal");
        }
        if (getLife() <= 60f && getLife() > 30)
        {
            Debug.Log("Esta medio tocado");
        }
        else if (getLife() <= 30)
        {
            Debug.Log("La vida es muy baja");
        }
        else
        {
            Destroy(gameObject);
        }


    }
}
