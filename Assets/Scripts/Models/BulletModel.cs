using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class BulletModel : BaseObjectModel
    {
        public Transform Transform;
        public float Damage;
        public GameObject Instance;

        private void Start()
        {
            Instance = gameObject;
            if(Instance) Debug.Log(9);
        }

        private void Update()
        {
            Rigidbody.AddForce(new Vector3(0, 0, 100), ForceMode.Force);
            
        }
    }
}
