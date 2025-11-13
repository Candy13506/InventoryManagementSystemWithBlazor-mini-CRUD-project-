using System;
using System.Collections.Generic;

namespace InventoryManagementApp.Database.AppDbContextModels;

public partial class Sale
{
    public int SaleId { get; set; }

    public int ProductId { get; set; }

    public int QuantitySold { get; set; }

    public decimal TotalPrice { get; set; }

    public DateTime? SaleDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Product Product { get; set; } = null!;
}
