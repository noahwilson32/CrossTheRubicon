using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateSystem {START,PLAYER,ENEMY,WON,LOST }
public class BattleSystem : MonoBehaviour
{
    public StateSystem state;

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerPlatform;
    public Transform enemyPlatform;

    private Unit playerUnit;
    private Unit enemyUnit;
    // Start is called before the first frame update
    void Start()
    {
        state = StateSystem.START;
        SetUpBattle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetUpBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerPlatform);
        playerUnit = playerGO.GetComponent<Unit>();
        GameObject enemyGO = Instantiate(enemyPrefab, enemyPlatform);
        enemyUnit = enemyGO.GetComponent<Unit>();
    }
}
