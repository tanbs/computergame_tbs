using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    GameController gc;
    int gemValue = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Debug.Log("Enter Collider Gem");
            gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
            if (gameObject.CompareTag("blueGems"))
            {
                gc.changeScore(gemValue + 20);
            }
            if (gameObject.CompareTag("greenGems"))
            {
                gc.changeScore(gemValue + 10);
            }
            else
            if (gameObject.CompareTag("Gems"))
            {
                gc.changeScore(gemValue);
            }
            
        }
    }


}
