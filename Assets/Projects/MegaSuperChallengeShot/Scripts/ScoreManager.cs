using System;
using TMPro;
using UnityEngine;

namespace Projects.MegaSuperChallengeShot.Scripts
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreText;
        public static ScoreManager Instance { get; private set; }

        private int _score;
        public int Score => _score;

        private void Start()
        {
            _scoreText.text = $"Score: {0}";
        }
        
        [SerializeField] private AudioSource _audioSource;

        private void Awake()
        {
            Instance = this;
        }

        public void AddScore()
        {
            _score++;
            _scoreText.text = $"Score: {_score}";
            
            if (_audioSource != null)
            {
                _audioSource.pitch = 1f;
                _audioSource.Play();
            }
        }

        public void SetTextVisibility(bool visible)
        {
            if (_scoreText != null)
            {
                _scoreText.gameObject.SetActive(visible);
            }
        }
    }
}