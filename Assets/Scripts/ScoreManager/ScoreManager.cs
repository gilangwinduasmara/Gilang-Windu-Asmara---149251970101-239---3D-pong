using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text gameOverText;
    public int maxScore = 4;
    public List<PlayerController> _players;
    // Start is called before the first frame update



    public void RegisterPlayer(PlayerController player){
        _players.Add(player);
    }

    public void RemovePlayer(PlayerController player){
        _players.Remove(player);
        Debug.Log(_players.Count);
        if(_players.Count == 1){
            GameOver(_players[0]);    
        }
    }

    public void GameOver(PlayerController winner){
        gameOverPanel.SetActive(true);
        gameOverText.text = winner.name + " wins!";
    }
}
