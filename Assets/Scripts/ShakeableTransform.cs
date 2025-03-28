using UnityEngine;

public class ShakeableTransform : MonoBehaviour
{
    [SerializeField]
    bool shake = false;
    float frequency = 25;
    private void Update()
    {
        if (shake)
        {
            transform.localPosition = new Vector3(
Mathf.PerlinNoise(0, Time.time * frequency) * 2 - 1,
Mathf.PerlinNoise(1, Time.time * frequency) * 2 - 1,
Mathf.PerlinNoise(2, Time.time * frequency) * 2 - 1
) * 0.5f;
        }
    }

}
