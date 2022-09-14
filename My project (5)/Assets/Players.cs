using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Players : MonoBehaviour
{ public int inc;
    public Transform minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minX.position.x, maxX.position.x), transform.position.y, transform.position.z);

        }
        else if (Input.GetKeyDown(KeyCode.A)) {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minX.position.x, maxX.position.x), transform.position.y, transform.position.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);

        }
    }
}
