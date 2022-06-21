using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public List<BallSpawner> ballSpawners;
    public int maxAmountOfBalls;

    public float spawnRate;

    private List<BallController> _balls;
    // Start is called before the first frame update
    void Start()
    {
        _balls = new List<BallController>();
        InvokeRepeating("SpawnBall", spawnRate, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnBall()
    {
        if (_balls.Count >= maxAmountOfBalls)
        {
            return;
        }
        BallSpawner spawner = ballSpawners[Random.Range(0, ballSpawners.Count)];
        BallController ball = spawner.Spawn();
        _balls.Add(ball);
    }

    public void RemoveBall(BallController ball)
    {
        _balls.Remove(ball);
        Destroy(ball.gameObject);
    }
}
