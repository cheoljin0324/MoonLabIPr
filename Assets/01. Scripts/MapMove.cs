using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    private MeshRenderer _meshRenderer;

    private float offset = 0.0f;

    public float speed = 0.0f;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        offset += Time.deltaTime * speed;
        _meshRenderer.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
