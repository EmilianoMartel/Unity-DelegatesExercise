
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateConsumer : MonoBehaviour
{
    [SerializeField] private string _secretData = "this is a secret that I'll only share through delegates >:)";

    public void ConsumeDelegate(Action<string> giveSecret)
    {
        giveSecret?.Invoke(_secretData);
        //TODO: Receive a delegate as parameter on this method and consume it.
        //GiveSecret(secretData);
        //TODO: Try your logic giving it a null and see if it shows a NullPointerException :)
    }
}
