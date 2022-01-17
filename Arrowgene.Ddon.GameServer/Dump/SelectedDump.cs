﻿using Arrowgene.Ddon.Server.Network;

namespace Arrowgene.Ddon.GameServer.Dump
{
    public class SelectedDump
    {
        // only the finest dump of the dumpster
        
        public static byte[] data_Dump_93047 = new byte[] /* 13.0.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x8F, 0x0, 0x0, 0x0, 0x0,
            0xA, 0x0, 0xC1, 0xA5, 0xB6, 0x67, 0x3, 0x1, 0xB, 0x8, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0,
            0x2, 0x4, 0x3, 0x0, 0x0, 0xC, 0x56, 0x0, 0x0, 0x0, 0x0, 0x0, 0x64, 0x0, 0x64, 0x0,
            0x0, 0x0, 0x1, 0x0, 0x4, 0x0, 0x0, 0x2, 0x1, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0
        };

        public static Packet Dump_93047 = new Packet(new PacketId(13, 0, 2, "S2C_INSTANCE_GET_ENEMY_SET_LIST_RES"), data_Dump_93047);

        public static byte[] data_Dump_93283 = new byte[] /* 13.5.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x8F, 0x0, 0x0, 0x0, 0x0,
            0xFA, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0xB1, 0xD3, 0x80, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0xA1, 0x0, 0x1, 0x1
        };

        public static Packet Dump_93283 = new Packet(new PacketId(13, 5, 2, "S2C_INSTANCE_GET_ITEM_SET_LIST_RES"), data_Dump_93283);


        public static byte[] data_Dump_1715 = new byte[] /* 35.7.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x9F, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x7, 0xD0, 0x40, 0x1
        };

        public static Packet Dump_1715 = new Packet(new PacketId(35, 7, 2, "S2C_CONTEXT_GET_SET_CONTEXT_RES"), data_Dump_1715);
    }
}