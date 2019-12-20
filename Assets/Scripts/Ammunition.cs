using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class Ammunition
    {
        public BulletModel Bullet = new BulletModel();
        public GameObject bullet;

        public Ammunition()
        {
            Bullet = Object.FindObjectOfType<BulletModel>();
            bullet = Bullet.Instance;
            if(bullet) Debug.Log(9);
        }
    }
}
