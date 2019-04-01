# Area Startup

A simple project to make each area in an asp.net mvc core application to have its own startup file.

I'm aware that the avaliable IoC containers have the ability to automatically register all dependencies in the application, but I wanted to build somthing that can use the default IoC container and learn new things :) 

Other reason is that I'm bulding another project which is an in memory event bus inspired by the one in [eShopOnContainers](https://github.com/dotnet-architecture/eShopOnContainers), that let me publish events from one area to another. 


## Todo list
- [ ] Create base interface that each area need to implement.
- [ ] Create initializer that read all interfaces and run the code inside them.
- [ ] Create nuget package.




