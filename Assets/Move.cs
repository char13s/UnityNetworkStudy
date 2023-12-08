using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Netcode;
public class Move : NetworkBehaviour
{
    CharacterController charCon;
    Rigidbody rbody;

    Vector2 stick;
    Vector3 speed;
    [SerializeField] private float move=5;
    [SerializeField] private float gravity=0.5f;
    // Start is called before the first frame update
    private void Awake() {
        move = 5;
        gravity = 4f;
    }
    void Start() {
        charCon = GetComponent<CharacterController>();
    }
    private void OnMovement(InputValue value) {
        
            stick = value.Get<Vector2>();
    }
    private void OnUm() {
        print("Pressed");
    }
    // Update is called once per frame
    void Update()
    {
        if (!IsOwner) return;
        speed.x = stick.x;
        speed.z = stick.y;
        speed.y = -gravity;
        charCon.Move(Time.deltaTime*speed*move);

    }
}
