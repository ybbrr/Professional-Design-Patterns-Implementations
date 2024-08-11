namespace DesignPatterns.Builder
{
    /*
      * New customer e-ticaret sitesinden ilk kez ürün alacak kişi olsun. 
        Bu kişinin aklını çelmek için bazı ürünler sadece ona indirimli gösterilecektir.
        Old customer sınıfındaki müşteriler o ürümleri indirimli görmeyecektir.
    */
    public class OldCustomerProductBuilder : ProductBuilder
    {
        /*Bu builder gerekli işini yatıktan sonra bir ürün döndürmelidir.*/
        ProductViewModel model = new ProductViewModel();
        public override void GetProductData()
        {
            /*Burada veri tabanına bağlanan ve veri çeken bir kod olduğunu farzedin*/
            model.Id = 1;
            model.CategoryName = "OEM";
            model.ProductName = "CPU";
            model.UnitPrice = 200;
        }
        public override void ApplyDiscount()
        {
            /*
              * Builder Design Pattern ile işlemler sıralı yapılır. Nesneler ise sıralı oluşturulur.
                Önce diğer metodun, GetProductData()'nın çalışması sayesinde aşağıdaki gibi
                --> model.DiscountedPrice = model.UnitPrice * 0.9;
                yazılabildi.
            */
            model.DiscountedPrice = model.UnitPrice;
            model.DiscountApplied = false;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }
    }


}
