using UnityEngine;

namespace FlappyBirdClone
{
    public class RandomYOffset : MonoBehaviour
    {
        public float minY = -2.5f;
        public float maxY = 2.5f;
        public float basePathY = 0f;

        public void RandomizeY()
        {
            Vector3 pos = transform.position;
            pos.y = basePathY + Random.Range(minY, maxY);
            transform.position = pos;
        }

        private void Update()
        {
            RandomizeY();
        }
    }
}
