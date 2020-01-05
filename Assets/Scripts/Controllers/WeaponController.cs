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
                _activeWeapon.IsReady = _timer.TimeIsUp(_activeWeapon.ShootInterval);
            }
            else if (Input.GetKeyUp(_fire))
            {
                _activeWeapon.IsReady = true;
                _timer.DistTime = 0;
            }


            float mv = Input.GetAxis("Mouse ScrollWheel");

            if (mv > 0)
            {
                Debug.Log(_index);
                if (_index < Inventory._weapons.Count - 1)
                {
                    ChangeVisability(_index + 1);
                    return;
                }
                
                if (_index == Inventory._weapons.Count - 1)
                {
                    ChangeVisability(0);
                }
            }
            
            if (mv < 0)
            {
                if (_index > 0)
                {
                    ChangeVisability(_index - 1);
                    return;
                }

                if (_index == 0)
                {
                    ChangeVisability(Inventory._weapons.Count - 1);
                }
            }
        }

        private void ChangeVisability(int index)
        {
            Debug.Log("got_method");
            if (_activeWeapon) _activeWeapon.IsVisible(false);
            _index = index;
            _activeWeapon = Inventory._weapons[_index];
            _activeWeapon.IsVisible(true);
            Debug.Log(_activeWeapon);
        }
    }
}
