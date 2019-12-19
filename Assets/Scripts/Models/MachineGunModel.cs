using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class MachineGunModel : MonoBehaviour
    {
        public Transform FirePoint;
        void Awake()
        {
            FirePoint = GetComponentInChildren<Transform>();
        }
    }
}
