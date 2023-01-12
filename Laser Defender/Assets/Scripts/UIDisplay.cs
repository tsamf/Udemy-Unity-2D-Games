using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] Slider healthSlider;
    [SerializeField] Health playerHealth;
    
    [Header("Score")]
    [SerializeField] TextMeshProUGUI score;
    ScoreKeeper scoreKeeper;

    private void Awake() {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void Start()
    {
        healthSlider.maxValue = playerHealth.getCurrentHealth();
    }

    private void Update() {
        healthSlider.value = playerHealth.getCurrentHealth();
        score.text = scoreKeeper.getScore().ToString("000000000");
    }
}
