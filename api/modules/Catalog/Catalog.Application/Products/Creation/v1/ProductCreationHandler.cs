﻿using FSH.WebApi.Catalog.Domain;
using Mapster;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FSH.WebApi.Catalog.Application.Products.Creation.v1;
public sealed class ProductCreationHandler(ILogger<ProductCreationHandler> logger) : IRequestHandler<ProductCreationCommand, ProductCreationResponse>
{
    public async Task<ProductCreationResponse> Handle(ProductCreationCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        await Task.FromResult(0).ConfigureAwait(false);
        var product = request.Adapt<Product>();
        logger.LogInformation("product created {ProductId}", product.Id);
        return new ProductCreationResponse(product.Id);
    }
}
