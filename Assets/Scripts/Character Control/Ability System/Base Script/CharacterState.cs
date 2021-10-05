using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public class CharacterState : StateMachineBehaviour
    {
        public CharacterControl control;

        [Space(10)]
        //public List<CharacterAbility> ListAbilityData = new List<CharacterAbility>();
        [Space(10)]
        public CharacterAbility[] ArrAbilities;

        public Dataset DATASET => control.DATASET;

        //public void PutStateInArray()
        //{
        //    ArrAbilities = new CharacterAbility[ListAbilityData.Count];

        //    for (int i = 0; i < ListAbilityData.Count; i++)
        //    {
        //        ArrAbilities[i] = ListAbilityData[i];
        //    }
        //}

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            EnterAll(this, animator, stateInfo, ArrAbilities);
        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            UpdataAll(this, animator, stateInfo, ArrAbilities);
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            ExitAll(this, animator, stateInfo, ArrAbilities);
        }

        public void EnterAll (CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo, CharacterAbility[] AbilityList)
        {            
            for (int i = 0; i < AbilityList.Length; i++)
            {
                AbilityList[i].OnEnter(characterState, animator, stateInfo);

                if (control.DATASET.ABILITY_DATA.CurrentAbilities.ContainsKey(AbilityList[i]))
                {
                    control.DATASET.ABILITY_DATA.CurrentAbilities[AbilityList[i]] += 1;
                }
                else
                {
                    control.DATASET.ABILITY_DATA.CurrentAbilities.Add(AbilityList[i], 1);
                }
            }
        }

        public void UpdataAll(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo, CharacterAbility[] AbilityList)
        {
            for (int i = 0; i < AbilityList.Length; i++)
            {
                AbilityList[i].UpdateAbility(characterState, animator, stateInfo);
            }
        }

        public void ExitAll(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo, CharacterAbility[] AbilityList)
        {
            for (int i = 0; i < AbilityList.Length; i++)
            {
                AbilityList[i].OnExit(characterState, animator, stateInfo);

                if (control.DATASET.ABILITY_DATA.CurrentAbilities.ContainsKey(AbilityList[i]))
                {
                    control.DATASET.ABILITY_DATA.CurrentAbilities[AbilityList[i]] -=1;
                }
                
                if (control.DATASET.ABILITY_DATA.CurrentAbilities[AbilityList[i]] <= 0)
                {
                    control.DATASET.ABILITY_DATA.CurrentAbilities.Remove(AbilityList[i]);
                }
            }
        }

        public bool UpdatingAbility(System.Type characterAbilityType)
        {
            return false;
        }
    }
}