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
                _flashLightController.Switch();
            }

            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                SelectWeapon(0);
            }
            //if (Input.GetKeyDown(_fire))
            //{
            //    _weaponController.Fire();
            //}
        }

        private void SelectWeapon(int value)
        {
            var tempWeapon = Inventory.SelectWeapon(value);
            SelectWeapon(tempWeapon);
        }

        private void SelectWeapon(WeaponBase weapon)
        {
            _weaponController.On(weapon);
        }


    }
}
