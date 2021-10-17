using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class MoveTransformAim : CharacterFunction {
        public override void RunFunction() {
            var direction = Vector3.right * control.Move.x + Vector3.forward * control.Move.y;
            control.transform.Translate(direction.normalized * Time.deltaTime);
        }
    }
}