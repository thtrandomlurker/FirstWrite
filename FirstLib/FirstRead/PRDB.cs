using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstLib.IO;
using System.Numerics;
using System.IO;
using FirstLib.FirstRead.Common;

namespace FirstLib.FirstRead
{
    // Sub00. no clue what it does
    public class Sub00
    {
        public List<int> Sub00Values;

        public void Read(XReader reader)
        {
            long valuesOffset = reader.ReadInt64();
            long valuesCount = reader.ReadInt32();
            if (valuesOffset != 0)
            {
                reader.Seek((int)valuesOffset, XSeekOrigin.Base);
                for (int i = 0; i < valuesCount; i++)
                {
                    Sub00Values.Add(reader.ReadInt32());
                }
            }
        }

        public void Write(XWriter writer, int basePos)
        {
            //typically offsets for these substructs come directly after the main data. meaning we can just do
            writer.WriteOffset((writer.Tell() + 16) - basePos, basePos);
            writer.Write((short)Sub00Values.Count());
            writer.Align(16);
            foreach (var item in Sub00Values)
                writer.Write(item);
        }

        public Sub00()
        {
            Sub00Values = new List<int>();
        }
    }

    // Sub01 entries
    public class Sub01Sub00
    {
        public int U00;
        public float F04;

        public void Read(XReader reader)
        {
            U00 = reader.ReadInt32();
            F04 = reader.ReadSingle();
        }

        public void Write(XWriter writer)
        {
            writer.Write(U00);
            writer.Write(F04);
        }
    }
    // Sub01 itself
    public class Sub01
    {
        public List<Sub01Sub00> Sub00s;

        public void Read(XReader reader)
        {
            long DataOffset = reader.ReadInt64();
            short DataCount = reader.ReadInt16();
            reader.Seek((int)DataOffset, XSeekOrigin.Base);
            for (int i = 0; i < DataCount; i++)
            {
                Sub01Sub00 sub = new Sub01Sub00();
                sub.Read(reader);
                Sub00s.Add(sub);
            }
        }
        public void Write(XWriter writer, int basePos)
        {
            writer.WriteOffset((writer.Tell() + 16) - basePos, basePos);
            writer.Write((short)Sub00s.Count());
            writer.Align(16);
            foreach (var sub00 in Sub00s)
            {
                sub00.Write(writer);
            }
        }
        public Sub01()
        {
            Sub00s = new List<Sub01Sub00>();
        }
    }

    // module table
    public class ModuleInfo
    {
        public short ModuleID;
        public short CosID;
        public short U04;
        public short U06;
        public EffectType Effect;
        public CloudType Cloud;
        public CharacterType Character;
        public byte U0C;
        public byte U0D;
        public byte U0E;
        public byte U0F;
        public long U10;  // this is 0 in literally *every* module... perhaps scrapped plans for modules to count towards set bonuses?
                          // whatever it is, it isn't an offset

        public void Read(XReader reader)
        {
            ModuleID = reader.ReadInt16();
            CosID = reader.ReadInt16();
            U04 = reader.ReadInt16();
            U06 = reader.ReadInt16();
            Effect = (EffectType)reader.ReadInt16();
            Cloud = (CloudType)reader.ReadByte();
            Character = (CharacterType)reader.ReadByte();
            U0C = reader.ReadByte();
            U0D = reader.ReadByte();
            U0E = reader.ReadByte();
            U0F = reader.ReadByte();
            U10 = reader.ReadInt64();
        }

        public void Write(XWriter writer)
        {
            writer.Write(ModuleID);
            writer.Write(CosID);
            writer.Write(U04);
            writer.Write(U06);
            writer.Write((short)Effect);
            writer.Write((byte)Cloud);
            writer.Write((byte)Character);
            writer.Write(U0C);
            writer.Write(U0D);
            writer.Write(U0E);
            writer.Write(U0F);
            writer.Write(U10);
        }
    }
    // Rob Sleeve Data
    public class RobSleeveInfo
    {
        public HandType HandMode;
        public CharacterType Character;
        public short CosID;
        public float Radius;
        public float CollisionYOffset;
        public float CollisionZOffset;
        public float RotYMin;
        public float RotYMax;
        public float RotZMin;
        public float RotZMax;
        public float MuneXOffset;
        public float MuneYOffset;
        public float MuneZOffset;
        public float MuneRadius;

        public void Read(XReader reader)
        {
            HandMode = (HandType)reader.ReadByte();
            Character = (CharacterType)reader.ReadByte();
            CosID = reader.ReadInt16();
            Radius = reader.ReadSingle();
            CollisionYOffset = reader.ReadSingle();
            CollisionZOffset = reader.ReadSingle();
            RotYMin = reader.ReadSingle();
            RotYMax = reader.ReadSingle();
            RotZMin = reader.ReadSingle();
            RotZMax = reader.ReadSingle();
            MuneXOffset = reader.ReadSingle();
            MuneYOffset = reader.ReadSingle();
            MuneZOffset = reader.ReadSingle();
            MuneRadius = reader.ReadSingle();
        }

        public void Write(XWriter writer)
        {
            writer.Write((byte)HandMode);
            writer.Write((byte)Character);
            writer.Write(CosID);
            writer.Write(Radius);
            writer.Write(CollisionYOffset);
            writer.Write(CollisionZOffset);
            writer.Write(RotYMin);
            writer.Write(RotYMax);
            writer.Write(RotZMin);
            writer.Write(RotZMax);
            writer.Write(MuneXOffset);
            writer.Write(MuneYOffset);
            writer.Write(MuneZOffset);
            writer.Write(MuneRadius);
        }
    }

    // Module table itself
    public class ModuleTable {
        public List<ModuleInfo> Modules;
        public List<RobSleeveInfo> RobSleeveData;

        public void Read(XReader reader)
        {
            long moduleOffset = reader.ReadInt64();
            long robSleeveOffset = reader.ReadInt64();
            short moduleCount = reader.ReadInt16();
            short robSleeveCount = reader.ReadInt16();
            if (moduleOffset > 0)
            {
                reader.Seek((int)moduleOffset, XSeekOrigin.Base);
                for (int i = 0; i < moduleCount; i++)
                {
                    ModuleInfo module = new ModuleInfo();
                    module.Read(reader);
                    Modules.Add(module);
                }
            }
            if (robSleeveOffset > 0)
            {
                reader.Seek((int)robSleeveOffset, XSeekOrigin.Base);
                for (int i = 0; i < robSleeveCount; i++)
                {
                    RobSleeveInfo info = new RobSleeveInfo();
                    info.Read(reader);
                    RobSleeveData.Add(info);
                }
            }
        }

        public void Write(XWriter writer, int basePos)
        {
            int addSub01 = 0;
            if (Modules.Count() != 0)
            {
                writer.WriteOffset((writer.Tell() + 32) - basePos, basePos);
                addSub01 += Modules.Count() * 24;
                // align addSub01
                if (addSub01 % 16 != 0)
                    addSub01 += (16 - (addSub01 % 16));
            }
            else
            {
                writer.Write((long)0);
            }
            if (RobSleeveData.Count() != 0)
            {
                writer.WriteOffset((writer.Tell() + 24 + addSub01) - basePos, basePos);
            }
            writer.Write((short)Modules.Count());
            writer.Write((short)RobSleeveData.Count());
            writer.Align(16);
            foreach (var module in Modules)
            {
                module.Write(writer);
            }
            writer.Align(16);
            foreach (var info in RobSleeveData)
            {
                info.Write(writer);
            }
        }
        public ModuleTable()
        {
            Modules = new List<ModuleInfo>();
            RobSleeveData = new List<RobSleeveInfo>();
        }
    }

    public class CustomizeItemInfo
    {
        short ItemID;
        short ItemNumber;
        short U04;
        short U06;
        PartType Part;
        CloudType Cloud;
        byte U0A;
        byte U0B;
        int U0C;
        long ItemSetAttributes;

        public void Read(XReader reader)
        {
            ItemID = reader.ReadInt16();
            ItemNumber = reader.ReadInt16();
            U04 = reader.ReadInt16();
            U06 = reader.ReadInt16();
            Part = (PartType)reader.ReadByte();
            Cloud = (CloudType)reader.ReadByte();
            U0A = reader.ReadByte();
            U0B = reader.ReadByte();
            U0C = reader.ReadInt32();
            ItemSetAttributes = reader.ReadInt64();
        }

        public void Write(XWriter writer)
        {
            writer.Write(ItemID);
            writer.Write(ItemNumber);
            writer.Write(U04);
            writer.Write(U06);
            writer.Write((byte)Part);
            writer.Write((byte)Cloud);
            writer.Write(U0A);
            writer.Write(U0B);
            writer.Write(U0C);
            writer.Write(ItemSetAttributes);
        }
    }

    public class CustomizeItemTable
    {
        public List<CustomizeItemInfo> CustomizeItems;

        public void Read(XReader reader)
        {
            long customizeItemOffset = reader.ReadInt64();
            short customizeItemCount = reader.ReadInt16();
            if (customizeItemOffset > 0)
            {
                reader.Seek((int)customizeItemOffset, XSeekOrigin.Base);
                for (int i = 0; i < customizeItemCount; i++)
                {
                    CustomizeItemInfo item = new CustomizeItemInfo();
                    item.Read(reader);
                    CustomizeItems.Add(item);
                }
            }
        }

        public void Write(XWriter writer, int basePos)
        {
            // single list, assume it exists if we're writing it
            writer.WriteOffset((writer.Tell() + 16) - basePos, basePos);
            writer.Write((short)CustomizeItems.Count());
            writer.Align(16);
            foreach (var item in CustomizeItems)
            {
                item.Write(writer);
            }
        }

        public CustomizeItemTable()
        {
            CustomizeItems = new List<CustomizeItemInfo>();
        }
    }

    public class Sub04Sub00 {
        public short U00;
        public short U02;
        public int U04;
        public int U08;
        public int U0C;
        public int U10;
        public int U14;
        public int U18;
        public int U1C;
        public int U20;
        public int U24;
        public int U28;
        public int U2C;
        public int U30;
        public int U34;
        public int U38;
        public int U3C;
        public int U40;
        public int U44;
        public int U48;
        public short U4C;
        public short U4E;
        public byte U50;
        public byte U51;
        public byte U52;
        public byte U53;

        public void Read(XReader reader)
        {
            U00 = reader.ReadInt16();
            U02 = reader.ReadInt16();
            U04 = reader.ReadInt32();
            U08 = reader.ReadInt32();
            U0C = reader.ReadInt32();
            U10 = reader.ReadInt32();
            U14 = reader.ReadInt32();
            U18 = reader.ReadInt32();
            U1C = reader.ReadInt32();
            U20 = reader.ReadInt32();
            U24 = reader.ReadInt32();
            U28 = reader.ReadInt32();
            U2C = reader.ReadInt32();
            U30 = reader.ReadInt32();
            U34 = reader.ReadInt32();
            U38 = reader.ReadInt32();
            U3C = reader.ReadInt32();
            U40 = reader.ReadInt32();
            U44 = reader.ReadInt32();
            U48 = reader.ReadInt32();
            U4C = reader.ReadInt16();
            U4E = reader.ReadInt16();
            U50 = reader.ReadByte();
            U51 = reader.ReadByte();
            U52 = reader.ReadByte();
            U53 = reader.ReadByte();
        }

        public void Write(XWriter writer)
        {
            writer.Write(U00);
            writer.Write(U02);
            writer.Write(U04);
            writer.Write(U08);
            writer.Write(U0C);
            writer.Write(U10);
            writer.Write(U14);
            writer.Write(U18);
            writer.Write(U1C);
            writer.Write(U20);
            writer.Write(U24);
            writer.Write(U28);
            writer.Write(U2C);
            writer.Write(U30);
            writer.Write(U34);
            writer.Write(U38);
            writer.Write(U3C);
            writer.Write(U40);
            writer.Write(U44);
            writer.Write(U48);
            writer.Write(U4C);
            writer.Write(U4E);
            writer.Write(U50);
            writer.Write(U51);
            writer.Write(U52);
            writer.Write(U53);
        }
    }

    public class Sub04
    {
        public List<Sub04Sub00> Sub00s;

        public void Read(XReader reader)
        {
            long sub00Offset = reader.ReadInt64();
            short sub00Count = reader.ReadInt16();
            reader.Seek((int)sub00Offset, XSeekOrigin.Base);
            for (int i = 0; i < sub00Count; i++)
            {
                Sub04Sub00 sub00 = new Sub04Sub00();
                sub00.Read(reader);
                Sub00s.Add(sub00);
            }
        }
        public void Write(XWriter writer, int basePos)
        {
            // for single list items, we can assume this will exist
            writer.WriteOffset((writer.Tell() + 16) - basePos, basePos);
            writer.Write((short)Sub00s.Count());
            writer.Align(16); // brings us to our destination
            foreach (var item in Sub00s)
            {
                item.Write(writer);
            }
        }

        public Sub04()
        {
            Sub00s = new List<Sub04Sub00>();
        }
    }

    public class PvDataPerformer
    {
        public byte U00;
        public byte U01;
        public byte U02;
        public CharacterType Character;
        public short Costume;
        public short PvCostume;

        public void Read(XReader reader)
        {
            U00 = reader.ReadByte();
            U01 = reader.ReadByte();
            U02 = reader.ReadByte();
            Character = (CharacterType)reader.ReadByte();
            Costume = reader.ReadInt16();
            PvCostume = reader.ReadInt16();
        }

        public void Write(XWriter writer)
        {
            writer.Write(U00);
            writer.Write(U01);
            writer.Write(U02);
            writer.Write((byte)Character);
            writer.Write(Costume);
            writer.Write(PvCostume);
        }
    }

    public class PvData
    {
        public short PvID;
        public short StageID;
        public short U04;
        public short MinBPM;
        public short MaxBPM;
        public List<PvDataPerformer> Performers;
        public byte U0B;

        public void Read(XReader reader)
        {
            PvID = reader.ReadInt16();
            StageID = reader.ReadInt16();
            U04 = reader.ReadInt16();
            MinBPM = reader.ReadInt16();
            MaxBPM = reader.ReadInt16();
            byte performerCount = reader.ReadByte();
            U0B = reader.ReadByte();
            reader.Seek(4, XSeekOrigin.Current);
            reader.ReadOffset(() =>
            {
                for (int i = 0; i < performerCount; i++)
                {
                    PvDataPerformer performer = new PvDataPerformer();
                    performer.Read(reader);
                    Performers.Add(performer);
                }
            });
        }

        public int Write(XWriter writer, int performerPos, int basePos)
        {
            writer.Write(PvID);
            writer.Write(StageID);
            writer.Write(U04);
            writer.Write(MinBPM);
            writer.Write(MaxBPM);
            writer.Write((byte)Performers.Count());
            writer.Write(U0B);
            writer.WriteNulls(4);
            if (Performers.Count() != 0)
                writer.WriteOffset(performerPos - basePos, basePos);
            else
                writer.Write((long)0);
            long pre = writer.Tell();
            writer.Seek(performerPos, SeekOrigin.Begin);
            foreach (var performer in Performers)
            {
                performer.Write(writer);
            }
            writer.Seek((int)pre, SeekOrigin.Begin);
            return performerPos + Performers.Count() * 8;
        }

        public PvData()
        {
            Performers = new List<PvDataPerformer>();
        }
    }

    public class PvInfo
    {
        public short PvID;
        public short StageID;
        public short CloudSongID;
        public short U06;
        public CloudType CloudA;
        public CloudType CloudB;
        public SongType SongType;
        public bool HasEasy;
        public bool HasNormal;
        public bool HasHard;
        public bool HasExtreme;
        public byte EasyDifficulty;
        public byte NormalDifficulty;
        public byte HardDifficulty;
        public byte ExtremeDifficulty;
        public int SongInfo0ID;
        public int SongInfo1ID;
        public int SongInfo2ID;
        public int SongInfo3ID;
        public int SongNameID;

        public void Read(XReader reader)
        {
            PvID = reader.ReadInt16();
            StageID = reader.ReadInt16();
            CloudSongID = reader.ReadInt16();
            U06 = reader.ReadInt16();
            CloudA = (CloudType)reader.ReadByte();
            CloudB = (CloudType)reader.ReadByte();
            SongType = (SongType)reader.ReadByte();
            byte presentBits = reader.ReadByte();
            HasEasy = (presentBits & 0b1) > 0;
            HasNormal = (presentBits & 0b10) > 0;
            HasHard = (presentBits & 0b100) > 0;
            HasExtreme = (presentBits & 0b1000) > 0;
            EasyDifficulty = reader.ReadByte();
            NormalDifficulty = reader.ReadByte();
            HardDifficulty = reader.ReadByte();
            ExtremeDifficulty = reader.ReadByte();
            SongInfo0ID = reader.ReadInt32();
            SongInfo1ID = reader.ReadInt32();
            SongInfo2ID = reader.ReadInt32();
            SongInfo3ID = reader.ReadInt32();
            SongNameID = reader.ReadInt32();
        }

        public void Write(XWriter writer)
        {
            writer.Write(PvID);
            writer.Write(StageID);
            writer.Write(CloudSongID);
            writer.Write(U06);
            writer.Write((byte)CloudA);
            writer.Write((byte)CloudB);
            writer.Write((byte)SongType);
            // assemble the present bits
            byte presentBits = 0;
            presentBits += (byte)(HasEasy ? 0b1 : 0b0);
            presentBits += (byte)(HasNormal ? 0b10 : 0b0);
            presentBits += (byte)(HasHard ? 0b100 : 0b0);
            presentBits += (byte)(HasExtreme ? 0b1000 : 0b0);
            writer.Write(presentBits);
            writer.Write(EasyDifficulty);
            writer.Write(NormalDifficulty);
            writer.Write(HardDifficulty);
            writer.Write(ExtremeDifficulty);
            writer.Write(SongInfo0ID);
            writer.Write(SongInfo1ID);
            writer.Write(SongInfo2ID);
            writer.Write(SongInfo3ID);
            writer.Write(SongNameID);
        }
    }

    public class PvSabi
    {
        public short PvID;
        public float SabiStartTime;
        public float SabiPlayTime;

        public void Read(XReader reader)
        {
            PvID = reader.ReadInt16();
            reader.Seek(2, XSeekOrigin.Current);
            SabiStartTime = reader.ReadSingle();
            SabiPlayTime = reader.ReadSingle();
        }

        public void Write(XWriter writer)
        {
            writer.Write(PvID);
            writer.WriteNulls(2);
            writer.Write(SabiStartTime);
            writer.Write(SabiPlayTime);
        }
    }

    public class PvTable
    {
        public List<PvData> PvDataTable;
        public List<PvInfo> PvInfoTable;
        public List<PvSabi> PvSabiTable;

        public void Read(XReader reader)
        {
            long pvDataOffset = reader.ReadInt64();
            long pvInfoOffset = reader.ReadInt64();
            long pvSabiOffset = reader.ReadInt64();

            short pvDataCount = reader.ReadInt16();
            short pvInfoCount = reader.ReadInt16();
            short pvSabiCount = reader.ReadInt16();

            reader.Seek((int)pvDataOffset, XSeekOrigin.Base);
            for (int i = 0; i < pvDataCount; i++)
            {
                PvData pvData = new PvData();
                pvData.Read(reader);
                PvDataTable.Add(pvData);
            }
            reader.Seek((int)pvInfoOffset, XSeekOrigin.Base);
            for (int i = 0; i < pvInfoCount; i++)
            {
                PvInfo pvInfo = new PvInfo();
                pvInfo.Read(reader);
                PvInfoTable.Add(pvInfo);
            }
            reader.Seek((int)pvSabiOffset, XSeekOrigin.Base);
            for (int i = 0; i < pvSabiCount; i++)
            {
                PvSabi pvSabi = new PvSabi();
                pvSabi.Read(reader);
                PvSabiTable.Add(pvSabi);
            }
        }

        public void Write(XWriter writer, int basePos)
        {
            if (PvDataTable.Count() != 0)
                writer.WriteOffset((writer.Tell() + 32) - basePos, basePos);
            else
                writer.Write((long)0);
            int pvInfoPosAdd = PvDataTable.Count() * 24;
            if (pvInfoPosAdd % 16 != 0)
                pvInfoPosAdd += (16 - (pvInfoPosAdd % 16));
            if (PvInfoTable.Count() != 0)
                writer.WriteOffset((writer.Tell() + 24 + pvInfoPosAdd) - basePos, basePos);
            else
                writer.Write((long)0);
            int pvSabiPosAdd = pvInfoPosAdd + PvInfoTable.Count() * 36;
            if (pvSabiPosAdd % 16 != 0)
                pvSabiPosAdd += (16 - (pvSabiPosAdd % 16));
            if (PvSabiTable.Count() != 0)
                writer.WriteOffset((writer.Tell() + 16 + pvSabiPosAdd) - basePos, basePos);
            else
                writer.Write((long)0);
            int performerPos = (int)writer.Tell() + 8 + pvSabiPosAdd + PvSabiTable.Count() * 12;
            if (performerPos % 16 != 0)
                performerPos += (16 - (performerPos % 16));
            writer.Write((short)PvDataTable.Count());
            writer.Write((short)PvInfoTable.Count());
            writer.Write((short)PvSabiTable.Count());
            writer.Align(16);
            foreach (var pvData in PvDataTable)
            {
                performerPos = pvData.Write(writer, performerPos, basePos);
            }
            writer.Align(16);
            foreach (var pvInfo in PvInfoTable)
            {
                pvInfo.Write(writer);
            }
            writer.Align(16);
            foreach (var pvSabi in PvSabiTable)
            {
                pvSabi.Write(writer);
            }
            // for this section we want to go to the end of the data (stream)
            writer.Seek(0, SeekOrigin.End);
            writer.Align(16);
        }

        public PvTable()
        {
            PvDataTable = new List<PvData>();
            PvInfoTable = new List<PvInfo>();
            PvSabiTable = new List<PvSabi>();
        }
    }

    public class Stage
    {
        public short StageID;
        public short U02;
        public StageType Type;
        public byte U05;
        public byte U06;
        public byte U07;

        public void Read(XReader reader)
        {
            StageID = reader.ReadInt16();
            U02 = reader.ReadInt16();
            Type = (StageType)reader.ReadByte();
            U05 = reader.ReadByte();
            U06 = reader.ReadByte();
            U07 = reader.ReadByte();
        }
        public void Write(XWriter writer)
        {
            writer.Write(StageID);
            writer.Write(U02);
            writer.Write((byte)Type);
            writer.Write(U05);
            writer.Write(U06);
            writer.Write(U07);
        }
    }

    public class StageTable
    {
        public List<Stage> Stages { get; }

        public void Read(XReader reader)
        {
            long stageInfoOffset = reader.ReadInt64();
            short stageCount = reader.ReadInt16();

            reader.ReadAtOffset((int)stageInfoOffset, () =>
            {
                for (int i = 0; i < stageCount; i++)
                {
                    Stage stage = new Stage();
                    stage.Read(reader);
                    Stages.Add(stage);
                }
            });
        }

        public void Write(XWriter writer, int basePos)
        {
            if (Stages.Count() != 0)
                writer.WriteOffset((writer.Tell() + 16) - basePos, basePos);
            else
                writer.Write((long)0);
            writer.Write((short)Stages.Count());
            writer.Align(16);
            foreach (var stage in Stages)
            {
                stage.Write(writer);
            }
        }

        public StageTable()
        {
            Stages = new List<Stage>();
        }
    }

    public class SetBonus
    {
        public short SetBonusNameID;
        public short SetBonusID;
        public byte SortIndex;
        public byte NumItemsNeeded;
        public bool FaceNeeded;
        public bool ZujoNeeded;
        public bool NeckNeeded;
        public bool BackNeeded;
        public float RateUpBonus;
        public long FaceItemAttributes;
        public long ZujoItemAttributes;
        public long NeckItemAttributes;
        public long BackItemAttributes;
        public short FaceItem;
        public short ZujoItem;
        public short NeckItem;
        public short BackItem;

        public void Read(XReader reader)
        {
            SetBonusNameID = reader.ReadInt16();
            SetBonusID = reader.ReadInt16();
            SortIndex = reader.ReadByte();
            NumItemsNeeded = reader.ReadByte();
            FaceNeeded = reader.ReadByte() == 1;
            ZujoNeeded = reader.ReadByte() == 1;
            NeckNeeded = reader.ReadByte() == 1;
            BackNeeded = reader.ReadByte() == 1;
            reader.Seek(2, XSeekOrigin.Current);
            RateUpBonus = reader.ReadSingle();
            FaceItemAttributes = reader.ReadInt64();
            ZujoItemAttributes = reader.ReadInt64();
            NeckItemAttributes = reader.ReadInt64();
            BackItemAttributes = reader.ReadInt64();
            // init the items
            FaceItem = -1;
            ZujoItem = -1;
            NeckItem = -1;
            BackItem = -1;
            long FaceItemOffset = reader.ReadInt64();
            long ZujoItemOffset = reader.ReadInt64();
            long NeckItemOffset = reader.ReadInt64();
            long BackItemOffset = reader.ReadInt64();
            if (FaceItemOffset != 0)
                reader.ReadAtOffset((int)FaceItemOffset, () => FaceItem = reader.ReadInt16());
            if (ZujoItemOffset != 0)
                reader.ReadAtOffset((int)ZujoItemOffset, () => ZujoItem = reader.ReadInt16());
            if (NeckItemOffset != 0)
                reader.ReadAtOffset((int)NeckItemOffset, () => NeckItem = reader.ReadInt16());
            if (BackItemOffset != 0)
                reader.ReadAtOffset((int)BackItemOffset, () => BackItem = reader.ReadInt16());
        }

        public int Write(XWriter writer, int itemsPos, int basePos)
        {
            int tmpItemsPos = itemsPos;
            writer.Write(SetBonusNameID);
            writer.Write(SetBonusID);
            writer.Write(SortIndex);
            writer.Write(NumItemsNeeded);
            writer.Write(FaceNeeded);
            writer.Write(ZujoNeeded);
            writer.Write(NeckNeeded);
            writer.Write(BackNeeded);
            writer.Align(4);
            writer.Write(RateUpBonus);
            writer.Write(FaceItemAttributes);
            writer.Write(ZujoItemAttributes);
            writer.Write(NeckItemAttributes);
            writer.Write(BackItemAttributes);
            if (FaceItem != -1)
            {
                writer.WriteOffset(tmpItemsPos - basePos, basePos);
                long pre = writer.Tell();
                writer.Seek(tmpItemsPos, SeekOrigin.Begin);
                writer.Write(FaceItem);
                writer.Align(8);
                tmpItemsPos = (int)writer.Tell();
                writer.Seek((int)pre, SeekOrigin.Begin);
            }
            else
                writer.Write((long)0);
            if (ZujoItem != -1)
            {
                writer.WriteOffset(tmpItemsPos - basePos, basePos);
                long pre = writer.Tell();
                writer.Seek(tmpItemsPos, SeekOrigin.Begin);
                writer.Write(ZujoItem);
                writer.Align(8);
                tmpItemsPos = (int)writer.Tell();
                writer.Seek((int)pre, SeekOrigin.Begin);
            }
            else
                writer.Write((long)0);
            if (NeckItem != -1)
            {
                writer.WriteOffset(tmpItemsPos - basePos, basePos);
                long pre = writer.Tell();
                writer.Seek(tmpItemsPos, SeekOrigin.Begin);
                writer.Write(NeckItem);
                writer.Align(8);
                tmpItemsPos = (int)writer.Tell();
                writer.Seek((int)pre, SeekOrigin.Begin);
            }
            else
                writer.Write((long)0);
            if (BackItem != -1)
            {
                writer.WriteOffset(tmpItemsPos - basePos, basePos);
                long pre = writer.Tell();
                writer.Seek(tmpItemsPos, SeekOrigin.Begin);
                writer.Write(BackItem);
                writer.Align(8);
                tmpItemsPos = (int)writer.Tell();
                writer.Seek((int)pre, SeekOrigin.Begin);
            }
            else
                writer.Write((long)0);
            return tmpItemsPos;
        }
    }

    public class SetBonusTable
    {
        public List<SetBonus> SetBonuses { get; }

        public void Read(XReader reader)
        {
            long setBonusInfoOffset = reader.ReadInt64();
            short setBonusInfoCount = reader.ReadInt16();

            reader.ReadAtOffset((int)setBonusInfoOffset, () =>
            {
                for (int i = 0; i < setBonusInfoCount; i++)
                {
                    SetBonus bonus = new SetBonus();
                    bonus.Read(reader);
                    SetBonuses.Add(bonus);
                }
            });
        }

        public void Write(XWriter writer, int basePos)
        {
            if (SetBonuses.Count() != 0)
                writer.WriteOffset((writer.Tell() + 16) - basePos, basePos);
            else
                writer.Write((long)0);
            writer.Write((short)SetBonuses.Count());
            writer.Align(16);
            int itemsPos = (int)writer.Tell() + (0x50 * SetBonuses.Count());
            foreach (var bonus in SetBonuses)
            {
                itemsPos = bonus.Write(writer, itemsPos, basePos);
            }
        }

        public SetBonusTable()
        {
            SetBonuses = new List<SetBonus>();
        }
    }


    // the PRDB
    public class PRDB
    {
        public XHeader Header;
        public int U00;
        public int U04;
        public Sub00 Sub00;
        public Sub01 Sub01;
        public ModuleTable ModuleTable;
        public CustomizeItemTable CustomizeItemTable;
        public Sub04 Sub04;
        public PvTable PvTable;
        public StageTable StageTable;
        public SetBonusTable SetBonusTable;

        public void Read(XReader reader)
        {
            Header = new XHeader();
            Header.Read(reader);
            reader.UpdateBasePosition();
            U00 = reader.ReadInt32();
            U04 = reader.ReadInt32();
            // Read the offsets
            long sub00Offset = reader.ReadInt64();
            long sub01Offset = reader.ReadInt64();
            long moduleOffset = reader.ReadInt64();
            long customizeOffset = reader.ReadInt64();
            long sub04Offset = reader.ReadInt64();
            long pvTableOffset = reader.ReadInt64();
            long stageOffset = reader.ReadInt64();
            long setBonusOffset = reader.ReadInt64();
            long sub08Offset = reader.ReadInt64();
            long sub09Offset = reader.ReadInt64();
            long sub10Offset = reader.ReadInt64();
            long sub11Offset = reader.ReadInt64();
            long sub12Offset = reader.ReadInt64();
            long sub13Offset = reader.ReadInt64();
            long sub14Offset = reader.ReadInt64();
            long sub15Offset = reader.ReadInt64();
            long sub16Offset = reader.ReadInt64();
            long sub17Offset = reader.ReadInt64();
            long sub18Offset = reader.ReadInt64();
            long sub19Offset = reader.ReadInt64();
            long sub20Offset = reader.ReadInt64();
            long sub21Offset = reader.ReadInt64();
            long sub22Offset = reader.ReadInt64();
            long sub23Offset = reader.ReadInt64();
            long sub24Offset = reader.ReadInt64();
            long sub25Offset = reader.ReadInt64();
            long sub26Offset = reader.ReadInt64();
            long sub27Offset = reader.ReadInt64();
            long sub28Offset = reader.ReadInt64();
            long sub29Offset = reader.ReadInt64();
            long sub30Offset = reader.ReadInt64();
            long sub31Offset = reader.ReadInt64();
            long sub32Offset = reader.ReadInt64();
            long sub33Offset = reader.ReadInt64();
            long sub34Offset = reader.ReadInt64();
            long sub35Offset = reader.ReadInt64();
            long sub36Offset = reader.ReadInt64();
            long sub37Offset = reader.ReadInt64();
            // Get the data
            // Sub00
            if (sub00Offset > 0)
            {
                reader.Seek((int)sub00Offset, XSeekOrigin.Base);
                Sub00.Read(reader);
            }
            // Sub01
            if (sub01Offset > 0)
            {
                reader.Seek((int)sub01Offset, XSeekOrigin.Base);
                Sub01.Read(reader);
            }
            // ModuleTable
            if (moduleOffset > 0)
            {
                reader.Seek((int)moduleOffset, XSeekOrigin.Base);
                ModuleTable.Read(reader);
            }
            // CustomizeItemTable
            if (customizeOffset > 0)
            {
                reader.Seek((int)customizeOffset, XSeekOrigin.Base);
                CustomizeItemTable.Read(reader);
            }
            // CustomizeItemTable
            if (sub04Offset > 0)
            {
                reader.Seek((int)sub04Offset, XSeekOrigin.Base);
                Sub04.Read(reader);
            }
            if (pvTableOffset > 0)
            {
                reader.Seek((int)pvTableOffset, XSeekOrigin.Base);
                PvTable.Read(reader);
            }
            if (stageOffset > 0)
            {
                reader.Seek((int)stageOffset, XSeekOrigin.Base);
                StageTable.Read(reader);
            }
            if (setBonusOffset > 0)
            {
                reader.Seek((int)setBonusOffset, XSeekOrigin.Base);
                SetBonusTable.Read(reader);
            }

            // end of file
            reader.Seek(Header.DataSize, XSeekOrigin.Base);
            char[] check = reader.CheckNextSection();
            // Skip ENRS if it's there
            if (check[0] == 'E')
            {
                reader.SkipNextSection();
            }
            // POF is always here.
            reader.SkipNextSection();
            // Same for EOFC;
            reader.SkipNextSection();
        }

        public void Write(XWriter writer)
        {
            writer.WriteHeader(new char[4] {'P', 'R', 'D', 'B'});
            long dataPos = writer.Tell();
            writer.Write(U00);
            writer.Write(U04);
            // generate the offset bytes real quick
            long offsetsStart = writer.Tell();
            writer.WriteNulls(312);
            long baseOff = writer.Tell();
            // work out the substructs
            // perhaps check the counts of all member lists
            // Sub00
            if (Sub00.Sub00Values.Count() != 0)  // it has data
            {
                writer.Seek((int)offsetsStart, SeekOrigin.Begin);
                writer.WriteOffset(baseOff - dataPos, dataPos);
                offsetsStart += 8;
                writer.Seek((int)(baseOff), SeekOrigin.Begin);
                Sub00.Write(writer, (int)dataPos);
                writer.Align(16);
                baseOff = writer.Tell();
            }
            // Sub01
            if (Sub01.Sub00s.Count() != 0)
            {
                writer.Seek((int)offsetsStart, SeekOrigin.Begin);
                writer.WriteOffset(baseOff - dataPos, dataPos);
                offsetsStart += 8;
                writer.Seek((int)(baseOff), SeekOrigin.Begin);
                Sub01.Write(writer, (int)dataPos);
                writer.Align(16);
                baseOff = writer.Tell();
            }
            // Modules
            if (ModuleTable.Modules.Count() != 0 || ModuleTable.RobSleeveData.Count() != 0)
            {
                writer.Seek((int)offsetsStart, SeekOrigin.Begin);
                writer.WriteOffset(baseOff - dataPos, dataPos);
                offsetsStart += 8;
                writer.Seek((int)(baseOff), SeekOrigin.Begin);
                ModuleTable.Write(writer, (int)dataPos);
                writer.Align(16);
                baseOff = writer.Tell();
            }
            // CustomizeItems
            if (CustomizeItemTable.CustomizeItems.Count() != 0)
            {
                writer.Seek((int)offsetsStart, SeekOrigin.Begin);
                writer.WriteOffset(baseOff - dataPos, dataPos);
                offsetsStart += 8;
                writer.Seek((int)(baseOff), SeekOrigin.Begin);
                CustomizeItemTable.Write(writer, (int)dataPos);
                writer.Align(16);
                baseOff = writer.Tell();
            }
            // Sub04
            if (Sub04.Sub00s.Count() != 0)
            {
                writer.Seek((int)offsetsStart, SeekOrigin.Begin);
                writer.WriteOffset(baseOff - dataPos, dataPos);
                offsetsStart += 8;
                writer.Seek((int)(baseOff), SeekOrigin.Begin);
                Sub04.Write(writer, (int)dataPos);
                writer.Align(16);
                baseOff = writer.Tell();
            }
            // PvTable
            if (PvTable.PvDataTable.Count() != 0 || PvTable.PvInfoTable.Count() != 0 || PvTable.PvSabiTable.Count() != 0)
            {
                writer.Seek((int)offsetsStart, SeekOrigin.Begin);
                writer.WriteOffset(baseOff - dataPos, dataPos);
                offsetsStart += 8;
                writer.Seek((int)(baseOff), SeekOrigin.Begin);
                PvTable.Write(writer, (int)dataPos);
                writer.Align(16);
                baseOff = writer.Tell();
            }
            // StageTable
            if (StageTable.Stages.Count() != 0)
            {
                writer.Seek((int)offsetsStart, SeekOrigin.Begin);
                writer.WriteOffset(baseOff - dataPos, dataPos);
                offsetsStart += 8;
                writer.Seek((int)(baseOff), SeekOrigin.Begin);
                StageTable.Write(writer, (int)dataPos);
                writer.Align(16);
                baseOff = writer.Tell();
            }
            // SetBonusTable
            if (SetBonusTable.SetBonuses.Count() != 0)
            {
                writer.Seek((int)offsetsStart, SeekOrigin.Begin);
                writer.WriteOffset(baseOff - dataPos, dataPos);
                offsetsStart += 8;
                writer.Seek((int)(baseOff), SeekOrigin.Begin);
                SetBonusTable.Write(writer, (int)dataPos);
                writer.Seek(0, SeekOrigin.End);
                writer.Align(16);
                baseOff = writer.Tell();
            }

            // end of file
            long dataEnd = writer.Tell();
            writer.WritePOF1();
            writer.WriteEOFC();
            long contentsEnd = writer.Tell();
            writer.Seek((int)dataPos - 28, SeekOrigin.Begin);
            writer.Write((int)(contentsEnd - dataPos));
            writer.Seek(12, SeekOrigin.Current);
            writer.Write((int)(dataEnd - dataPos));
            writer.Seek((int)contentsEnd, SeekOrigin.Begin);
        }

        public PRDB()
        {
            Sub00 = new Sub00();
            Sub01 = new Sub01();
            ModuleTable = new ModuleTable();
            CustomizeItemTable = new CustomizeItemTable();
            Sub04 = new Sub04();
            PvTable = new PvTable();
            StageTable = new StageTable();
            SetBonusTable = new SetBonusTable();
        }
    }
}
