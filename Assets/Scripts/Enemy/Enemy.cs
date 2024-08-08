using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    Player player;

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


}
