﻿global using System.Collections.Immutable;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using ChatGPT.Business.Models;
global using ChatGPT.Presentation;
global using ChatGPT.Services;
global using ApplicationExecutionState = Windows.ApplicationModel.Activation.ApplicationExecutionState;
global using Color = Windows.UI.Color;
global using OpenAI;
global using OpenAI.Interfaces;
global using OpenAI.Managers;