using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public GameObject Card;
    public GameObject Worker;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void BuyWorker()
    {
        Card.SetActive(false);
        //Worker.SetActive(true);
    }
}
