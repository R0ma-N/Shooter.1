using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class MachineGunController : BaseController
    {
        private MachineGunModel _machineGun;
        public MachineGunController()
        {
            _machineGun = Inventory.MachineGun;
        }

        public void Shoot()
        {

        }

    }
}
