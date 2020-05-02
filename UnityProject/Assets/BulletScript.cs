using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float Lifetime;
    public bool Template = true;

    private Vector3 Direction;

    private float m_ActualLifetime;

    // Start is called before the first frame update
    void Start()
    {
        m_ActualLifetime = Lifetime;
        Direction = new Vector3(0, 0, 0);
    }

    public void SetDirection(Vector3 dir)
    {
        Debug.Log(dir);
        Direction = dir;
    }

    // Update is called once per frame
    void Update()
    {
        if (Template) return;

        transform.position = transform.position + Direction * Time.deltaTime * 100;

        m_ActualLifetime -= Time.deltaTime;
        if (m_ActualLifetime < 0.0f) Destroy(gameObject);

    }
}
