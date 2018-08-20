using System;
using System.Configuration;

namespace WarframeWorldStateApi.WarframeEvents
{
    /// <summary>
    /// Base class for all Warframe Events to extend.
    /// </summary>
    public abstract class WarframeEvent
    {
        public string GUID { get; private set; }
        public string DestinationName { get; private set; }
        public DateTime StartTime { get; private set; }
        private int _minutesUntilEventIsNowNew = int.Parse(ConfigurationManager.AppSettings["MinutesUntilEventIsNowNew"]);

        public WarframeEvent(string guid, string destinationName, DateTime startTime)
        {
            GUID = guid;
            DestinationName = destinationName;
            StartTime = startTime;
        }

        public abstract bool IsExpired();

        protected void SetDestinationNode(string destination)
        {
            DestinationName = destination;
        }

        /// <summary>
        /// Check if the event started recently
        /// </summary>
        public bool IsNew()
        {
            var timeEventIsNotNew = StartTime.AddMinutes(_minutesUntilEventIsNowNew);
            return ((DateTime.Now >= StartTime) && (DateTime.Now < timeEventIsNotNew));
        }
    }
}
