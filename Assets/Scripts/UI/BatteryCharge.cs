using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Shooter
{
    public class BatteryCharge : MonoBehaviour
    {
        public Image[] UIBatteryDevisions;
        public Canvas UIBattery;
        
        void Awake()
        {
            UIBatteryDevisions = GetComponentsInChildren<Image>();
            UIBattery = GetComponentInParent<Canvas>();
        }
    }
}
