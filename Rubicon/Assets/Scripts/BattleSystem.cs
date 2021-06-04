using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum StateSystem {START,PLAYER,ENEMY,WON,LOST }
public class BattleSystem : MonoBehaviour
{
    public StateSystem state;

    public Unit playerUnit;
    public Unit enemyUnit;

    public InputController myInput;

    public static bool isEnemyAttacking;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        state = StateSystem.START;
        isEnemyAttacking = false;
    }

    public void PlayerTurn()
    {
        isEnemyAttacking = false;
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach(GameObject button in buttons)
        {
            button.GetComponent<Button>().interactable = true;
        }
        if (InputController.isPressed)
        {
            isEnemyAttacking = true;
            anim.SetTrigger("isDamaged");
        }
    }
    IEnumerator EnemyTurn()
    {
        isEnemyAttacking = true;
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach(GameObject button in buttons)
        {
            button.GetComponent<Button>().interactable = false;
        }
        isEnemyAttacking = false;
        yield return new WaitForSeconds(1f);
        anim.SetTrigger("isAttacking");
        playerUnit.currentHealth -= enemyUnit.damage;

        
    }
    // Update is called once per frame
    void Update()
    {
        if (isEnemyAttacking)
        {
            InputController.isPressed = false;
            StartCoroutine(EnemyTurn());
        }
        else
        {
            PlayerTurn();
        }
    }
}
