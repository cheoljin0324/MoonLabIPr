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

    public void UseSkill(Skill skill)
    {
        _skillCanvas.enabled = true;
        StartCoroutine(UseSkillCoroutine(skill));
    }

    private IEnumerator UseSkillCoroutine(Skill skill)
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
                    switch (skill)
                    {
                        case Skill.ATK:
                            foreach (var enemyCollider in enemyColliders)
                            {
                                enemyCollider.GetComponent<MeshRenderer>().material.color = new Color(enemyCollider.GetComponent<MeshRenderer>().material.color.r - 0.2f, enemyCollider.GetComponent<MeshRenderer>().material.color.g, enemyCollider.GetComponent<MeshRenderer>().material.color.b, 1f);
                            }
                            break;
                        case Skill.DEBUFF:
                            foreach (var enemyCollider in enemyColliders)
                            {
                                enemyCollider.GetComponent<MeshRenderer>().material.color = Color.black;
                                //enemyCollider.GetComponent<Enemy>().atkSpeed = 2f;
                            }
                            _skillCanvas.enabled = false;
                            yield return new WaitForSeconds(3f);
                            foreach (var enemyCollider in enemyColliders)
                            {
                                enemyCollider.GetComponent<MeshRenderer>().material.color = Color.red;
                                //enemyCollider.GetComponent<Enemy>().atkSpeed = 1.0f;
                            }
                            break;
                        case Skill.CC:
                            foreach (var enemyCollider in enemyColliders)
                            {
                                enemyCollider.GetComponent<MeshRenderer>().material.color = Color.gray;
                                enemyCollider.GetComponent<Enemy>().canMove = false;
                            }
                            _skillCanvas.enabled = false;
                            yield return new WaitForSeconds(1f);
                            foreach (var enemyCollider in enemyColliders)
                            {
                                enemyCollider.GetComponent<MeshRenderer>().material.color = Color.red;
                                enemyCollider.GetComponent<Enemy>().canMove = true;
                            }
                            break;
                        default:
                            break;
                    }
                }
                _skillCanvas.enabled = false;
                break;
            }
            yield return null;
        }
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
