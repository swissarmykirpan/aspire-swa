var builder = DistributedApplication.CreateBuilder(args);

builder.AddNpmApp("swa", "../../app")
    .WithHttpEndpoint(targetPort: 4280)
    .WithExternalHttpEndpoints();

builder.AddNpmApp("http-server", "../../app", "http")
    .WithHttpEndpoint(targetPort: 8080)
    .WithExternalHttpEndpoints();

builder.Build().Run();
