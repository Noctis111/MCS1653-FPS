using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform spawnpoint;
    public float distance = 30f;

    public AudioSource audioSource;
    public AudioClip shootingSound;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            audioSource.PlayOneShot(shootingSound);
        }
    }

    private void Shoot()
    {
        RaycastHit hit;

        // Include triggers in the raycast
        if (Physics.Raycast(spawnpoint.position, spawnpoint.forward, out hit, distance, ~0, QueryTriggerInteraction.Collide))
        {
            Debug.Log("Hit: " + hit.transform.name);

            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {
                // Only destroy if the hit collider is a SphereCollider
                if (hit.collider is SphereCollider)
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
        else
        {
            Debug.Log("No hit");
        }
    }
}
