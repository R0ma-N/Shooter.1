using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class PistolModel : WeaponBase
    {
        protected override void Awake()
        {
            base.Awake();
            ShootInterval = 5;
        }

        override public void Fire()
        {
            var tempAmmunation = Instantiate(Ammunition, _barrel.position, _barrel.rotation);
            tempAmmunation.AddForce(_barrel.forward * _force);
            Debug.Log("Pistol has shoot");
        }
    }
}
