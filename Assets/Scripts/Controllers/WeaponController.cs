using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class WeaponController : BaseController, IOnUpdate
    {
        private WeaponBase _weapon;
        private KeyCode _fire = KeyCode.Mouse0;

        public WeaponController()
        {
            _weapon = Inventory._weapons[0];
            Debug.Log(_weapon);
        }

        public void OnUpdate()
        {
            if (Input.GetKeyDown(_fire))
            {
                if (!_weapon) Debug.Log("nope");
                Inventory._weapons[0].Fire();
            }

        }

        public override void On(BaseObjectModel weapon)
        {
            base.On(weapon);

            _weapon = weapon as WeaponBase;
        }

    }
}
