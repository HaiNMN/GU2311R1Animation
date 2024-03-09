using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private PlayerManager _playerManager;
    void Start()
    {
        _playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
        AudioManager.Instance.BackGroundMusic();
    }

    // Update is called once per frame
    
    void Update()
    {
       if( _playerManager != null&& _playerManager.UpdateHealth()<0)
        {
            FinishGame();
        } 
    }
    void FinishGame()
    {
        SceneManager.LoadScene("GameOver");
    }
}
