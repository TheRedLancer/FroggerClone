using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour {
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed = 1f;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>() as Rigidbody2D;
        rb.velocity = new Vector2(speed, 0);
    }

    void Update() {
        if (transform.position.x >= 10) {
            rb.MovePosition(new Vector2(-10f, transform.position.y));
        }
    }
}
