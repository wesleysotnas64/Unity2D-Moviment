using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* MOVIMENTO BÁSICO UTILIZANDO O -> 'Translate'
*Maneira mais simples de movimentar um personagem em uma cena.
*As funções Up, Down, Right e Left podem ser chamadas através de componentes que você mesmo desenvolveu.
*Neste modelo eu utiliso um simples 'if' para chamar os métodos

***OBS: Lembre que NÃO É RECOMENDADE utilizar o 'Translate' para interações de física.
*/

public class BasicMoviment : MonoBehaviour{
    
    [SerializeField] private float velocity;

    void Start(){
        Velocity = 10;
    }

    
    void Update(){
        //SIMPLE JOYSTIC
        if(Input.GetKey("w")) Up();
        if(Input.GetKey("s")) Down();
        if(Input.GetKey("d")) Right();
        if(Input.GetKey("a")) Left();
    }

    //MOVIMENT
    public void Up(){
        transform.Translate(0, Velocity * Time.deltaTime, 0);
    }

    public void Down(){
        transform.Translate(0, -Velocity * Time.deltaTime, 0);
    }

    public void Right(){
        transform.Translate(Velocity * Time.deltaTime, 0, 0);
    }

    public void Left(){
        transform.Translate(-Velocity * Time.deltaTime, 0, 0);
    }

    //GETTERS E SETTERS
    public float Velocity{get{return this.velocity;} set{this.velocity = value;}}
}
