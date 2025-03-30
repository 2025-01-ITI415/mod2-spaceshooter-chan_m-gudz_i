using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemy : MonoBehaviour
{
    private BoundsCheck bndCheck;
    public float speed = 10f;
    public Rigidbody rigid;
    private Vector2 moveDirection = Vector2.down; 

    // Start is called before the first frame update
    void Start()
    {
        if(rigid != null){
            rigid.velocity = moveDirection * speed;
        }
    }

    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();   
        rigid = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision coll){
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (bndCheck.LocIs(BoundsCheck.eScreenLocs.offUp))
        {
            Destroy(gameObject);
        }
    }
}
