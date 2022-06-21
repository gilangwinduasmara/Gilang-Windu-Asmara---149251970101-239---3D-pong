using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public BallController template;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public BallController Spawn(){
        BallController ball = Instantiate(template, template.transform.position, Quaternion.identity);
        // ball.transform.parent = transform;
        ball.gameObject.SetActive(true);
        return ball;
    }
}
