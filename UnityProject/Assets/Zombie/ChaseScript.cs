using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseScript : MonoBehaviour
{
    public Transform Player;

    private Animator Anim;
    private NavMeshAgent NMA;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        NMA = GetComponent<NavMeshAgent>();
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Bullet") {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Player.position - this.transform.position;
        if(dir.magnitude < 100.0f)
        {
            dir.y = 0.0f;

            NMA.SetDestination(Player.position);

            Anim.SetBool("isIdle", false);
            Anim.SetBool("isAttacking", false);
            Anim.SetBool("isRunning", true);

            if(dir.magnitude < 15.0f)
            {
                Anim.SetBool("isAttacking", true);
                Anim.SetBool("isRunning", false);
            }
        } else
        {
            Anim.SetBool("isIdle", true);
            Anim.SetBool("isRunning", false);
            Anim.SetBool("isAttacking", false);
        }
    }
}
