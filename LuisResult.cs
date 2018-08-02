using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeBot
{
    public class LuisResult
    {
        public LuisResult()
        {

        }
        public Intent topScoringIntent { get; set; }

        public Intent[] intents { get; set; }

        public Entity[] entities { get; set; }
    }

    public class Intent
    {
        public string intent { get; set; }
        public float score { get; set; }

    }

    public class Entity
    {
        public string entity;
        public string type;
        public int startIndex;
        public int endIndex;
        public float score;
    }
}
