namespace Steam.WebApi.Controllers
{
    using System;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using Steam.Data.Api;
    using Steam.Models;

    [EnableCors("*", "*", "*")]
    public class PlayerController : ApiController
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerController(IPlayerRepository playerRepository)
        {
            if (playerRepository == null)
            {
                throw new ArgumentNullException("playerRepository");
            }

            _playerRepository = playerRepository;
        }
        
        public Player Get(string id)
        {
            return this._playerRepository.Get(id);
        }

        [HttpGet]
        [Route("api/PlayerStats/{id}/{appId}")]
        public PlayerStats PlayerStats(string id, int appId)
        {
            return this._playerRepository.GetPlayerStats(id, (Enums.SteamGames) appId);
        }
    }
}