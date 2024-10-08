using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    Player player;

    bool inactive = false; 

    private void Start()
    {
        // find a object with player script
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        MoveTowards();
    }

    public void MoveTowards()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(inactive == false)
        {
            if (other.tag == "Hole")
            {
                player.AddScore();
                Destroy(gameObject);
            }

            if (other.tag == "Player" || other.tag == "Enemy")
            {
                player.TakeDamage();
                speed = 0;
                transform.parent = player.transform;
            }
        }
        inactive = true;
    }

}
