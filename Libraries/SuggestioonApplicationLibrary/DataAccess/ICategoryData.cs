namespace SuggestioonApplicationLibrary.DataAccess;

public interface ICategoryData
{
    Task CreateCategoryAsync(CategoryModel category);
    Task<List<CategoryModel>> GetCategoriesAsync();
}