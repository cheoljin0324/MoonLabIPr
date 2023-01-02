using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAround : MonoBehaviour
{
    [SerializeField]
    private Transform _train = null;

    private void Start()
    {
        StartCoroutine(ExplosionWhile());
    }

    private IEnumerator ExplosionWhile()
    {
        while (true)
        {
            Vector3 position = _train.position;
            position.x += Random.Range(-5f, 5f);
            position.z += Random.Range(-55f, 5f);

            HitEffectManager.Instance.CreateExplosionEffect(position);

            yield return new WaitForSeconds(Random.Range(0.1f, 1f));
        }
    }
}
