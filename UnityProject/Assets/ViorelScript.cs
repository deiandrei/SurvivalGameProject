using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViorelScript : MonoBehaviour
{
    float distance = 60.0f;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position += new Vector3(distance, 0, 0) * Time.deltaTime;
    }
}
