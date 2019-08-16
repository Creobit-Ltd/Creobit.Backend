﻿#if CREOBIT_BACKEND_STEAM && UNITY_STANDALONE
namespace Creobit.Backend
{
    public interface ISteamAuth : IAuth
    {
        #region ISteamAuth

        uint AppId
        {
            get;
        }

        string CreateAuthSessionTicket();

        void DestroyAuthSessionTicket(string authSessionTicket);

        #endregion
    }
}
#endif
