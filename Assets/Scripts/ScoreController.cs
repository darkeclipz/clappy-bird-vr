using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(AudioSource))]
    [RequireComponent(typeof(TextMesh))]
    public class ScoreController : MonoBehaviour
    {
        private TextMesh text;
        public TextMesh highscoreText;
        private int highscore;
        public bool incrementScore;
        public bool resetScore;

        public int score = 0;
        public int updateScore = 100;

        public AudioClip resetScoreAudioClip;
        public AudioClip successAudioClip;
        private AudioSource @as;

        void Start()
        {
            text = GetComponent<TextMesh>();
            @as = GetComponent<AudioSource>();
            highscoreText.text = "";
        }

        void Update()
        {
            if(incrementScore)
            {
                score += updateScore;

                if (score > highscore)
                {
                    highscore = score;
                    highscoreText.text = "Highscore: " + highscore.ToString();
                }

                incrementScore = false;
                @as.PlayOneShot(successAudioClip);
            }

            if(resetScore)
            {
                score = 0;
                resetScore = false;
                @as.PlayOneShot(resetScoreAudioClip);
            }

            text.text = score.ToString();
        }
    }
}
