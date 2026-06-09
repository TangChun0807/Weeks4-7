using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public Slider ScoreSlider;
    public TMP_Text currentScoreText;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {







    }





    public void OnSliderChange(float scoreValue)
        {
        //currentScoreText.text = "Score: " + ScoreSlider.value;


        // Debug.Log(ScoreSlider.value);

        currentScoreText.text = "Score: " + scoreValue;

        Debug.Log(currentScoreText.text);

        }
  }

