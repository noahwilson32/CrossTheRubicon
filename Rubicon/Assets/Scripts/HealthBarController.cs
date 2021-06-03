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
    // Start is called before the first frame update
    void Start()
    {
        playerSlider.maxValue = playerHealth.maxHealth;
        enemySlider.maxValue = enemyHealth.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        playerSlider.value = playerHealth.currentHealth;
        enemySlider.value = enemyHealth.currentHealth;
        enemyNameText.text = enemyHealth.unitName;
        playerNameText.text = playerHealth.unitName;
    }
}
