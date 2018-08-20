﻿namespace WarframeWorldStateApi.WarframeEvents
{
    //A container for all related information regarding a mission
    public class MissionInfo
    {
        public string Faction { get; private set; }
        public string MissionType { get; private set; }
        public int Credits { get; private set; }
        public string Reward { get; private set; }
        public int RewardQuantity { get; private set; }
        public int MinimumLevel { get; private set; }
        public int MaximumLevel { get; private set; }
        public bool RequiresArchwing { get; private set; }

        public MissionInfo(string factionName, string missionType, int credits, string reward, int rewardQuantity, int minLevel, int maxLevel, bool requiresArchwing)
        {
            //This is the mission information of the faction you are opposing
            Faction = Properties.Faction.GetName(factionName);
            MissionType = Properties.MissionType.GetName(missionType);
            Credits = credits;
            Reward = reward;
            RewardQuantity = rewardQuantity;
            MinimumLevel = minLevel;
            MaximumLevel = maxLevel;
            RequiresArchwing = requiresArchwing;
        }

        public MissionInfo(MissionInfo info)
        {
            Faction = info.Faction;
            MissionType = info.MissionType;
            Credits = info.Credits;
            Reward = info.Reward;
            RewardQuantity = info.RewardQuantity;
            MinimumLevel = info.MinimumLevel;
            MaximumLevel = info.MaximumLevel;
            RequiresArchwing = info.RequiresArchwing;
        }
    }
}
