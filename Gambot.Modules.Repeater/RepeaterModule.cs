﻿using Gambot.Core;

namespace Gambot.Modules.Repeater
{
    public class RepeaterModule : AbstractModule
    {
        public RepeaterModule()
        {
            var chainStore = new MessageChainStore();

            MessageListeners.Add(new MessageChainListener(chainStore));
            MessageReactors.Add(new MessageChainReactor(chainStore));
        }
    }
}
