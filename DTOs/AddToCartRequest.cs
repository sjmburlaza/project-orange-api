namespace ProjectOrangeApi.DTOs;

public class AddToCartRequest
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public List<AddonDto> Addons { get; set; } = [];
}
