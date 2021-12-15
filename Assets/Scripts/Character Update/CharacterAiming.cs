using UnityEngine;

namespace Ink_Project {
    public class CharacterAiming : CharacterUpdate {
        public override void OnFixedUpdate() {
            throw new System.NotImplementedException();
        }

        public override void OnLateUpdate() {
            throw new System.NotImplementedException();
        }

        public override void OnUpdate() {
            var targetVal = control.Aim ? 1.0f : 0.0f;

            control.DATASET.RIG_DATA.WeaponAiming.weight = Mathf.Lerp(control.DATASET.RIG_DATA.WeaponAiming.weight, targetVal, Time.deltaTime * control.DATASET.RIG_DATA.AimDuration);
            control.DATASET.RIG_DATA.HeadAiming.weight = Mathf.Lerp(control.DATASET.RIG_DATA.HeadAiming.weight, targetVal, Time.deltaTime * control.DATASET.RIG_DATA.AimDuration);
            control.ANIMATOR.SetLayerWeight(control.ANIMATOR.GetLayerIndex("Upper Body"), targetVal);
            control.RunFunction(typeof(Aim), control.Aim);
            //if (!control.Aim) {
            //    control.DATASET.RIG_DATA.WeaponAiming.weight -= Time.deltaTime / control.DATASET.RIG_DATA.AimDuration;
            //    control.ANIMATOR.SetLayerWeight(control.ANIMATOR.GetLayerIndex("Upper Body"), 0.0f);
            //    control.RunFunction(typeof(Aim), false);
            //}
            //else {
            //    control.DATASET.RIG_DATA.WeaponAiming.weight += Time.deltaTime / control.DATASET.RIG_DATA.AimDuration;
            //    control.ANIMATOR.SetLayerWeight(control.ANIMATOR.GetLayerIndex("Upper Body"), 1.0f);
            //    control.RunFunction(typeof(Aim), true);
            //}
        }
    }
}