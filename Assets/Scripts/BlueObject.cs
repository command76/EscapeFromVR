using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueObject : MonoBehaviour
{

    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        initMeshRenderer();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (HeadSphereControl.areGlassesEquiped == true)
        { EnableMeshRenderer(); }
        else if (HeadSphereControl.areGlassesEquiped == false)
        { DisableMeshRenderer(); }

    }

    void initMeshRenderer()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void DisableMeshRenderer()
    {
        meshRenderer.enabled = false;
    }
    void EnableMeshRenderer()
    {
        meshRenderer.enabled = true;
    }
}
