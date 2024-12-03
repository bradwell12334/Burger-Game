using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public Transform shootingTarget;
    public GameObject shootingTargetGameObject;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
            if (bulletPrefab != null)
            {

            }
        }

    }
}
