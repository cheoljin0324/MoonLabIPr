using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaking : MonoBehaviour
{
    public float shakeDuration = 0.5f;
    public float shakeMagnitude = 0.5f;

    void Start()
    {
        StartCoroutine(Shake(shakeDuration, shakeMagnitude));
    }

    private IEnumerator Shake(float duration, float magnitude)
    {
        while (true)
        {
            Vector3 originalPos = transform.localPosition;

            float elapsed = 0.0f;

            while (elapsed < duration)
            {
                //float x = transform.position.x + Random.Range(-1f, 1f) * magnitude;
                float y = transform.position.y + Random.Range(-1f, 1f) * magnitude;
                //float z = transform.position.z + Random.Range(-1f, 1f) * magnitude;

                transform.localPosition = new Vector3(originalPos.x, y, originalPos.z);

                elapsed += Time.deltaTime;

                yield return null;
            }

            transform.localPosition = originalPos;
            yield return null;
        }
    }
}
