using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Frog : MonoBehaviour {

    Rigidbody2D rb;
    public Transform frogSpawnPoint;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>() as Rigidbody2D;
        rb.MovePosition(frogSpawnPoint.position);
        rb.SetRotation(0);
    }

    public void OnMoveUp(InputAction.CallbackContext ctx) {
        if (ctx.performed)
            rb.position = rb.position + new Vector2(0f, 1f);
            rb.SetRotation(0);
    }

    public void OnMoveDown(InputAction.CallbackContext ctx) {
        if (ctx.performed)
            rb.position = rb.position + new Vector2(0, -1f);
            rb.SetRotation(180);
    }

    public void OnMoveLeft(InputAction.CallbackContext ctx) {
        if (ctx.performed)
            rb.position = rb.position + new Vector2(-1f, 0);
            rb.SetRotation(90);
    }

    public void OnMoveRight(InputAction.CallbackContext ctx) {
        if (ctx.performed)
            rb.position = rb.position + new Vector2(1f, 0);
            rb.SetRotation(270);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Equals("Vehicle")) {
            takeDamage();
        }
    }

    void takeDamage() {
        rb.MovePosition(frogSpawnPoint.position);
    }
}
