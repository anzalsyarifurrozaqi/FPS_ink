
namespace Ink_Project {
    public class CheckCondition_Shooting : CheckConditionBase {
        public override bool MeetCondition(CharacterControl control) {            
            if (control.Shot) {
                return true;
            }

            return false;
        }
    }
}