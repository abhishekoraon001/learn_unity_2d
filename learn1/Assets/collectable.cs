using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : collidable
{
  protected bool collected;
  protected override void onCollide(Collider2D coll)
  {
  if(coll.name == "player2")
  OnCollect();
  }
  protected virtual void OnCollect()
  {
  collected = true;
  }
}
