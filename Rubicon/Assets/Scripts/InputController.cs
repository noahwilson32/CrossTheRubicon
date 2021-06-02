using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public Animator anim;

    public Unit enemyUnit;
    public Unit playerUnit;

    void Update()
    {

    }
    public void Kick()
    {
        anim.SetTrigger("Kick");
    }
    public void Swing()
    {
        anim.SetTrigger("Swing");
        enemyUnit.currentHealth -= playerUnit.damage;
    }
    public void Defend()
    {
        anim.SetTrigger("Defend");
    }
}
