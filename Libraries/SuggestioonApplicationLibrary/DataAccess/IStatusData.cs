namespace SuggestioonApplicationLibrary.DataAccess;

    public interface IStatusData
    {
        Task CreateStatusAsync(StatusModel status);
        Task<List<StatusModel>> GetStatusesAsync();
    }

