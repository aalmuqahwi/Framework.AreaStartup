# Area Startup

A simple project to make each area in an asp.net mvc core application to have its own startup file.

I'm aware that the avaliable IoC containers have the ability to automatically register all dependencies in the application, but I wanted to build somthing that can use the default IoC container and learn new things :) 

Other reason is that I'm bulding another project which is an in memory event bus inspired by the one in [eShopOnContainers](https://github.com/dotnet-architecture/eShopOnContainers), that let me publish events from one area to another. 

## Example

Lets say that we have one area called `Profile`. Inside it, add new class called `AreaStartup` and make it implement `IAreaStartup` interface like the following:

```csharp
public class AreaStartup : IAreaStartup
{   
    public void ConfigureServices(IServiceCollection services)
    {
        //add any dependencies to this area.
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {

    }
}
```

In `Startup` class add the following:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    //other services.

    //add area startup.
    services.AddAreaStartup<Startup>();
}

public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    //other configurations...

    app.UseAreaStartup();

}
```
