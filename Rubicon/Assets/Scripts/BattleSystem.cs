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
    // Start is called before the first frame update
    void Start()
    {
        state = StateSystem.START;
    }

    public void PlayerTurn()
    {
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach(GameObject button in buttons)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void EnemyTurn()
    {
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach(GameObject button in buttons)
        {
            button.GetComponent<Button>().interactable = false;
        }
        playerUnit.currentHealth -= enemyUnit.damage;
        InputController.isEnemyTurn = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (InputController.isEnemyTurn)
        {
            EnemyTurn();
        }
        else
        {
            PlayerTurn();
        }
    }
}
