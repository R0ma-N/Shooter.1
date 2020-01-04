using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class MachineGunModel : WeaponBase
    {
        //public Transform FirePoint;
        
        override protected void Awake()
        {
            base.Awake();
            ShootInterval = 0.1f;
        }

        public override void Fire()
        {
            var tempAmmunation = Instantiate(Ammunition, _barrel.position, _barrel.rotation);
                tempAmmunation.AddForce(_barrel.forward * _force);
        }
    }
}
