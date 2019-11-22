using System;

namespace MicroQuiz.Services.Operations.Core.Extensions
{
    public static class MayBeMonade
    {
        public static TInput ThrowIfNull<TInput>(this TInput param, string paramName = null)
            where TInput : class
        {
            if (param == null)
                throw new ArgumentNullException(paramName ?? "param");

            return param;
        }
    }
}
