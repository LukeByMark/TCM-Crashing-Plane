using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinPicking : MonoBehaviour
{
    public static int pickedCoins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            pickedCoins++;
            Debug.Log($"Total score: {pickedCoins}");
            Destroy(other.gameObject);
        }
    }
}
