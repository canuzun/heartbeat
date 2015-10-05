﻿using System.Collections.Generic;
using Heartbeat;

namespace HeartbeatServer
{
    class HeartbeatServer : IHeartbeatServer
    {
        private readonly AppStatsProcessor _appStatsProcessor;
        

        public HeartbeatServer(AppStatsProcessor appStatsProcessor
            )
        {
            _appStatsProcessor = appStatsProcessor;
            
        }

        public SummaryResponse GetSummary()
        {
            return new SummaryResponse
            {
                //Servers = _appStatsProcessor.GetServers(),
                //TotalAppStats = _appStatsProcessor.GetAppStatsCount()
            };
        }

        public List<AppStats> GetAllAppStats()
        {
            return null;
            //return _appStatsProcessor.GetAllAppStats();
        }

        public void SaveDisk()
        {
            //BinarySerialization.WriteToBinaryFile("C:/Users/cozkoc/Desktop/heartbeat_service/heartbeat/Dump.hb", GetAllAppStats());
        }
    }
}
