﻿using JT809.Protocol.Extensions.JT1078.MessageBody;
using JT809.Protocol.Formatters;
using JT809.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT809.Protocol.Extensions.JT1078.Formatters
{
    public class JT809_JT1078_0x9B00_0x9B01_Formatter : IJT809MessagePackFormatter<JT809_JT1078_0x9B00_0x9B01>
    {
        public JT809_JT1078_0x9B00_0x9B01 Deserialize(ref JT809MessagePackReader reader, IJT809Config config)
        {
            JT809_JT1078_0x9B00_0x9B01 jT808_JT1078_0x9B00_0x9B01 = new JT809_JT1078_0x9B00_0x9B01();
            jT808_JT1078_0x9B00_0x9B01.ChannelId = reader.ReadByte();
            jT808_JT1078_0x9B00_0x9B01.StartTime = reader.ReadUTCDateTime();
            jT808_JT1078_0x9B00_0x9B01.EndTime = reader.ReadUTCDateTime();
            jT808_JT1078_0x9B00_0x9B01.AlarmType = reader.ReadUInt64();
            jT808_JT1078_0x9B00_0x9B01.AVItemType = reader.ReadByte();
            jT808_JT1078_0x9B00_0x9B01.StreamType = reader.ReadByte();
            jT808_JT1078_0x9B00_0x9B01.MemType = reader.ReadByte();
            jT808_JT1078_0x9B00_0x9B01.FileSize = reader.ReadUInt32();
            jT808_JT1078_0x9B00_0x9B01.AuthorizeCode = reader.ReadArray(64).ToArray();
            jT808_JT1078_0x9B00_0x9B01.GnssData = reader.ReadArray(36).ToArray();
            return jT808_JT1078_0x9B00_0x9B01;
        }

        public void Serialize(ref JT809MessagePackWriter writer, JT809_JT1078_0x9B00_0x9B01 value, IJT809Config config)
        {
            writer.WriteByte(value.ChannelId);
            writer.WriteUTCDateTime(value.StartTime);
            writer.WriteUTCDateTime(value.EndTime);
            writer.WriteUInt64(value.AlarmType);
            writer.WriteByte(value.AVItemType);
            writer.WriteByte(value.StreamType);
            writer.WriteByte(value.MemType);
            writer.WriteUInt32(value.FileSize);
            writer.WriteArray(value.AuthorizeCode);
            writer.WriteArray(value.GnssData);
        }
    }
}
