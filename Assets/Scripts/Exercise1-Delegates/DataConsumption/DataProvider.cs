using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate int GetAgeDelegate(int personId);
public delegate string GetNameDelegate(int personId);
public delegate short GetPostalCodeDelegate(int personId);
public class DataProvider : MonoBehaviour
{
    [SerializeField] private DataConsumer dataConsumer;

    [SerializeField] private int _genericAge = 18;
    [SerializeField] private string _genericName = "name";
    [SerializeField] private short _genericPostalCode = 1408;

    //Delegates
    public GetAgeDelegate getAgeDelegate;
    public GetNameDelegate getNameDelegate;
    public GetPostalCodeDelegate getPostalCodeDelegate;


    private int GetAge(int personId)
    {
        return _genericAge;
    }

    private string GetName(int personId)
    {
        return _genericName;
    }

    private short GetPostalCode(int personId)
    {
        return _genericPostalCode;
    }

    [ContextMenu("Test report")]
    private void TestReport()
    {
        dataConsumer.ReportPersonData(0, GetName, GetAge, GetPostalCode);
    }
}