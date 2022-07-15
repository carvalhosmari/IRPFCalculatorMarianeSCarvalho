using IRPFCalculator.Presentation.ProgramFlow;
using IRPFCalculator.Presentation.ProgramFlow.Interface;
using IRPFCalculator.Services;
using IRPFCalculator.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection service = new();
ConfigureServices(service);


var serviceProvider = service.BuildServiceProvider();
var mainFlow = serviceProvider.GetService<IMainFlow>();

mainFlow.BeginApp();

static void ConfigureServices(ServiceCollection service)
{
    service
        .AddScoped<IMainFlow, MainFlow>()
        .AddScoped<ICalculator, Calculator>()
        .AddScoped<IDetailedCalculator, DetailedCalculator>();
}