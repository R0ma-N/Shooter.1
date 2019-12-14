using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class Inventory //: IOnInitialize
    {
        public List<Object> inventory;

        public FlashLightModel FlashLight;

        public Inventory()
        {
            FlashLight = Object.FindObjectOfType<FlashLightModel>();
        }
    }
}
