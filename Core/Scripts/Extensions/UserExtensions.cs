﻿using System;
using System.Threading.Tasks;

namespace Creobit.Backend
{
    public static class UserExtensions
    {
        #region UserExtensions

        private const int MillisecondsDelay = 10;

        public static async Task SetNameAsync(this IUser self, string name)
        {
            var invokeResult = default(bool?);

            self.SetName(name,
                () => invokeResult = true,
                () => invokeResult = false);

            while (!invokeResult.HasValue)
            {
                await Task.Delay(MillisecondsDelay);
            }

            if (!invokeResult.Value)
            {
                throw new InvalidOperationException();
            }
        }

        #endregion
    }
}
