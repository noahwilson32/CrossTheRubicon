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

    public Text nameText;
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
        nameText.text = enemyHealth.unitName;
    }
}
