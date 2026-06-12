namespace FlappyBirdClone
{
    using UnityEngine;

    [RequireComponent(typeof(SpriteRenderer))]
    public class BackgroundRandomizer : MonoBehaviour
    {
        [SerializeField] private Sprite[] backgrounds;

        private void Start()
        {
            if (backgrounds != null && backgrounds.Length > 0)
            {
                var sr = GetComponent<SpriteRenderer>();
                if (sr != null)
                {
                    int idx = Random.Range(0, backgrounds.Length);
                    sr.sprite = backgrounds[idx];
                }
            }
        }
    }
}
