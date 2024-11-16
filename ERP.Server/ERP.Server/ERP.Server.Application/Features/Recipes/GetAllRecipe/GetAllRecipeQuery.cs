using ERP.Server.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace ERP.Server.Application.Features.Recipes.GetAllRecipe;

public sealed class GetAllRecipeQuery() : IRequest<Result<List<Recipe>>>;
