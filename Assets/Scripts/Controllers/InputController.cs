using UnityEngine;

namespace Shooter
{
    public class InputController : BaseController, IOnUpdate
    {
        private FlashLightController _flashLightController = new FlashLightController();
        private WeaponController _weaponController = new WeaponController();

        private KeyCode _activeFlashLight = KeyCode.F;
        private KeyCode _fire = KeyCode.Mouse0;

        public InputController()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        public void OnUpdate()
        {
            if (Input.GetKeyDown(_activeFlashLight))
            {
                Debug.Log("F");
                _flashLightController.Switch();
            }

            if (Input.GetKeyDown(_fire))
            {
                Debug.Log("fire");
                _weaponController.Fire();
            }
        }
    }
}
