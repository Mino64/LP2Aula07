using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(typeof(EventMaster))]
    public class ConsoleMessages : MonoBehaviour
    {
    public void PrintOnConsole(char key)
    {
        Debug.Log(key);
    }

    }
