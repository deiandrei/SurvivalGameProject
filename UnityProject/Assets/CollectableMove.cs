using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableMove : MonoBehaviour
{
    private float m_TimeAccum;
    private Vector3 m_InitialPos;

    // Start is called before the first frame update
    void Start()
    {
        m_InitialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        m_TimeAccum += Time.deltaTime;
        transform.position = m_InitialPos + new Vector3(0, 1.75f * Mathf.Sin(m_TimeAccum), 0);
        transform.RotateAroundLocal(new Vector3(0, 1, 0), Mathf.Deg2Rad * 120 * Time.deltaTime);
    }
}
