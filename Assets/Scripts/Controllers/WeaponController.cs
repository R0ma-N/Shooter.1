using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class WeaponController : BaseController
    {
        private WeaponBase _weapon;

        public void Fire()
        {
            _weapon.Fire();
        }

        public WeaponController()
        {
            //Ammunition = new Ammunition();
            //FirePoint = Inventory.MachineGun.FirePoint;
        }

    }
}
