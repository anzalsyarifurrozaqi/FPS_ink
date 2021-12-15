
namespace Ink_Project {
    public class CheckCondition_Aiming : CheckConditionBase
    {
        public override bool MeetCondition(CharacterControl control)
        {
            if (control.Aim) {
                return true;
            }

            return false;
        }
    }
}