using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public Animator anim;

    public Unit enemyUnit;
    public Unit playerUnit;

    public static bool isEnemyTurn = false;

    void Update()
    {

    }
    public void Kick()
    {
        anim.SetTrigger("Kick");
        enemyUnit.currentHealth -= playerUnit.damage / 2;
        isEnemyTurn = true;
    }
    public void Swing()
    {
        anim.SetTrigger("Swing");
        enemyUnit.currentHealth -= playerUnit.damage;
        isEnemyTurn = true;
    }
    public void Defend()
    {
        anim.SetTrigger("Defend");
        isEnemyTurn = true;
    }
}
