using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class door : collidep
{
public Animator animator;

protected override void onCollide(Collider2D coll)
  {
  if(coll.name == "player2")
  OnCollide();


  }
  protected virtual void OnCollide()
  {
  animator.SetBool("open",true);

  }


}


