using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    public Rigidbody playerRigidbody;
    public float speed = 8f;
    void Start() {
        
    }
    
    void Update(){
        //위쪽 방향
        if (Input.GetKey(KeyCode.UpArrow) == true){
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        //아래쪽 방향
        if (Input.GetKey(KeyCode.DownArrow) == true){
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        //오른쪽 방향
        if (Input.GetKey(KeyCode.RightArrow) == true){
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        //왼쪽 방향
        if (Input.GetKey(KeyCode.LeftArrow) == true){
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }

    //게임 오브젝트 비활성화
    public void Die(){
        gameObject.SetActive(false);
    }
}


