using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public Animator anim;

    public Unit enemyUnit;
    public Unit playerUnit;

    public static bool isPressed = false;
    public static bool isDefending;

    void Update()
    {
        if(BattleSystem.isEnemyAttacking == false && isDefending == false)
        {
            enemyUnit.damage = enemyUnit.maxDamage;
        }
    }
    public void Kick()
    {
        anim.SetTrigger("Kick");
        enemyUnit.currentHealth -= playerUnit.damage / 2;
        isPressed = true;
        isDefending = false;
    }
    public void Swing()
    {
        anim.SetTrigger("Swing");
        enemyUnit.currentHealth -= playerUnit.damage;
        isPressed = true;
        isDefending = false;
    }
    public void Defend()
    {
        isDefending = true;
        anim.SetTrigger("Defend");
        isPressed = true;
        if (isDefending)
        {
            enemyUnit.damage = enemyUnit.damage / 2;
        }
        if (!isDefending)
        {
            enemyUnit.damage = enemyUnit.maxDamage;
        }
        
    }
    public void Pray()
    {
        anim.SetTrigger("Pray");
        playerUnit.currentHealth += 2;
        isPressed = true;
        isDefending = false;
    }
}
