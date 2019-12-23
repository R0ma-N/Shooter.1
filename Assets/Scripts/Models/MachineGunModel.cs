using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class MachineGunModel : WeaponBase
    {
        public Transform FirePoint;
        //void Awake()
        //{
        //    FirePoint = GetComponentInChildren<Transform>();
        //}

        public override void Fire()
        {
            if (!Ammunition) return;
            var tempAmmunation = Instantiate(Ammunition, _barrel.position, _barrel.rotation);
            tempAmmunation.AddForce(_barrel.forward * _force);
        }
    }
}
