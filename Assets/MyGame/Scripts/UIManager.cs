using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI  _textHealth;
    [SerializeField] TextMeshProUGUI _textCoin;
    private PlayerManager _playerManager;
    void Start()
    {
        _playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
        StartCoroutine("UpdateUI");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator UpdateUI()
    {
        while (true)
        {
            if (_playerManager != null)
            {
                _textHealth.text = ("Health :" + _playerManager.UpdateHealth().ToString());
                _textCoin.text = ("Coin :" + _playerManager.UpdateCoin().ToString());
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
}
