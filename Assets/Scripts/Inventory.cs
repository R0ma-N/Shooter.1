using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class Inventory : IOnInitialize
    {
        public List<Object> inventory;
        public FlashLightModel FlashLight;

        public static Inventory Instance;

        public void OnStart()
        {
            Debug.Log("inventory-start");
            FlashLight = Object.FindObjectOfType<FlashLightModel>();
            if (FlashLight)
            {               
                Debug.Log("inventory-got");
            }
        }
    }
}
