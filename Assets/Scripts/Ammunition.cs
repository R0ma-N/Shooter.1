using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class Ammunition
    {
        public BulletModel Bullet;

        public Ammunition()
        {
            Bullet = Object.FindObjectOfType<BulletModel>();
        }
        void jump()
        {

        }
    }
}
