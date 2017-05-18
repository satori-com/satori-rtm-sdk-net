﻿using System;
using System.Diagnostics;
using System.Threading;
using Satori.Rtm.Client;

namespace Authentication
{
    class App
    {
        const string endpoint = "YOUR_ENDPOINT";
        const string appkey = "YOUR_APPKEY";
        const string role = "YOUR_ROLE";
        const string roleSecretKey = "YOUR_ROLE_SECRET_KEY";

        static void Main()
        {
            // Log messages from SDK to the console
            Trace.Listeners.Add(new ConsoleTraceListener());

            // This event will be signalled when the client is connected to RTM
            var connectedEvent = new ManualResetEvent(initialState: false);

            IRtmClient client = new RtmClientBuilder(endpoint, appkey)
                .SetRoleSecretAuthenticator(role, roleSecretKey)
                .Build();

            client.OnEnterConnected += cn => 
            {
                Console.WriteLine("Successfully connected and authenticated");
                connectedEvent.Set();
            };

            client.OnError += ex => 
                Console.Error.WriteLine("Error occurred: " + ex.Message);

            client.Start();

            connectedEvent.WaitOne(TimeSpan.FromSeconds(15));

            // Dispose the client before exiting the app
            client.Dispose().Wait();
        }
    }
}