using UnityEngine;

namespace Ink_Project
{
    public class MoveTransformForward : CharacterFunction
    {
        public override void RunFunction(float Speed, float SpeedGraph)
        {
            control.transform.position += control.transform.forward * Speed * SpeedGraph * Time.deltaTime;
        }
    }
}