using FirstApiProject.Domain.Entites.Abstracts;

namespace FirstApiProject.Domain.Entites.Concretes;

public class Shipper:BaseEntity
{
    public string CompanyName { get; set; }=string.Empty;
    public string? Phone { get; set; }

}
