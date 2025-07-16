using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayButtonUI : MonoBehaviour
{
    public Button playButton;
    public Slider loadingSlider;
    public Text progressText;
    public AudioSource audioSource;

    [SerializeField] private Transform playButtonTransform; 

    private void Start()
    {
        Debug.Log("Check Commit");

        loadingSlider.value = 0f;
        progressText.text = "Ready";
        playButton.onClick.AddListener(OnPlayButtonClicked);
    }

    void OnPlayButtonClicked()
    {
        StartCoroutine(AnimatePlayButton()); 

        playButton.interactable = false;

        if (audioSource != null)
            audioSource.Play();

        StartCoroutine(LoadProgress());
    }
    private IEnumerator AnimatePlayButton()
    {
        Vector3 originalScale = playButtonTransform.localScale;
        Vector3 targetScale = originalScale * 1.1f;

        float time = 0f;
        while (time < 0.1f)
        {
            playButtonTransform.localScale = Vector3.Lerp(originalScale, targetScale, time / 0.1f);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0f;
        while (time < 0.1f)
        {
            playButtonTransform.localScale = Vector3.Lerp(targetScale, originalScale, time / 0.1f);
            time += Time.deltaTime;
            yield return null;
        }

        playButtonTransform.localScale = originalScale;
    }


    IEnumerator LoadProgress()
    {
        float duration = 3f;
        float timer = 0f;

        while (timer < duration)
        {
            timer += Time.deltaTime;
            float progress = Mathf.Clamp01(timer / duration);
            loadingSlider.value = progress;
            progressText.text = $"Loading... {(int)(progress * 100)}%";
            yield return null;
        }

        loadingSlider.value = 1f;
        progressText.text = "Done";
        playButton.interactable = true;
    }
}
