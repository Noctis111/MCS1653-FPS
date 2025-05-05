using UnityEngine;

public class BouncePlatform : MonoBehaviour
{
    public Material TargetM;
    public Material BouncyM;

    private Renderer[] childRenderers;

    void Start()
    {
        childRenderers = GetComponentsInChildren<Renderer>();

        foreach (Renderer rend in childRenderers)
        {
            if (rend.gameObject != this.gameObject && TargetM != null)
            {
                rend.sharedMaterial = TargetM;
            }
        }
    }

    public void ActivatePlatform()
    {
        foreach (Renderer rend in childRenderers)
        {
            if (rend.gameObject != this.gameObject && BouncyM != null)
            {
                rend.sharedMaterial = BouncyM;
            }
        }
    }
}
