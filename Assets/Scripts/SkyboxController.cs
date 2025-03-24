using UnityEngine;

[ExecuteAlways]
public class SkyboxController : MonoBehaviour
{
    public bool isMoon = true;
    private Material skyboxMaterial;
    
    private static readonly int 
        MoonPositionID = Shader.PropertyToID("_MoonPosition"),
        MaskPositionID = Shader.PropertyToID("_MaskPosition");

    
    private void Start()
    {
        skyboxMaterial = RenderSettings.skybox;
    }

    private void Update()
    {
        if (isMoon)
            skyboxMaterial.SetVector(MoonPositionID, transform.forward);
        else
            skyboxMaterial.SetVector(MaskPositionID, transform.forward);
    }
}
