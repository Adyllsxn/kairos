#region </System>
    global using System.Linq.Expressions;
#endregion

#region </Microsoft>
    global using Microsoft.EntityFrameworkCore;
    global using Microsoft.EntityFrameworkCore.Metadata.Builders;
    global using Microsoft.Extensions.DependencyInjection;
    global using Microsoft.Extensions.Configuration;
#endregion

#region </Domain>
    global using Kairos.Domain.Entities;
    global using Kairos.Domain.Abstractions.Interfaces;
    global using Kairos.Domain.Abstractions.Response;
#endregion

#region </Infrastructure>
    global using Kairos.Infrastructure.Context;
    global using Kairos.Infrastructure.Abstractions.DI;
    global using Kairos.Infrastructure.Repositories;
#endregion