using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Netcode;
public class PlayerInputControls : NetworkBehaviour
{
    CharacterController charCon;
    Rigidbody rbody;
    Animator anim;

    Vector2 stick;
    Vector3 speed;
    // Start is called before the first frame update
    private void Awake() {
        
        charCon = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
    void Start() {
        
    }
    private void OnUm() {
        
        anim.SetTrigger("Punch");
    }
    // Update is called once per frame
    void Update() {
        if (!IsOwner) return;
        //speed.x = stick.x;
        //speed.z = stick.y;
        //speed.y = -gravity;
        //charCon.Move(Time.deltaTime * speed * move);

    }
}
