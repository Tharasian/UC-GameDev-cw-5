using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour
{ public float speed;
    float intensity=0;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }   

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0f, 0f, speed+intensity);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "Finish")
        {
            Destroy(this.gameObject);
            intensity -= 0.1f;
        }
    }
}
