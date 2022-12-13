using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 이것을 상속받은 오브젝트만 풀링 가능
public abstract class PoolableMono : MonoBehaviour
{
    // 풀링 리스트에서 꺼낼 때 수치같은 것들 리셋
    public abstract void Reset();
}
