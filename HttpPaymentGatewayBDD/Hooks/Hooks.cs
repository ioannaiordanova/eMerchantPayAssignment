﻿using Microsoft.Extensions.Configuration;
using TechTalk.SpecFlow;

namespace HttpPaymentGatewayBDD
{
    [Binding]
    class Hooks
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            ServiceDriver.Config = new ConfigurationBuilder().AddJsonFile("conf.json").Build();
        }
    }
}
