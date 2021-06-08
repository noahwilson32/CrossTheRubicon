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

    public Text infoDisplayText;

    // Start is called before the first frame update
    void Start()
    {
        playerSlider.maxValue = playerHealth.maxHealth;
        enemySlider.maxValue = enemyHealth.maxHealth;
        playerHealth.changedHealth = playerHealth.maxHealth;

        infoDisplayText.text = "The imfamous lion, a worthy \n opponent for a feirce gladiator \n strong but unfavored by the gods";
    }

    // Update is called once per frame
    void Update()
    {
        playerSlider.value = playerHealth.currentHealth;
        enemySlider.value = enemyHealth.currentHealth;

        enemyNameText.text = enemyHealth.unitName;
        playerNameText.text = playerHealth.unitName;

        if (InputController.isPressed)
        {
            infoDisplayText.text = playerHealth.unitName + " Deals " + playerHealth.damage.ToString() + " Damage To " + enemyHealth.unitName;
        }
        StartCoroutine(DisPlayInfo());
    }
    IEnumerator DisPlayInfo()
    {
        yield return new WaitForSeconds(1.5f);
        if (BattleSystem.isEnemyAttacking)
        {
            infoDisplayText.text = enemyHealth.unitName + " Deals " + enemyHealth.damage.ToString() + " Damage To " + playerHealth.unitName;
        }
    }

}
