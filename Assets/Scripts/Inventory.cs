using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Shooter
{
    public class Inventory
    {
        public List<Object> inventory;
        public List<WeaponBase> _weapons;
        public WeaponBase ActiveWeapon { get; private set; }

        public FlashLightModel FlashLight;
        public GameObject Player;

        public Inventory()
        {
            FlashLight = Object.FindObjectOfType<FlashLightModel>();
            Player = GameObject.FindGameObjectWithTag("Player");

            _weapons = Player.GetComponentsInChildren<WeaponBase>().ToList();
            Debug.Log(_weapons.Count);
            Debug.Log(ActiveWeapon);
        }
        
        //public void OnStart()
        //{
        //   // FlashLight = Object.FindObjectOfType<FlashLightModel>();
        //}



        public void SelectWeapon(int value)
        {
            ActiveWeapon = _weapons[value];
            Debug.Log(ActiveWeapon);
        }

    }
}
