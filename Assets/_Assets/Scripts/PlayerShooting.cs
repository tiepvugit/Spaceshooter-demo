using System;
using UnityEngine;

namespace demo
{
    public class PlayerShooting : MonoBehaviour
    {
        private const int LMouseIndex = 0;
        [SerializeField]private GameObject bulletPfb;
        private float lastShot;
        [SerializeField] private float interval;

        private void Update()
        {
            HandleShooting();
        }

        private void HandleShooting()
        {
            if (IsLMouseClick())
            {
                if (IsReadyToShoot())
                {
                    Shoot();
                    lastShot = Time.time;
                }
            }
        }

        private bool IsReadyToShoot()
        {
            var currentTime = Time.time;
            var delay = currentTime - lastShot;
            return delay > interval;
        }

        private void Shoot()
        {
            Instantiate(bulletPfb, transform.position, transform.rotation);
        }

        private static bool IsLMouseClick()
        {
            return Input.GetMouseButton(LMouseIndex);
        }
    }
}