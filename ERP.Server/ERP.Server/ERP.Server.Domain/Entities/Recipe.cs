﻿using ERP.Server.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Server.Domain.Entities;

public sealed class Recipe : Entity
{
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
    public List<RecipeDetail>? Details { get; set; }
}
