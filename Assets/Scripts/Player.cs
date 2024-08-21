using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Velocidade ao girar player")]
    public float turnSpeed;

    [Header ("Valores UI")]
    public int health;
    public int score;

    [Header("Text Mesh Pro UI")]
    public TMP_Text healthDisplay;

    public TMP_Text scoreDisplay;

    public void Update()
    {
        transform.Rotate(Vector3.forward * turnSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
    }

    // Método de como o jogador vai tomar dano
    public void TakeDamage()
    {
        health--;
        healthDisplay.text = "Health: " + health;

        if(health <= 0)
        {
            SceneManager.LoadScene("Game");
        }
    }

    // Método de pontuação
    public void AddScore()
    {
        score++;
        scoreDisplay.text = "Score: " + score;
    }
}
