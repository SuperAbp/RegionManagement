﻿using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SuperAbp.RegionManagement.HttpApi.Client.ConsoleTestApp;

public class ClientDemoService : ITransientDependency
{
    public ClientDemoService()
    {
    }

    public async Task RunAsync()
    {
        //var output = await _profileAppService.GetAsync();
        //Console.WriteLine($"UserName : {output.UserName}");
        //Console.WriteLine($"Email    : {output.Email}");
        //Console.WriteLine($"Name     : {output.Name}");
        //Console.WriteLine($"Surname  : {output.Surname}");
    }
}