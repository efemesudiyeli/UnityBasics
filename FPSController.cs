using TMPro;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private bool isFpsSetTo60 = true;
    [SerializeField] TextMeshProUGUI elapsedTimeText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isFpsSetTo60)
        {
            isFpsSetTo60 = true;

        }
        else if (Input.GetMouseButtonDown(0) && isFpsSetTo60)
        {
            isFpsSetTo60 = false;
        }


        if (isFpsSetTo60)
        {
            Application.targetFrameRate = 60;
        }
        else
        {
            Application.targetFrameRate = 10;
        }



        elapsedTimeText.text = (float.Parse(elapsedTimeText.text) + Time.deltaTime).ToString("0.00");

    }
}
