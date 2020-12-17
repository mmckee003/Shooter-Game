using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyHead : BodyBase {

    public override void Hurt()
    {
        UIManager.current_score += 3;
        base.Hurt();
        
    }
}
