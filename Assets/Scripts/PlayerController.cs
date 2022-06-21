using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ScoreController scoreController;

    // Start is called before the first frame update
    void Start()
    {
        scoreController.Init(this, gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
