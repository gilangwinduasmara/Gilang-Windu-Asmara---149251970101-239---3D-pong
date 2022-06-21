using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public ScoreManager scoreManager;
    public Text playerName;
    public Text playerScore;

    private int _score;
    private PlayerController _player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Init(PlayerController player, string playerName){
        this.playerName.text = playerName;
        this._player = player;
        scoreManager.RegisterPlayer(player);
    }

    public void AddScore()
    {
        _score++;
        playerScore = transform.Find("PlayerScore").GetComponent<Text>();
        playerScore.text = _score.ToString();
        if(IsReachMaxScore()){
            scoreManager.RemovePlayer(_player);
        }
    }

    public bool IsReachMaxScore(){
        return _score >= scoreManager.maxScore;
    }
}
