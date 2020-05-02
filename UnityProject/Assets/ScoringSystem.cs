using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject ScoreText;

    private bool Collected = false;

    void OnTriggerEnter(Collider other)
    {
        if (Collected || other.name != "PlayerPrefab") return;

        ScoreText.GetComponent<CounterHolder>().Increment();
        Collected = true;
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
