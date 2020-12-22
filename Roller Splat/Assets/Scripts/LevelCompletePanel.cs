using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LevelCompletePanel : MonoBehaviour
{
    public static LevelCompletePanel instance;
    public Image Texts;
    public Image Splats;
    public ParticleSystem ConfettiLeft;
    public ParticleSystem ConfettiRight;


    public void Start()
    {
        instance = this;
    }
    public IEnumerator Move()
    {
        Texts.transform.DOLocalMoveY(186.5003f, 0.7f);
        yield return new WaitForSeconds(0.8f);
        Splats.rectTransform.localPosition = new Vector3(0f, 529.5f);

    }

    public void PlayConfetti()
    {
        ConfettiLeft.Play();
        ConfettiRight.Play();
    }

    public void RestartLevelCompPanel()
    {
        Texts.rectTransform.localPosition = new Vector3(0f, 678.5002f);
        Splats.rectTransform.localPosition = new Vector3(0f, 1022.5f);

    }


}
