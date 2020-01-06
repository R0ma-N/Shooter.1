using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class FlairGun : WeaponBase
    {
        private Inventory _inventory;
        public FlairGun instance;

        private void Awake()
        {
            _inventory = new Inventory();
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                gameObject.transform.parent = Camera.main.transform;
                _inventory.AddWeapon(instance);
                Debug.Log(_inventory._weapons.Count);
            }
            //Debug.Log(00000);
        }

        public override void Fire()
        {

        }
    }
}
