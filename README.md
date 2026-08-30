[![](https://img.shields.io/nuget/v/soenneker.clay.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.clay.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.clay.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.clay.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.clay.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.clay.openapiclient/actions/workflows/codeql.yml)
[![](https://img.shields.io/nuget/dt/soenneker.clay.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.clay.openapiclient/)

# Soenneker.Clay.OpenApiClient

A Kiota-generated .NET client for Clay's public API.

## Installation

```bash
dotnet add package Soenneker.Clay.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Clay.OpenApiClient;
using Soenneker.Clay.OpenApiClient.Models;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("clay-api-key", "your-api-key");

var adapter = new HttpClientRequestAdapter(new AnonymousAuthenticationProvider(), httpClient: httpClient);
var client = new ClayOpenApiClient(adapter);

GetPublicApiMe200Response? response = await client.Me.GetAsync();
```

Keep the `HttpClient` long-lived. For dependency injection, configuration-based authentication, and managed client reuse, use `Soenneker.Clay.OpenApiClientUtil`.

This package is generated from Clay's OpenAPI document. Request-builder and model names can change when that document changes, so review package upgrades when your code depends on generated shapes.
