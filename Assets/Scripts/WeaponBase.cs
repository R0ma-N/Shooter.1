using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public abstract class WeaponBase : BaseObjectModel
    {
        public Ammunition Ammunition;
        public Transform _barrel;
        public bool IsReady = true;
        public float ShootInterval;

        [SerializeField] protected float _force = 999;
        [SerializeField] protected float _rechargeTime = 0.2f;

        protected Timer Timer = new Timer();

        public abstract void Fire();
    }
}
