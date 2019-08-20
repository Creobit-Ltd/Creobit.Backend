﻿using System;

namespace Creobit.Backend
{
    public interface IUser
    {
        #region IUser

        string Name
        {
            get;
        }

        void Refresh(Action onComplete, Action onFailure);

        void SetName(string name, Action onComplete, Action onFailure);

        #endregion
    }
}
