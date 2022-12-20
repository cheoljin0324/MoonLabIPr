using UnityEngine;
using System.Collections;

public class DestroyEffect : PoolableMono
{
    public override void Reset()
    {
        // 이펙트나오는 시간으로 수정?
        Invoke("Push", 2f);
    }

    private void Push()
    {
        PoolManager.Instance.Push(this);
    }
}
