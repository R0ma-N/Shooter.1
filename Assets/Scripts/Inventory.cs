using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Shooter
{
    public class Inventory : IOnInitialize
    {
        public List<Object> inventory;
        public List<WeaponBase> _weapons;

        //public List<WeaponBase> Weapons => _weapons;
        private int _selectedWeapon = 0;

        public FlashLightModel FlashLight;
        public MachineGunModel MachineGun;
        public GameObject Player;

        public Inventory()
        {
            FlashLight = Object.FindObjectOfType<FlashLightModel>();
            MachineGun = Object.FindObjectOfType<MachineGunModel>();
            Player = GameObject.FindGameObjectWithTag("Player");

            _weapons = Player.GetComponentsInChildren<WeaponBase>().ToList();
            Debug.Log(_weapons);
        }
        public void OnStart()
        {
           // FlashLight = Object.FindObjectOfType<FlashLightModel>();
        }



        public WeaponBase SelectWeapon(int value)
        {
            return SelectWeapon(_selectedWeapon);
        }

    }
}
