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

        if (Physics.Raycast(spawnpoint.position, spawnpoint.forward, out hit, distance, ~0, QueryTriggerInteraction.Collide))
        {
            Debug.Log("Hit: " + hit.transform.name);

            if (hit.transform.CompareTag("Bounce"))
            {
                BoxCollider box = hit.transform.GetComponentInParent<BoxCollider>();
                if (box != null)
                {
                    box.isTrigger = false;
                    Debug.Log("Bounce on " + hit.transform.name);
                }

                BouncePlatform bouncePlatform = hit.transform.GetComponentInParent<BouncePlatform>();
                if (bouncePlatform != null)
                {
                    bouncePlatform.ActivatePlatform();
                }
            }

            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {
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
