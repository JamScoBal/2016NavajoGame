using UnityEngine;
using System.Collections;

public class UVScroll2 : MonoBehaviour {

    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        offset.x += Time.deltaTime / 30f;
        mat.mainTextureOffset = offset;
    }
}
