﻿using System;

namespace DDD.Domain.Entities
{
    // 完全コンストラクターパターン
    public sealed class WheatherEntity
    {
        public WheatherEntity(int areaId,
                              DateTime dataDate,
                              int condition,
                              float temperature)
        {
            AreaId      = areaId;
            DataDate    = dataDate;
            Condition   = condition;
            Temperature = temperature;
        }

        public int AreaId        { get; }
        public DateTime DataDate { get; }
        public int Condition     { get; }
        public float Temperature { get; }
    }
}
