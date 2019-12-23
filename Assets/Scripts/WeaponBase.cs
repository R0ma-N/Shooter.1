using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public abstract class WeaponBase : BaseObjectModel
    {
        public Ammunition Ammunition;

        protected Transform _barrel;
        [SerializeField] protected float _force = 999;
        [SerializeField] protected float _rechargeTime = 0.2f;

        public WeaponBase()
        {
            _barrel = GetComponentInChildren<Transform>();
        }
        public abstract void Fire();
    }
}
