using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(MoveCoroutine());
    }

    private IEnumerator MoveCoroutine()
    {
        const float secs = 3f;
        const float distance = 2f;

        Vector3 from = this.transform.position;
        Vector3 to = from - (this.transform.forward * distance);

        float t = 0f;
        bool d = true;
        while (true) {
            t += Time.deltaTime / secs;

            this.transform.position = Vector3.Lerp(from, to, d ? t : 1 - t);

            if (t > 1f) {
                t -= 1f;
                d = !d;
            }

            yield return null;
        }
    }
}
