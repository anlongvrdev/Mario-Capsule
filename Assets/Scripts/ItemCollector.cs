using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] Text coinsText;
    [SerializeField] AudioSource collectionSounds;
    int coins = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = $"coins: {coins}";
            collectionSounds.Play();
        }
    }
}
