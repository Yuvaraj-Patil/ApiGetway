# Integration of Ocelot API Gateway with Consul hosting for efficient microservice routing and dynamic service discovery.

⦁ Hashicorp Consul can be downloaded from the link below based on different applicable operating systems.
  [Hashicorp Consul](https://developer.hashicorp.com/consul/install)
  
⦁ Once downloaded, it can run using the command below, with –dev/-server for dev or server mode.
  ```powershell 
  consul agent -dev
  ```

⦁ Once up it can be viewed in URL.[localhost](https://localhost:8500/ui/dc1/services)

⦁ Add Consul Client Library from Nuget package to your application then configure and Inject it from Program file.
  [ConsulRegistrationService](https://github.com/Yuvaraj-Patil/ApiGetway/blob/main/ProductApi/ProductAPI/ProductAPI/ConsulRegistrationService.cs)
  
⦁ Once Configuration is done and application is up we can see the API Registered in Consul.

⦁ Now we need to configure the Ocelot Getway using the .json file [ocelot.json](https://github.com/Yuvaraj-Patil/ApiGetway/blob/main/ApiGateway/APIGateway/APIGateway/ocelot.json) where we defined the mapping between gateway and APIs.

⦁ Now in [Program.cs](https://github.com/Yuvaraj-Patil/ApiGetway/blob/main/ApiGateway/APIGateway/APIGateway/Program.cs) file, we need to add the below code.

  builder.Configuration.AddJsonFile("ocelot.json", reloadOnChange: true, optional: false);
  builder.Services.AddOcelot(builder.Configuration).AddConsul();
  
  await app.UseOcelot();

⦁ Once the API Gateway is successfully configured and running, you can utilize tools like Postman to test the microservices via the gateway. The integration with Consul's dynamic service discovery ensures that any updates, such as new endpoints or changes in port numbers, are automatically handled. This eliminates the need for manual modifications in the gateway configuration, making the system both flexible and efficient.
  

   


