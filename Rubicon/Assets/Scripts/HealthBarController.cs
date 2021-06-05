using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Unit playerHealth;
    public Unit enemyHealth;

    public Slider playerSlider;
    public Slider enemySlider;

    public Text enemyNameText;
    public Text playerNameText;

    public Text playerDamageText;
    public GameObject playerDamageTextGO;

    public Transform spawnPlayerDamage;
    // Start is called before the first frame update
    void Start()
    {
        playerSlider.maxValue = playerHealth.maxHealth;
        enemySlider.maxValue = enemyHealth.maxHealth;
        playerHealth.changedHealth = playerHealth.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        playerSlider.value = playerHealth.currentHealth;
        enemySlider.value = enemyHealth.currentHealth;

        enemyNameText.text = enemyHealth.unitName;
        playerNameText.text = playerHealth.unitName;
        if(playerHealth.currentHealth < playerHealth.changedHealth)
        {
            GameObject pdt = Instantiate(playerDamageTextGO,spawnPlayerDamage);
            Destroy(pdt, 1f);
            StartCoroutine(ChangedHealth());
        }
    }
    IEnumerator ChangedHealth()
    {
        yield return new WaitForSeconds(.0001f);
        playerHealth.changedHealth = playerHealth.currentHealth;
    }

}
