using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBody : BodyBase {
    public override void Hurt()
    {
        UIManager.current_score++;
        base.Hurt();
      
    }
}
