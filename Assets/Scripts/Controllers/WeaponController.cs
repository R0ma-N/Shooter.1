using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class WeaponController : BaseController
    {
        public Transform FirePoint;
        public Ammunition Ammunition;
        public GameObject ammunition;

        public WeaponController()
        {
            ammunition = Ammunition.bullet;
            FirePoint = Inventory.MachineGun.FirePoint;
        }

        public void Fire()
        {
            Object.Instantiate(ammunition, FirePoint.position, Quaternion.identity);
        }
    }
}
