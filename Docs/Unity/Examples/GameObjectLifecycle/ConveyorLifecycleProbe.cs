using UnityEngine;

// 생명주기 호출과 누적 횟수를 Console에서 관찰하는 예제다.
public class ConveyorLifecycleProbe : MonoBehaviour
{
    [SerializeField] private string stationCode = "SORT-07";
    [SerializeField] private bool logContinuousFrames = false;

    private int fixedSteps;
    private int renderSteps;
    private int lateSteps;

    private void Awake()
    {
        fixedSteps = 0;
        renderSteps = 0;
        lateSteps = 0;
        Trace("Awake");
    }

    private void OnEnable()
    {
        Trace("OnEnable");
    }

    private void Start()
    {
        Trace("Start");
    }

    private void FixedUpdate()
    {
        fixedSteps++;
        if (logContinuousFrames)
            Trace("FixedUpdate");
    }

    private void Update()
    {
        renderSteps++;
        if (logContinuousFrames)
            Trace("Update");
    }

    private void LateUpdate()
    {
        lateSteps++;
        if (logContinuousFrames)
            Trace("LateUpdate");
    }

    private void OnDisable()
    {
        Trace("OnDisable");
    }

    private void OnDestroy()
    {
        Trace("OnDestroy");
    }

    private void Trace(string callbackName)
    {
        Debug.Log($"[{stationCode}] {callbackName} | frame={Time.frameCount} | " +
                  $"fixed={fixedSteps}, update={renderSteps}, late={lateSteps}", this);
    }
}
