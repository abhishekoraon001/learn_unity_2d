using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
  private BoxCollider2D boxcollider;
  private Vector3 moveDelta;
  private RaycastHit2D hit;
  public Animator animator;
    void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();
    }


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDelta = new Vector3(x*4,y*4,0);

 if(moveDelta.x>0)
{
animator.SetBool("left",false);
                animator.SetBool("right",true);

}

                else if(moveDelta.x<0)
                {
                animator.SetBool("left",true);
                animator.SetBool("right",false);


                }

                else if(moveDelta.x==0)
                                {
                                animator.SetBool("right",false);
                                animator.SetBool("left",false);

                                }
       if(moveDelta.y>0)
       {

         animator.SetBool("up",true);
         animator.SetBool("down",false);
       }

                       else if(moveDelta.y<0)
                       {

                                animator.SetBool("up",false);
                                animator.SetBool("down",true);
                       }

                       else if(moveDelta.y==0)
                                       {

                                                                       animator.SetBool("up",false);
                                                                       animator.SetBool("down",false);
                                       }





        hit = Physics2D.BoxCast(transform.position,boxcollider.size,0,new Vector2(0,moveDelta.y),Mathf.Abs(moveDelta.y*Time.deltaTime),LayerMask.GetMask("characters","blocking"));
        if(hit.collider == null)
        {
        transform.Translate(0,moveDelta.y*2*Time.deltaTime,0);
        }

        hit = Physics2D.BoxCast(transform.position,boxcollider.size,0,new Vector2(moveDelta.x,0),Mathf.Abs(moveDelta.x*Time.deltaTime),LayerMask.GetMask("characters","blocking"));
                if(hit.collider == null)
                {
                transform.Translate(moveDelta.x*2*Time.deltaTime,0,0);
                }
    }
}
