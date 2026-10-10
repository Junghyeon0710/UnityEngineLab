using UnityEngine;

// 버튼으로 스캔을 시작하고 남은 시간을 UI에 표시하는 문서용 예제다.
public class SurveyPanelController : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button scanActionButton;
    [SerializeField] private UnityEngine.UI.Image busyOverlayImage;
    [SerializeField, Min(0.1f)] private float scanDurationSeconds = 4.5f;

    private float remainingScanSeconds;
    private bool scanRunning;

    private void Awake()
    {
        if (scanActionButton == null || busyOverlayImage == null)
        {
            Debug.LogError("관측 패널의 버튼과 대기 이미지를 연결해 주세요.", this);
            enabled = false;
            return;
        }

        scanDurationSeconds = Mathf.Max(0.1f, scanDurationSeconds);
        busyOverlayImage.type = UnityEngine.UI.Image.Type.Filled;
        busyOverlayImage.fillMethod = UnityEngine.UI.Image.FillMethod.Radial360;
        busyOverlayImage.fillOrigin = (int)UnityEngine.UI.Image.Origin360.Top;
        busyOverlayImage.fillClockwise = true;
        busyOverlayImage.preserveAspect = true;
        busyOverlayImage.raycastTarget = false;
        busyOverlayImage.fillAmount = 0f;
        scanActionButton.interactable = true;
    }

    // Inspector의 Button > On Click()에 연결할 공개 메서드다.
    public void StartScan()
    {
        if (!isActiveAndEnabled || scanRunning)
            return;

        remainingScanSeconds = scanDurationSeconds;
        scanRunning = true;
        scanActionButton.interactable = false;
        busyOverlayImage.fillAmount = 1f;
        Debug.Log("관측 패널: 스캔을 시작합니다.", this);
    }

    private void Update()
    {
        if (!scanRunning)
            return;

        remainingScanSeconds = Mathf.Max(0f, remainingScanSeconds - Time.deltaTime);
        busyOverlayImage.fillAmount = remainingScanSeconds / scanDurationSeconds;

        if (remainingScanSeconds > 0f)
            return;

        scanRunning = false;
        scanActionButton.interactable = true;
        Debug.Log("관측 패널: 스캔이 완료되었습니다.", this);
    }
}
