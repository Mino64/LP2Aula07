using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(typeof(EventMaster))]
    public class ConsoleMessages : MonoBehaviour
    {
        private EventMaster em;

        private void Awake()
        {
            em = GetComponent<EventMaster>();
        }

        private void OnEnable()
    {
        em.KeyPress += PrintOnConsole;
    }
    private void OnDisable()
    {
        em.KeyPress -= PrintOnConsole;
    }

    private void PrintOnConsole(char key)
    {
        Debug.Log(key);
    }
    }
