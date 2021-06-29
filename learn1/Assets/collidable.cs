using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    public int i;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()

{
boxCollider = GetComponent<BoxCollider2D>();

}

protected virtual void  Update()
{
boxCollider.OverlapCollider(filter,hits);
for(i = 0;i<hits.Length;i++)
{
if(hits[i] == null)
continue;
onCollide(hits[i]);

hits[i] = null;
}
}
protected virtual void onCollide(Collider2D coll)
{

}
}
