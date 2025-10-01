
using System;
using UnityEngine;
using UnityEngine.UI;
public class ProgressBarUI : MonoBehaviour
{
    [SerializeField] private GameObject hasProgressGameObject;
    [SerializeField] private Image barImage;


    private IHasProgress hasProgress;
    private void Start()
    {
        hasProgress = hasProgressGameObject.GetComponent<IHasProgress>();
    if (hasProgress == null)
        {
            Debug.LogError("IHasProgress component not found on hasProgressGameObject.", hasProgressGameObject);
        }



        hasProgress.OnProgressChanged += HasProgress_OnProgressChanged;

        barImage.fillAmount = 0f;

        hide();
    }
    private void HasProgress_OnProgressChanged(object sender, IHasProgress.OnProgressChangedEventArgs e)
    {
        barImage.fillAmount = e.progressNormalized;

        if (e.progressNormalized == 0f|| e.progressNormalized == 1f)
        {
            hide();
        } else
        {
            show();
        }
    }

    private void show()
    {
        gameObject.SetActive(true);
    }
    private void hide()
    {
        gameObject.SetActive(false);
    }
}
