using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateSystem {START,PLAYER,ENEMY,WON,LOST }
public class BattleSystem : MonoBehaviour
{
    public StateSystem state;

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    private Unit playerUnit;
    private Unit enemyUnit;

    public InputController myInput;
    // Start is called before the first frame update
    void Start()
    {
        state = StateSystem.START;
        SetUpBattle();
    }

    public void SetUpBattle()
    {
        Unit playerUnit = playerPrefab.GetComponent<Unit>();
        Unit enemyUnit = enemyPrefab.GetComponent<Unit>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
