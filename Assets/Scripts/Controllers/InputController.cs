using UnityEngine;

namespace Shooter
{
    public class InputController : BaseController, IOnUpdate
    {
        private FlashLightController _flashLightController;

        private KeyCode _activeFlashLight = KeyCode.F;
        
        public InputController()
        {
            _flashLightController = new FlashLightController();
        }
        
        public void OnUpdate()
        {
            if (Input.GetKeyDown(_activeFlashLight))
            {
                Debug.Log("F");
                _flashLightController.Switch();
            }
        }
    }
}
