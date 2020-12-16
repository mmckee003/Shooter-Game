using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBody : BodyBase {
    public override void Hurt()
    {
        Score.score++;
        base.Hurt();
      
    }
}
