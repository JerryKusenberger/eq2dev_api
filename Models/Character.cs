using System;
using System.Collections.Generic;

namespace eq2dev_api;

public partial class Character
{
    public uint Id { get; set; }

    public uint AccountId { get; set; }

    public uint ServerId { get; set; }

    public string Name { get; set; } = null!;

    public byte Race { get; set; }

    public byte Class { get; set; }

    public byte Gender { get; set; }

    public byte Deity { get; set; }

    public float BodySize { get; set; }

    public float BodyAge { get; set; }

    public uint CurrentZoneId { get; set; }

    public uint Level { get; set; }

    public byte TradeskillClass { get; set; }

    public uint TradeskillLevel { get; set; }

    public uint SogaWingType { get; set; }

    public uint SogaChestType { get; set; }

    public uint SogaLegsType { get; set; }

    public uint SogaHairType { get; set; }

    public uint SogaFacialHairType { get; set; }

    public uint SogaModelType { get; set; }

    public uint LegsType { get; set; }

    public uint ChestType { get; set; }

    public uint WingType { get; set; }

    public uint HairType { get; set; }

    public uint FacialHairType { get; set; }

    public uint ModelType { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    public float Heading { get; set; }

    public uint InstanceId { get; set; }

    public byte StartingCity { get; set; }

    public byte Deleted { get; set; }

    public int UnixTimestamp { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastPlayed { get; set; }

    public uint LastSaved { get; set; }

    public int AdminStatus { get; set; }

    public byte IsOnline { get; set; }

    public uint GroupId { get; set; }

    public sbyte Alignment { get; set; }

    public byte FirstWorldLogin { get; set; }
}
