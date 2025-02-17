using FirstApiProject.Domain.Entites.Abstracts;

namespace FirstApiProject.Domain.Entites.Concretes;

public class Category:BaseEntity
{ 
    public string Name { get; set; }=string.Empty;
    public string? Description { get; set; }
    public byte[]? Image { get; set; }
}
