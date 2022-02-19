namespace SuggestioonApplicationLibrary.DataAccess;

    public interface ISuggestionData
    {
        Task CreateSuggestionAsync(SuggestionModel suggestion);
        Task<List<SuggestionModel>> GetApprovedSuggestionsAsync();
        Task<SuggestionModel> GetSuggestionAsync(string id);
        Task<List<SuggestionModel>> GetSuggestionsAsync();
        Task<List<SuggestionModel>> GetSuggestionsWaitingForApprovalAsync();
        Task<List<SuggestionModel>> GetUsersSuggestionsAsync(string userId);
        Task UpdateSuggestionAsync(SuggestionModel suggestion);
        Task UpvoteSugesstionAsync(string suggestionId, string userId);
   }

