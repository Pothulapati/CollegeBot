using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Ai.LUIS;
using Microsoft.Bot.Builder.Core.Extensions;
using Microsoft.Bot.Schema;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CollegeBot
{
    public class CollegeBot : IBot
    {
        public async Task OnTurn(ITurnContext TurnContext)
        {
            await TurnContext.SendActivity("Hey!");
        }
    }
}
