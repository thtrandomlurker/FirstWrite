using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.IO;
using FirstLib.IO;
using FirstLib.FirstRead.Common;

// this entire block is disgusting...
// this is a prime example as to why you should never let an inexperienced coder
// write the only existing writer for project diva's most complex file format

namespace FirstLib.FirstRead
{
    public class ItemObject
    {
        public uint ObjectID;
        public byte RPK;

        public void Read(XReader reader)
        {
            ObjectID = reader.ReadUInt32();
            RPK = reader.ReadByte();
            reader.Seek(3, XSeekOrigin.Current);
        }
        public void Write(XWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(RPK);
            writer.WriteNulls(3);
        }
    }
    public class TextureChange
    {
        public uint OriginalTextureID;
        public uint ReplacementTextureID;
        public void Read(XReader reader)
        {
            OriginalTextureID = reader.ReadUInt32();
            ReplacementTextureID = reader.ReadUInt32();
        }
        public void Write(XWriter writer)
        {
            writer.Write(OriginalTextureID);
            writer.Write(ReplacementTextureID);
        }
    }
    public class Item
    {
        public short ItemNumber;
        public short Attribute;
        public short U04;
        public byte U06;
        public byte U07;
        public byte Type;
        public byte U09;
        public List<ItemObject> Objects;
        public List<TextureChange> TextureChanges;
        public List<uint> ObjectSets;
        public byte DestID;
        public SubID SubID;
        public byte U0F;
        public int U10;
        public int U14;

        public void Read(XReader reader)
        {
            ItemNumber = reader.ReadInt16();
            Attribute = reader.ReadInt16();
            U04 = reader.ReadInt16();
            U06 = reader.ReadByte();
            U07 = reader.ReadByte();
            Type = reader.ReadByte();
            U09 = reader.ReadByte();
            byte objectCount = reader.ReadByte();
            byte textureChangeCount = reader.ReadByte();
            byte objectSetCount = reader.ReadByte();
            DestID = reader.ReadByte();
            SubID = (SubID)reader.ReadByte();
            U0F = reader.ReadByte();
            U10 = reader.ReadInt32();
            U14 = reader.ReadInt32();
            // objects
            reader.ReadOffset(() =>
            {
                for (int i = 0; i < objectCount; i++)
                {
                    ItemObject obj = new ItemObject();
                    obj.Read(reader);
                    Objects.Add(obj);
                }
            });
            // tex changes
            reader.ReadOffset(() =>
            {
                for (int i = 0; i < textureChangeCount; i++)
                {
                    TextureChange chg = new TextureChange();
                    chg.Read(reader);
                    TextureChanges.Add(chg);
                }
            });
            // object sets
            reader.ReadOffset(() =>
            {
                for (int i = 0; i < objectSetCount; i++)
                {
                    ObjectSets.Add(reader.ReadUInt32());
                }
            });
            reader.Seek(8, XSeekOrigin.Current);
        }
        public int[] Write(XWriter writer, int objPos, int texChangePos, int objSetPos, int basePos)
        {
            int curObjectPos = objPos;
            int curTexChangePos = texChangePos;
            int curObjectSetPos = objSetPos;
            writer.Write(ItemNumber);
            writer.Write(Attribute);
            writer.Write(U04);
            writer.Write(U06);
            writer.Write(U07);
            writer.Write(Type);
            writer.Write(U09);
            writer.Write((byte)Objects.Count());
            writer.Write((byte)TextureChanges.Count());
            writer.Write((byte)ObjectSets.Count());
            writer.Write(DestID);
            writer.Write((byte)SubID);
            writer.Write(U0F);
            writer.Write(U10);
            writer.Write(U14);
            writer.WriteOffset(curObjectPos-basePos, basePos);
            writer.WriteOffset(curTexChangePos-basePos, basePos);
            writer.WriteOffset(curObjectSetPos-basePos, basePos);
            writer.WriteNulls(8);
            // write the objects
            long cur = writer.Tell();
            writer.Seek(curObjectPos, SeekOrigin.Begin);
            foreach (var obj in Objects)
            {
                obj.Write(writer);
                curObjectPos += 8;
            }
            writer.Seek(curTexChangePos, SeekOrigin.Begin);
            foreach (var tex in TextureChanges)
            {
                tex.Write(writer);
                curTexChangePos += 8;
            }
            writer.Seek(curObjectSetPos, SeekOrigin.Begin);
            foreach (var set in ObjectSets)
            {
                writer.Write(set);
                curObjectSetPos += 4;
            }
            writer.Seek((int)cur, SeekOrigin.Begin);

            return new int[3] {curObjectPos, curTexChangePos, curObjectSetPos};  // return so the next write knows the new position
        }
        public Item()
        {
            Objects = new List<ItemObject>();
            TextureChanges = new List<TextureChange>();
            ObjectSets = new List<uint>();
        }
    }
    public class CommonItemAdjust
    {
        short ItemNumber;
        byte U02;
        Vector3 Position;
        Vector3 Rotation;
        Vector3 Scale;
        public void Read(XReader reader)
        {
            ItemNumber = reader.ReadInt16();
            U02 = reader.ReadByte();
            reader.Seek(1, XSeekOrigin.Current);
            Position.X = reader.ReadSingle();
            Position.Y = reader.ReadSingle();
            Position.Z = reader.ReadSingle();
            Rotation.X = reader.ReadSingle();
            Rotation.Y = reader.ReadSingle();
            Rotation.Z = reader.ReadSingle();
            Scale.X = reader.ReadSingle();
            Scale.Y = reader.ReadSingle();
            Scale.Z = reader.ReadSingle();
        }

        public void Write(XWriter writer)
        {
            writer.Write(ItemNumber);
            writer.Write(U02);
            writer.Write((byte)0);
            writer.Write(Position.X);
            writer.Write(Position.Y);
            writer.Write(Position.Z);
            writer.Write(Rotation.X);
            writer.Write(Rotation.Y);
            writer.Write(Rotation.Z);
            writer.Write(Scale.X);
            writer.Write(Scale.Y);
            writer.Write(Scale.Z);
        }
    }

    public class CostumePart
    {
        public short ItemNumber;
        public SubID ItemSlot;

        public void Read(XReader reader)
        {
            ItemNumber = reader.ReadInt16();
        }
    }

    public class Costume
    {
        public short CostumeID;
        public List<CostumePart> Parts;

        public void Read(XReader reader)
        {
            CostumeID = reader.ReadInt16();
            reader.Seek(2, XSeekOrigin.Current);
            int tParts = reader.ReadInt32();
            long partsOffset = reader.ReadInt64();
            int cur = reader.Tell();
            reader.Seek((int)partsOffset, XSeekOrigin.Base);
            for (int i = 0; i < 25; i++)
            {
                CostumePart part = new CostumePart();
                if ((tParts & (int)(0b1 << i)) > 0)
                    part.Read(reader);
                else
                    part.ItemNumber = 0;
                part.ItemSlot = (SubID)i;
                Parts.Add(part);
            }
            reader.Seek(cur, XSeekOrigin.Begin);
        }
        public int Write(XWriter writer, int cosPartBase, int basePos)
        {
            int cosPartPos = cosPartBase;
            writer.Write(CostumeID);
            writer.WriteNulls(2);
            int tParts = 0;
            for (int i = 0; i < 25; i++)
            {
                if (Parts[i].ItemNumber != 0)
                {
                    tParts += 0b1 << i;
                }
            }
            writer.Write(tParts);
            if (tParts != 0)  // realistically this shouldn't happen
            {
                writer.WriteOffset(cosPartPos - basePos, basePos);
                long pre = writer.Tell();
                writer.Seek(cosPartPos, SeekOrigin.Begin);
                foreach (var part in Parts)
                {
                    if (part.ItemNumber != 0)
                    {
                        writer.Write(part.ItemNumber);
                        cosPartPos += 2;
                    }
                }
                writer.Seek((int)pre, SeekOrigin.Begin);
            }
            return cosPartPos;
        }
        public Costume()
        {
            Parts = new List<CostumePart>();
        }
    }
    public class CharacterItemTable
    {
        public List<Item> Items;
        public List<CommonItemAdjust> CommonItemAdjustments;
        public List<Costume> Costumes;
        public bool KeepInFile;

        public void Read(XReader reader)
        {
            short itemCount = reader.ReadInt16();
            short adjustCount = reader.ReadInt16();
            short cosCount = reader.ReadInt16();
            reader.Seek(2, XSeekOrigin.Current);
            long itemOffset = reader.ReadInt64();
            long adjustOffset = reader.ReadInt64();
            long cosOffset = reader.ReadInt64();
            int pre = reader.Tell();
            reader.Seek((int)itemOffset, XSeekOrigin.Base);
            for (int i = 0; i < itemCount; i++)
            {
                Item item = new Item();
                item.Read(reader);
                Items.Add(item);
            }
            reader.Seek((int)adjustOffset, XSeekOrigin.Base);
            for (int i = 0; i < adjustCount; i++)
            {
                CommonItemAdjust adjust = new CommonItemAdjust();
                adjust.Read(reader);
                CommonItemAdjustments.Add(adjust);
            }
            reader.Seek((int)cosOffset, XSeekOrigin.Base);
            for (int i = 0; i < cosCount; i++)
            {
                Costume costume = new Costume();
                costume.Read(reader);
                Costumes.Add(costume);
            }
            reader.Seek(pre, XSeekOrigin.Begin);
        }

        public int[] Write(XWriter writer, int itemBase, int itemObjectBase, int itemTexChangeBase, int itemObjectSetBase, int adjustBase, int cosBase, int cosPartBase, int basePos)
        {
            writer.Write((short)Items.Count());
            writer.Write((short)CommonItemAdjustments.Count());
            writer.Write((short)Costumes.Count());
            writer.WriteNulls(2);
            int itemPos = itemBase;
            int itemObjectPos = itemObjectBase;
            int itemTexChangePos = itemTexChangeBase;
            int itemObjectSetPos = itemObjectSetBase;
            int adjustPos = adjustBase;
            int cosPos = cosBase;
            int cosPartPos = cosPartBase;
            if (Items.Count() != 0)
            {
                writer.WriteOffset(itemPos-basePos, basePos);
                long pre = writer.Tell();
                writer.Seek(itemPos, SeekOrigin.Begin);
                foreach (var item in Items)
                {
                    int[] newInfo = item.Write(writer, itemObjectPos, itemTexChangePos, itemObjectSetPos, basePos);
                    itemObjectPos = newInfo[0];
                    itemTexChangePos = newInfo[1];
                    itemObjectSetPos = newInfo[2];
                }
                itemPos += Items.Count() * 0x38;
                writer.Seek((int)pre, SeekOrigin.Begin);
            }
            else
                writer.Write((long)0);
            if (CommonItemAdjustments.Count() != 0)
            {
                writer.WriteOffset(adjustPos-basePos, basePos);
                long pre = writer.Tell();
                writer.Seek(adjustPos, SeekOrigin.Begin);
                foreach (var item in CommonItemAdjustments)
                {
                    item.Write(writer);
                }
                adjustPos += CommonItemAdjustments.Count() * 0x28;
                writer.Seek((int)pre, SeekOrigin.Begin);
            }
            else
                writer.Write((long)0);
            if (Costumes.Count() != 0)
            {
                writer.WriteOffset(cosPos-basePos, basePos);
                long pre = writer.Tell();
                writer.Seek(cosPos, SeekOrigin.Begin);
                foreach (var cos in Costumes)
                {
                    cosPartPos = cos.Write(writer, cosPartPos, basePos);
                }
                cosPos += Costumes.Count() * 0x10;
                writer.Seek((int)pre, SeekOrigin.Begin);
            }
            else
                writer.Write((long)0);
            return new int[] {itemPos, itemObjectPos, itemTexChangePos, itemObjectSetPos, adjustPos, cosPos, cosPartPos};
        }

        public CharacterItemTable()
        {
            Items = new List<Item>();
            CommonItemAdjustments = new List<CommonItemAdjust>();
            Costumes = new List<Costume>();
        }
    }
    // structure figured out by korenkonder
    public class RBDB
    {
        public XHeader Header;
        public int U00;
        public bool[] PresentCharacters { get; } = new bool[10] {false, false, false, false, false, false, false, false, false, false};
        public List<CharacterItemTable> CharacterItemTables;
        public List<Item> CustomizeItems;

        public void Read(XReader reader)
        {
            Header = new XHeader();
            Header.Read(reader);
            // we wouldn't be here if the ACCT section read loop didn't find this, so no point checking the signature.
            reader.UpdateBasePosition();
            U00 = reader.ReadInt32();
            short tCharacters = reader.ReadInt16();
            short customizeItemCount = reader.ReadInt16();
            reader.ReadOffset(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if ((tCharacters & (0b1 << i)) > 0)
                    {
                        PresentCharacters[i] = true;
                        CharacterItemTable table = new CharacterItemTable();
                        table.Read(reader);
                        table.KeepInFile = true;
                        CharacterItemTables.Add(table);
                    }
                    else
                        CharacterItemTables.Add(new CharacterItemTable());
                }
            });
            reader.ReadOffset(() =>
            {
                for (int i = 0; i < customizeItemCount; i++)
                {
                    Item customizeItem = new Item();
                    customizeItem.Read(reader);
                    CustomizeItems.Add(customizeItem);
                }
            });
            reader.Seek(Header.DataSize, XSeekOrigin.Base);
            // Check for enrs
            // get past the possibility of ENRS
            char[] checkNextSection = reader.CheckNextSection();
            if (checkNextSection[0] == 'E')  // probably enough to make a guess
            {
                reader.SkipNextSection();
            }
            // then the POF1 which is guaranteed
            reader.SkipNextSection();
            // and the EOFC
            reader.SkipNextSection();
        }

        public void Write(XWriter writer)
        {
            writer.WriteHeader(new char[4] {'R', 'B', 'D', 'B'});
            long dataPos = writer.Tell();
            // this could get complicated
            short tCharacters = 0;
            // setup some variables to allocate data later
            int characterItemTableHeadersSize = 0;
            int characterItemEntriesSize = 0;
            int customizeItemEntriesSize;
            int itemObjectsSize = 0;
            int itemTexChangesSize = 0;
            int customizeItemAdjustmentsSize = 0;
            int chritmCostumesSize = 0;
            int chritmCostumePartsSize = 0;
            int itemObjectSetsSize = 0;
            for (int i = 0; i < 10; i++)
            {
                if (PresentCharacters[i])
                {
                    tCharacters += (short)(0b1 << i);
                    characterItemTableHeadersSize += 0x20;
                    characterItemEntriesSize += CharacterItemTables[i].Items.Count() * 0x38;
                    foreach (var item in CharacterItemTables[i].Items)
                    {
                        itemObjectsSize += item.Objects.Count() * 8;
                        itemTexChangesSize += item.TextureChanges.Count() * 8;
                        itemObjectSetsSize += item.ObjectSets.Count() * 4;
                    }
                    customizeItemAdjustmentsSize += CharacterItemTables[i].CommonItemAdjustments.Count() * 0x28;
                    chritmCostumesSize += CharacterItemTables[i].Costumes.Count() * 16;
                    foreach (var cos in CharacterItemTables[i].Costumes)
                    {
                        foreach (var part in cos.Parts)
                        {
                            if (part.ItemNumber != 0)
                                chritmCostumePartsSize += 2;
                        }
                    }
                }
            }
            // then customize items
            customizeItemEntriesSize = CustomizeItems.Count() * 0x38;
            foreach (var item in CustomizeItems)
            {
                itemObjectsSize += item.Objects.Count() * 8;
                itemTexChangesSize += item.TextureChanges.Count() * 8;
                itemObjectSetsSize += item.ObjectSets.Count() * 4;
            }
            // next, align the sizes to 0x10
            // headers
            if (characterItemTableHeadersSize % 0x10 != 0)
                characterItemTableHeadersSize += (0x10 - (characterItemTableHeadersSize % 0x10));
            // item entries
            if (characterItemEntriesSize % 0x10 != 0)
                characterItemEntriesSize += (0x10 - (characterItemEntriesSize % 0x10));
            // customize item entries
            if (customizeItemEntriesSize % 0x10 != 0)
                customizeItemEntriesSize += (0x10 - (customizeItemEntriesSize % 0x10));
            // objects
            if (itemObjectsSize % 0x10 != 0)
                itemObjectsSize += (0x10 - (itemObjectsSize % 0x10));
            // tex changes
            if (itemTexChangesSize % 0x10 != 0)
                itemTexChangesSize += (0x10 - (itemTexChangesSize % 0x10));
            // item adjustments
            if (customizeItemAdjustmentsSize % 0x10 != 0)
                customizeItemAdjustmentsSize += (0x10 - (customizeItemAdjustmentsSize % 0x10));
            // costumes
            if (chritmCostumesSize % 0x10 != 0)
                chritmCostumesSize += (0x10 - (chritmCostumesSize % 0x10));
            // costume parts
            if (chritmCostumePartsSize % 0x10 != 0)
                chritmCostumePartsSize += (0x10 - (chritmCostumePartsSize % 0x10));
            // object sets
            if (itemObjectSetsSize % 0x10 != 0)
                itemObjectSetsSize += (0x10 - (itemObjectSetsSize % 0x10));


            // begin writing
            writer.Write(U00);
            writer.Write(tCharacters);
            writer.Write((short)CustomizeItems.Count());
            // order of writing is as listed:
            // Character Item Table Headers
            // all items from all tables
            // all item objects
            // all texture changes
            // all item adjustments
            // all costumes
            // all costume parts
            // all object sets
            // we can make some educated guesses
            writer.WriteOffset(0x20, dataPos);
            // we have sizes so we know where this will be
            if (CustomizeItems.Count() != 0)
                writer.WriteOffset(0x20 + characterItemTableHeadersSize + characterItemEntriesSize, dataPos);
            else
                writer.Write((long)0);
            writer.Align(16);
            // allocate to the file
            // headers
            long headerPos = writer.Tell();  // the positions indicate the next write position of the data
            writer.WriteNulls(characterItemTableHeadersSize);  // this makes the space for the data
            // character items
            long itemPos = writer.Tell();
            writer.WriteNulls(characterItemEntriesSize);
            // customize items
            long custItemPos = writer.Tell();
            writer.WriteNulls(customizeItemEntriesSize);
            // objects
            long objectPos = writer.Tell();
            writer.WriteNulls(itemObjectsSize);
            // texture changes
            long texChangePos = writer.Tell();
            writer.WriteNulls(itemTexChangesSize);
            // customize item adjustments
            long customizeItemAdjustPos = writer.Tell();
            writer.WriteNulls(customizeItemAdjustmentsSize);
            // costumes
            long costumePos = writer.Tell();
            writer.WriteNulls(chritmCostumesSize);
            // costume parts
            long costumePartPos = writer.Tell();
            writer.WriteNulls(chritmCostumePartsSize);
            // object sets
            long objectSetPos = writer.Tell();
            writer.WriteNulls(itemObjectSetsSize);
            // begin writing the data
            long dataEnd = writer.Tell();
            writer.Seek((int)headerPos, SeekOrigin.Begin);
            
            foreach (var table in CharacterItemTables)
            {
                if (table.KeepInFile)
                {
                    int[] newInfo = table.Write(writer, (int)itemPos, (int)objectPos, (int)texChangePos, (int)objectSetPos, (int)customizeItemAdjustPos, (int)costumePos, (int)costumePartPos, (int)dataPos);
                    itemPos = newInfo[0];
                    objectPos = newInfo[1];
                    texChangePos = newInfo[2];
                    objectSetPos = newInfo[3];
                    customizeItemAdjustPos = newInfo[4];
                    costumePos = newInfo[5];
                    costumePartPos = newInfo[6];
                }
            }
            writer.Seek((int)custItemPos, SeekOrigin.Begin);
            foreach (var item in CustomizeItems)
            {
                int[] newInfo = item.Write(writer, (int)objectPos, (int)texChangePos, (int)objectSetPos, (int)dataPos);
                objectPos = newInfo[0];
                texChangePos = newInfo[1];
                objectSetPos = newInfo[2];
            }
            writer.Seek((int)dataEnd, SeekOrigin.Begin);
            writer.WritePOF1();
            writer.WriteEOFC();
            long contentsEnd = writer.Tell();
            writer.Seek((int)dataPos - 28, SeekOrigin.Begin);
            writer.Write((int)(contentsEnd - dataPos));
            writer.Seek(12, SeekOrigin.Current);
            writer.Write((int)(dataEnd - dataPos));
            writer.Seek((int)contentsEnd, SeekOrigin.Begin);
        }

        public RBDB()
        {
            CharacterItemTables = new List<CharacterItemTable>();
            CustomizeItems = new List<Item>();
        }
    }
}
