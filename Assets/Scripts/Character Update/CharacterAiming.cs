using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class CharacterAiming : CharacterUpdate {
        public override void OnFixedUpdate()
        {
            throw new System.NotImplementedException();
        }

        public override void OnLateUpdate()
        {
            throw new System.NotImplementedException();
        }

        public override void OnUpdate()
        {
            if (control.Move != Vector2.zero)
                control.DATASET.RIG_DATA.WeaponAiming.weight -= Time.deltaTime / control.DATASET.RIG_DATA.AimDuration;
            else
                control.DATASET.RIG_DATA.WeaponAiming.weight += Time.deltaTime / control.DATASET.RIG_DATA.AimDuration;
        }        
    }
}