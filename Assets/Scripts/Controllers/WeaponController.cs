using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class WeaponController : BaseController, IOnUpdate
    {
        private WeaponBase _activeWeapon;
        private Timer _timer;
        private KeyCode _fire = KeyCode.Mouse0;
        private int _index = 0;
        private bool ready = true;
        
        public WeaponController()
        {
            _activeWeapon = Inventory._weapons[0];
            _timer = new Timer();

        }

        public void OnUpdate()
        {
            if (Input.GetKey(_fire))
            {
                _activeWeapon.Fire();
                if (_timer.TimeIsUp(1)) _activeWeapon.Fire();
                
            }


            float mv = Input.GetAxis("Mouse ScrollWheel");

            if (mv > 0)
            {
                Debug.Log(_index);
                if (_index < Inventory._weapons.Count - 1)
                {
                    if (_activeWeapon) _activeWeapon.IsVisible(false);
                    _index++;
                    _activeWeapon = Inventory._weapons[_index];
                    _activeWeapon.IsVisible(true);
                    Debug.Log(_activeWeapon);
                    return;
                }
                
                if (_index == Inventory._weapons.Count - 1) 
                {
                    _activeWeapon.IsVisible(false);
                    _index = 0;
                    _activeWeapon = Inventory._weapons[_index];
                    _activeWeapon.IsVisible(true);
                    Debug.Log(_activeWeapon);
                }
            }
            
            if (mv < 0)
            {
                if (_index > 0)
                {
                    _activeWeapon.IsVisible(false);
                    _index--;
                    _activeWeapon = Inventory._weapons[_index];
                    _activeWeapon.IsVisible(true);
                    Debug.Log(_activeWeapon);
                    return;
                }

                if (_index == 0)
                {
                    _activeWeapon.IsVisible(false);
                    _index = Inventory._weapons.Count - 1;
                    _activeWeapon = Inventory._weapons[_index];
                    _activeWeapon.IsVisible(true);
                    Debug.Log(_activeWeapon);
                }
            }
        }


    }
}
