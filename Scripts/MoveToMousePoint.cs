using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickMoviment : MonoBehaviour{
    
    [SerializeField] private float velocity;

    void Update(){
        LookMouse();
        Up();
    }

    //LOOK MOUSE
    private void LookMouse(){
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;
    }

    //MOVIMENT
    public void Up(){
        transform.Translate(0, Velocity * Time.deltaTime, 0);
    }

    //GETTERS E SETTERS
    public float Velocity{get{return this.velocity;} set{this.velocity = value;}}
}
