using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CounterHolder : MonoBehaviour
{

    public int Score;

    void Start()
    {
        Score = 0;
    }

    public void Increment()
    {
        Score = Score + 1;
        GetComponent<Text>().text = "ITEMS FOUND: " + Score + "/10";
        if(Score == 10)
        {
            GetComponent<Text>().color = Color.green;

            SceneManager.LoadScene("MainMenu");
        }
    }
}
