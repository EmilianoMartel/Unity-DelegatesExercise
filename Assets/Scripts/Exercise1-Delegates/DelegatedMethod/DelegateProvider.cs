using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void GiveSecret(string secretData);
public class DelegateProvider : MonoBehaviour
{
    [SerializeField] private DelegateConsumer _consumer;
    public GiveSecret giveSecret;

    private void OnEnable()
    {
        giveSecret = WriteData;
    }

    private void OnDisable()
    {
        giveSecret = null;
    }

    [ContextMenu("Test logic consumption")]
    private void TestLogicConsumption()
    {
        //TODO: Add the parameter here to handle the secret.
        //You can log the value to test it :)
        _consumer.ConsumeDelegate(giveSecret);
    }

    private void WriteData(string secret)
    {
        Debug.Log(secret);
    }
}
