using FollowUp_System;
using FollowUp_System.Data.IssueRepo;
using FollowUp_System.Data.IssueTypeRepo;
using FollowUp_System.Data.WorkPlaceRepo;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//string url = @"https://localhost:7264/api/";
string url = @"http://192.168.1.146:8080/api/"; // calling API in the company.

builder.Services.AddHttpClient<IIssueRepo, SqlIssueRepo>(client => client.BaseAddress = new Uri(url));
builder.Services.AddHttpClient<IIssueTypeRepo, SqlIssueTypeRepo>(client => client.BaseAddress = new Uri(url));
builder.Services.AddHttpClient<IWorkPlaceRepo, SqlWorkPlaceRepo>(client => client.BaseAddress = new Uri(url));

builder.Services.AddMudServices();
builder.Services.AddAntDesign();
await builder.Build().RunAsync();
