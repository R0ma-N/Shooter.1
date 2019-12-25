using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class WeaponController : BaseController, IOnUpdate
    {
        private WeaponBase _activeWeapon;
        private int _index = 0;
        private KeyCode _fire = KeyCode.Mouse0;
        
        public WeaponController()
        {
            //_weapon = Inventory._weapons[0];
        }

        public void OnUpdate()
        {
            if (Input.GetKeyDown(_fire))
            {
                Debug.Log(_activeWeapon);
                _activeWeapon.Fire();
            }

            float mv = Input.GetAxis("Mouse ScrollWheel");

            if (mv > 0)
            {
                if (_index < Inventory._weapons.Count - 1)
                {
                    if (_activeWeapon) _activeWeapon.IsVisible(false);
                    _index++;
                    _activeWeapon = Inventory._weapons[_index];
                    _activeWeapon.IsVisible(true);
                    Debug.Log(_activeWeapon);
                }
                else _index = 0;
            }
            
            if (mv < 0)
            {
                if (_index >= 0)
                {
                    _activeWeapon.IsVisible(false);
                    _index--;
                    _activeWeapon = Inventory._weapons[_index];
                    _activeWeapon.IsVisible(true);
                    Debug.Log(_activeWeapon);
                }
                else _index = Inventory._weapons.Count;
            }
        }


    }
}
