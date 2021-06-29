using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : collectable
{
public Sprite emptychest;
public int pesosamount =5;
protected override void OnCollect()
{
if(!collected)
{
collected = true;
GetComponent<SpriteRenderer>().sprite = emptychest;
Debug.Log("Grant "+pesosamount+" pesos");
}

}
}
