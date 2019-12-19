using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public abstract class WeaponController : BaseController
    {
        public Transform FirePoint;
        public GameObject Ammunition;

        public void Fire()
        {
            Object.Instantiate(Ammunition, FirePoint.position, Quaternion.identity);
        }
    }
}
