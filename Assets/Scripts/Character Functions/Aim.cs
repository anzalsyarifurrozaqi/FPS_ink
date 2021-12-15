
namespace Ink_Project {
    public class Aim : CharacterFunction {
        public override void RunFunction(bool active) {
            CameraManager.Instance.CameraControl.ActiveCameraFireAim(active);
        }
    }
}