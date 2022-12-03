using ChessData.Library.DTOs.APIs.Chesscom.Clubs;
using ChessData.Library.DTOs.APIs.Chesscom.Leaderboards;
using ChessData.Library.DTOs.APIs.Chesscom.Players;
using ChessData.Library.DTOs.APIs.Chesscom.Puzzles;
using ChessData.Library.DTOs.APIs.Chesscom.Streamers;
using ChessData.Library.DTOs.APIs.Chesscom.Tournaments;
using ChessData.Library.Models;

namespace ChessData.Library.Interfaces
{
    public interface IChesscomApi
    {
        #region Players
        Task<ApiResponse<GetPlayerProfileDataResponse?>> GetPlayerProfileData(string playerName);
        Task<ApiResponse<GetTitledPlayersResponse?>> GetTitledPlayers(string title);
        Task<ApiResponse<GetPlayerStatsDataResponse?>> GetPlayerStatsData(string playerName);
        Task<ApiResponse<GetPlayerTournamentsResponse?>> GetPlayerTournaments(string playerName);
        Task<ApiResponse<GetPlayerDailyGamesResponse?>> GetPlayerDailyGames(string playerName);
        Task<ApiResponse<GetPlayerMonthlyArchivesResponse?>> GetPlayerMonthlyGameArchives(string playerName, string year, string month);
        Task<ApiResponse<GetPlayerClubsResponse?>> GetPlayerClubs(string playerName);

        #endregion

        #region Clubs
        Task<ApiResponse<GetClubDetailsResponse?>> GetClubDetails(string clubName);

        Task<ApiResponse<GetClubMembersResponse?>> GetClubMembers(string clubName);

        #endregion

        #region Tournaments
        Task<ApiResponse<GetTournamentResponse?>> GetTournament(string tournamentName);
        Task<ApiResponse<GetTournamentRoundResponse?>> GetTournamentRound(string tournamentName, int round);
        Task<ApiResponse<GetTournamentRoundGroupResponse?>> GetTournamentRoundGroup(string tournamentName, int round, int group);

        #endregion

        #region Team matches

        #endregion

        #region Countries

        #endregion

        #region Daily puzzles

        Task<ApiResponse<GetDailyPuzzleResponse?>> GetDailyPuzzle();
        Task<ApiResponse<GetRandomPuzzleResponse?>> GetRandomPuzzle();

        #endregion

        #region Streamers

        Task<ApiResponse<GetStreamersResponse?>> GetStreamers();

        #endregion

        #region Leaderboards

        Task<ApiResponse<GetLeaderboardsResponse?>> GetLeaderboards();

        #endregion
    }
}
