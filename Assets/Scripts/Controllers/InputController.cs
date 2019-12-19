using UnityEngine;

namespace Shooter
{
    public class InputController : BaseController, IOnUpdate
    {
        private FlashLightController _flashLightController = new FlashLightController();

        private KeyCode _activeFlashLight = KeyCode.F;       
        
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
