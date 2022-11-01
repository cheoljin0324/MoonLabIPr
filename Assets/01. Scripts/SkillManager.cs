using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : Singleton<SkillManager>
{
    public Canvas _skillCanvas;

    void Start()
    {
        _skillCanvas.enabled = false;
    }

    public void UseSkill()
    {
        _skillCanvas.enabled = true;
        StartCoroutine(UseSkillCoroutine());
    }

    IEnumerator UseSkillCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        while (true)
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hit))
            {
                _skillCanvas.transform.position = new Vector3(hit.point.x, 0, hit.point.z);
            }
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hitInfo;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
                {
                    Collider[] enemyColliders = Physics.OverlapBox(hitInfo.point, new Vector3(10f, 1f, 10f), Quaternion.identity, LayerMask.GetMask("Enemy"));
                    foreach (var enemyCollider in enemyColliders)
                    {
                        Destroy(enemyCollider.gameObject);
                    }
                }
                _skillCanvas.enabled = false;
                break;
            }
            yield return null;
        }
    }

}
