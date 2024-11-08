namespace Catalog.API.Products.CreateProdcut;

public record CreateProductCommand(
    string Name,
    List<string> Category,
    string Description,
    string ImageFile,
    decimal Price
 );

public record CreateProducResult(Guid Id);
public class CreateProductHandler
{
}
