namespace SuggestioonApplicationLibrary.DataAccess;

    public interface IUserData
    {
        Task CreateUserAsync(UserModel user);
        Task<UserModel> GetUserByIdAsync(string id);
        Task<UserModel> GetUserFromAuthenticationAsync(string objectId);
        Task<List<UserModel>> GetUsersAsync();
        Task UpdateUserAsync(UserModel user);
    }
