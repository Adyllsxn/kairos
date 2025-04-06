#region </System>
    global using System.ComponentModel.DataAnnotations;
#endregion

#region </Microsoft>
    global using Microsoft.Extensions.DependencyInjection;
#endregion

#region </Infrastructure>
    global using Kairos.Domain.Abstractions.Interfaces;
#endregion

#region </Application>
    global using Kairos.Application.Abstractions.Interfaces;
    global using Kairos.Application.Abstractions.DI.Architecture;
    global using Kairos.Application.Services;
    global using Kairos.Application.UseCases.TipoEvento.GetAllUsecase;
    global using Kairos.Application.UseCases.TipoEvento.SearchUseCase;
    global using Kairos.Application.UseCases.TipoEvento.GetByIdUseCase;
    global using Kairos.Application.UseCases.TipoEvento.CreateUseCase;
    global using Kairos.Application.UseCases.TipoEvento.DeleteUseCase;
    global using Kairos.Application.UseCases.TipoEvento.UpdateUseCase;
#endregion

#region </Domain>
    global using Kairos.Domain.Entities;
    global using Kairos.Domain.Abstractions.Response;
#endregion