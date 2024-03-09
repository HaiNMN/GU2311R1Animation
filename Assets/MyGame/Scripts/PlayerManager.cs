using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    [SerializeField]private float Maxhealth=100;
   
    [SerializeField] private float currentHealth;
    [SerializeField] private int _coin = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = Maxhealth;
    }

    // Update is called once per frame
    public float UpdateHealth()
    {
        return currentHealth;
    }
    public int UpdateCoin()
    {
        return _coin;
    }
    private void OnCollisionEnter(Collision collision)
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Damager"))
        {
            currentHealth -= 80;
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Coin")
        {
            _coin += 1;
            Destroy(other.gameObject);
        }
    }
}
