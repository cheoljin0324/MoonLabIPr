using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float _hp = 100.0f;

    public bool canMove = true;
    public int spawnPointIndex = 0;

    private Renderer renderer;

    void Awake()
    {
        renderer = GetComponent<Renderer>();
        StartCoroutine(Move());
    }

    private void Update()
    {
        if(RouteCanvasSliderController.Instance.isEnd && _hp > 0)
        {
            _hp = 0;
            Damaged(0);
            //StartCoroutine(FadeOut());
        }
    }

    private IEnumerator Move()
    {
        Vector3 dir = new Vector3(1, 0, 0);
        while (RouteCanvasSliderController.Instance.isEnd == false)
        {
            if (!canMove)
            {
                yield return null;
                continue;
            }
            yield return new WaitForSeconds(Random.Range(0.5f, 1.0f));
            dir *= -1;
            transform.Translate(dir * 0.1f);
        }
    }

    public void Damaged(float damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            Destroy(gameObject);
            EnemySpawn.Instance.isSpawned[spawnPointIndex] = false;
        }
    }

    private IEnumerator FadeOut()
    {
        float fadeCount = 1f;
        while(fadeCount > 0f)
        {
            fadeCount -= 0.03f;
            yield return new WaitForSeconds(0.1f);
            renderer.sharedMaterial.color = new Color(renderer.sharedMaterial.color.r, renderer.sharedMaterial.color.g, renderer.sharedMaterial.color.b, fadeCount);
        }
        Destroy(gameObject);
        EnemySpawn.Instance.isSpawned[spawnPointIndex] = false;
    }
}
