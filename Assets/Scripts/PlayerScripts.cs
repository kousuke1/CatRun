using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScripts : MonoBehaviour
{
  public static float speed = 10.0f;
  Rigidbody rd;
  float jumpPower = 600.0f;
  public const int Max_JumpCount = 2;
  int JumpCount = 0;
  



      void Start(){ 
          this.rd = GetComponent<Rigidbody>();
      }

    // Update is called once per frame
      void Update(){
        Vector2 Position = transform.position;
        transform.position += transform.right * speed * Time.deltaTime;

           if (JumpCount < Max_JumpCount && Input.GetKeyDown(KeyCode.Space))
            {
              this.rd.AddForce(transform.up * this.jumpPower); 
              JumpCount  += 1;
            }
            
      }     
      	private void OnCollisionEnter( Collision collision ){
		    // 地面との当たり。
	        if (collision.gameObject.tag == "Floor"){
			      JumpCount = 0;
		      }
        }
  }
