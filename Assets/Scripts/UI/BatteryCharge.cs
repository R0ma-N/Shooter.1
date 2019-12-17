using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Shooter
{
    public class BatteryCharge : MonoBehaviour
    {
        public Image[] _char6;
        void Awake()
        {
            _char6 = GetComponentsInChildren<Image>();
            //_char6[0].enabled = false;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
