using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class BulletModel : MonoBehaviour
    {
        public Transform Transform;
        public float Damage;

        private void Awake()
        {
            Transform = GetComponent<Transform>();
        }
    }
}
