using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GlobalScope globalScope;

    // Start is called before the first frame update
    void Start()
    {
        globalScope = GameObject.Find("GlobalScope").GetComponent<GlobalScope>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Character")
        {
            globalScope.coinCount++;
            gameObject.SetActive(false);
        }
    }


}