using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI

public class movement : MonoBehaviour { 
{
    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;
    int hitCounter = 0;


    // Start is called before the first frame update
    void Start() { 
        Start.Coroutine(this.StartBall());

    }
        public IEnumerator StartBall(bool isStartingPlayer1 = true){

            this.hitCounter = 0;
            yied return new WaitForSeconds(2);
            if (isStartingPlayer1)
                this.Moveball(new vector2 (-1, 0));
            else { 
                this.Moveball(new vector2 (1, 0));
        }
    }

        public void MoveBall(vector2 dir){

            dir = dir.normalized;
            float speed = this movementSpeed + this.hitCounter * this.extraSpeedPerHit;
            Rigidbody2D rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();
            rigidBody2D.velocity = dir * speed;
        }
    public void IncreaseHitCounter()
    {
        if(this.hitCounter * this.extraSpeedPerHit <= this.maxExtraSpeed){        {
                this.hitCounter++;
             }
        }
    }

