# Integration of Ocelot API Gateway with Consul hosting for efficient microservice routing and dynamic service discovery.

⦁ Hashicorp Consul can be dowloaded from below link based upon different applicable operating System.
  (https://developer.hashicorp.com/consul/install)
⦁ Once downloaded it can run using below command, with –dev/-server for dev or server mode.
  ```powershell 
  consul agent -dev
  ```
⦁ Once up it can be viewed in url.(https://localhost:8500/ui/dc1/services)
⦁ Add Consul Client Library from nuget package to your application then configure and Inject it from Program file.
  [ConsulRegistrationService](https://github.com/Yuvaraj-Patil/ApiGetway/blob/main/ProductApi/ProductAPI/ProductAPI/ConsulRegistrationService.cs)
⦁ Once Configuration is done and application is up we can see the API Registered in Consul.
⦁ Now we need to configure the Ocelot Getway using .json file [ocelot.json](https://github.com/Yuvaraj-Patil/ApiGetway/blob/main/ApiGateway/APIGateway/APIGateway/ocelot.json) where we defined the mapping between gateway and APIs.
⦁ Now in Program.cs file we need to add below code.
  builder.Configuration.AddJsonFile("ocelot.json", reloadOnChange: true, optional: false);
  builder.Services.AddOcelot(builder.Configuration).AddConsul();

  await app.UseOcelot();
  

   


