using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemy : MonoBehaviour
{
    private BoundsCheck bndCheck;
    public Rigidbody rigid;
    public Vector3 velocity; 

    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
        rigid = GetComponent<Rigidbody>();
    }

     void Start()
    {
         if (rigid != null && velocity != Vector3.zero)
        {
            rigid.velocity = velocity; 
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        Destroy(this.gameObject);
    }

    void Update()
    {
        if (bndCheck.LocIs(BoundsCheck.eScreenLocs.offUp))
        {
            Destroy(gameObject);
        }
    }
}
