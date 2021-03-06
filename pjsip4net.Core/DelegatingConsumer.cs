using System;
using Magnum.Pipeline;
using pjsip4net.Core.Utils;

namespace pjsip4net.Core
{
    public class DelegatingConsumer<T> : IConsumer<T> where T : class
    {
        private readonly Action<T> _action;

        public DelegatingConsumer(Action<T> action)
        {
            Helper.GuardNotNull(action);
            _action = action;
        }

        #region Implementation of IConsumer<T>

        public void Consume(T message)
        {
            _action(message);
        }

        #endregion
    }
}