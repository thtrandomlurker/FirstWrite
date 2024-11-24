using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLib.FirstRead.Common
{
    public enum SubID
    {
        ATAM_ZUJO = 0,
        ATAM_ATAMA = 1,
        ITEM02 = 2,
        ITEM03 = 3,
        FACE_FACE = 4,
        ITEM05 = 5,
        ITEM06 = 6,
        ITEM07 = 7,
        JOHA_NECK = 8,
        ITEM09 = 9,
        JOHA_OUTER = 10,
        ITEM11 = 11,
        ITEM12 = 12,
        ITEM13 = 13,
        UDE_HAND = 14,
        ITEM15 = 15,
        JOHA_BACK = 16,
        ITEM17 = 17,
        ITEM18 = 18,
        ITEM19 = 19,
        ITEM20 = 20,
        ITEM21 = 21,
        ITEM22 = 22,
        ITEM23 = 23,
        ATAM_HEAD = 24
    }
    public enum CharacterType
    {
        Miku,
        Rin,
        Len,
        Luka,
        Neru,
        Haku,
        Kaito,
        Meiko,
        Sakine,
        Teto,
        Extra
    }
    public enum EffectType
    {
        Mystery = 0,
        ChanceTimeCatcher = 1,
        RateUpCatcher = 2,
        VoltageRateRecovery1 = 3,
        VoltageRateRecovery2 = 4,
        VoltageRateRecovery3 = 5,
        NoEffect6 = 6,
        NoEffect7 = 7,
        ComboSaver1 = 8,
        ComboSaver2 = 9,
        ComboSaver3 = 10,
        ComboSaver4 = 11,
        ComboSaver5 = 12,
        SafetyJudgeNone = 13,
        SafetyJudgeChanceTime = 14,
        SafetyJudgeTechZone = 15,
        SafetyJudge15 = 16,
        EffectBreaker = 17,
        BadVoltage = 18,
        ReducePenalty1 = 19,
        ReducePenalty2 = 20,
        ReducePenalty3 = 21,
        ReducePenalty4 = 22,
        ReducePenalty5 = 23,
        RateUp12s = 24,
        RateUp10s = 25,
        RateUp8s = 26,
        RateUp6s = 27,
        RateUp4s = 28,
        TechRateUp1 = 29,
        TechRateUp2 = 30,
        TechRateUp3 = 31,
        TechRateUp4 = 32,
        TechRateUp5 = 33,
        ComboRateUp80 = 34,
        ComboRateUp60 = 35,
        ComboRateUp40 = 36,
        ComboRateUp30 = 37,
        ComboRateUp20 = 38,
        Combo100RateUp1 = 39,
        Combo100RateUp2 = 40,
        Combo100RateUp3 = 41,
        Combo100RateUp4 = 42,
        Combo100RateUp5 = 43,
        Combo50RateUp1 = 44,
        Combo50RateUp2 = 45,
        Combo50RateUp3 = 46,
        Combo50RateUp4 = 47,
        Combo50RateUp5 = 48,
        Combo100Bonus1 = 49,
        Combo100Bonus2 = 50,
        Combo100Bonus3 = 51,
        Combo100Bonus4 = 52,
        Combo100Bonus5 = 53,
        RateNotesUp1 = 54,
        RateNotesUp2 = 55,
        RateNotesUp3 = 56,
        RateNotesUp4 = 57,
        RateNotesUp5 = 58,
        RateNotesPlus1 = 59,
        RateNotesPlus2 = 60,
        RateNotesPlus3 = 61,
        RateNotesPlus4 = 62,
        RateNotesPlus5 = 63,
        NewModuleDropper1 = 64,
        NewModuleDropper2 = 65,
        NewModuleDropper3 = 66,
        NewModuleDropper4 = 67,
        RareModuleDropper1 = 68,
        RareModuleDropper2 = 69,
        RareModuleDropper3 = 70,
        RareModuleDropper4 = 71,
        AccessoryDroppper1 = 72,
        AccessoryDroppper2 = 73,
        AccessoryDroppper3 = 74,
        AccessoryDroppper4 = 75,
        GiftDroppper1 = 76,
        GiftDroppper2 = 77,
        GiftDroppper3 = 78,
        GiftDroppper4 = 79,
        Overclocker = 123,
        NanoTargeter = 124,
        StealthyTarget = 125,
        ChaosStorm = 126,
        MixUp = 132,
        WibblyWobbly = 133,
        PsycheOut = 134,
        NinjaStrike = 136
    }

    public enum HandType
    {
        Left = 0b1,
        Right = 0b10,
        LeftRight = 0b11
    }
    public enum StageType
    {
        Environment = 1,
        ConcertHall = 2
    }
    public enum SongType
    {
        Normal = 0,
        Tutorial = 1,
        Medley = 2
    }
    public enum CloudType
    {
        Neutral = 1,
        Cute = 2,
        Cool = 3,
        Beauty = 4,
        Chaos = 5
    }
    public enum PartType
    {
        FACE = 0,
        ZUJO = 1,
        NECK = 2,
        BACK = 3
    }
}
