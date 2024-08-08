using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpannerManager : MonoBehaviour
{
    // referencia ao inimigo
    public GameObject enemy;

    // lista para receber os pontos de spawn
    public Transform[] spawnPoints;

    [Header("Spawner Attributes")]
    public float timeBetweenSpawns;
    public float nextSpawnTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            // Seleciona um ponto de spawn aleatório e pega a posição
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(enemy, spawnPoint.position, Quaternion.identity);

            // Atualiza o próximo tempo de spawn
            nextSpawnTime = Time.time + timeBetweenSpawns;
        }
    }
}