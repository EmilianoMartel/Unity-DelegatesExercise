using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateProvider : MonoBehaviour
{
    [SerializeField] private DelegateConsumer _consumer;

    [ContextMenu("Test logic consumption")]
    private void TestLogicConsumption()
    {
        //TODO: Add the parameter here to handle the secret.
        //You can log the value to test it :)
        _consumer.ConsumeDelegate(WriteData);
    }

    private void WriteData(string secret)
    {
        Debug.Log(secret);
    }
}