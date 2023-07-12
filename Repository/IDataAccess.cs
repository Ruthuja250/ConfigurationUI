using ConfigurationUI.Models;
namespace ConfigurationUI.Repository
{
    public interface IDataAccess
    {
        // loading category and subcategory list
        List<ProductCategory>GetProductCategories(); 
        ProductCategory GetProductCategory(int id);
        List <Product> GetProducts(string category , string subcategory,int count);
        Product GetProduct(int id);
        bool InsertCartItem(int userid, int productId);   

    }
}