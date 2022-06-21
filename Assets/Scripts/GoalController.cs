using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public GameObject paddle;

    public BallManager ballManager;

    public PlayerController player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool isAlive = !player.scoreController.IsReachMaxScore();
        GetComponent<Collider>().isTrigger = isAlive;
        if (isAlive)
        {
            GetComponent<Renderer>().material.color = Color.red;
            Vector3 scale = transform.localScale;
            scale.y = Mathf.Lerp(scale.y, .5f, Time.deltaTime);
            transform.localScale = scale;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
            // scale the goal to the size of the paddle
            // initscale
            Vector3 scale = transform.localScale;
            scale.y = Mathf.Lerp(scale.y, 2f, Time.deltaTime);
            transform.localScale = scale;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BallController>() != null && paddle.activeSelf)
        {
            ballManager.RemoveBall(other.gameObject.GetComponent<BallController>());
            player.scoreController.AddScore();
        }
    }
}
