using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyHead : BodyBase {

    public override void Hurt()
    {
        Score.score += 3;
        base.Hurt();
        
    }
}
