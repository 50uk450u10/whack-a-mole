using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeInterval : MonoBehaviour
{
    [SerializeField]
    [Range(0.1f, 20)]
    [Tooltip("Counted in Seconds")]
    private float timePerInterval = 1f;

    private float elapsed_Time = 0;

    [Serializable]
    public class TimerIntervalCompleted : UnityEvent { }
    public TimerIntervalCompleted onTimerComplete;

    private void Update()
    {
        elapsed_Time += Time.deltaTime;

        if (elapsed_Time >= timePerInterval)
        {
            elapsed_Time = 0;

            if (onTimerComplete != null)
            {
                onTimerComplete.Invoke();
            }
        }
    }

}
