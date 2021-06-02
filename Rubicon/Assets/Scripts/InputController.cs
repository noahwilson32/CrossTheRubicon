using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public Animator anim;

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
    }
    public void Defend()
    {
        anim.SetTrigger("Defend");
    }
}
