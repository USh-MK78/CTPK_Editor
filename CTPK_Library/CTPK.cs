using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTPK_Library
{
    public class CTPK
    {
        public char[] CTPK_Header { get; set; }
        public short Root_CTPKDataCount { get; set; }
        public short CTPKDataCount { get; set; }
        public int ImageDataOffset { get; set; }
        public byte[] UnknownByteData0 { get; set; } //4byte

        public int CTPK_UnknownDataAreaOffset { get; set; } //From : CTPK_Header
        public List<CTPK_UnknownDataArea> CTPKUnknownDataArea_List { get; set; } //CTPK_UnknownDataAreaOffset, Position = 0;
        public class CTPK_UnknownDataArea
        {
            public UnknownByteArea Unknown_ByteArea { get; set; }
            public class UnknownByteArea
            {
                public byte D1 { get; set; }
                public byte D2 { get; set; }
                public byte D3 { get; set; }
                public byte D4 { get; set; }

                public void Read_UnknownByteArea(BinaryReader br)
                {
                    D1 = br.ReadByte();
                    D2 = br.ReadByte();
                    D3 = br.ReadByte();
                    D4 = br.ReadByte();
                }

                public void Write_UnknownByteArea(BinaryWriter bw)
                {
                    bw.Write(D1);
                    bw.Write(D2);
                    bw.Write(D3);
                    bw.Write(D4);
                }

                public UnknownByteArea(byte D1, byte D2, byte D3, byte D4)
                {
                    this.D1 = D1;
                    this.D2 = D2;
                    this.D3 = D3;
                    this.D4 = D4;
                }

                public UnknownByteArea()
                {
                    D1 = 0x00;
                    D2 = 0x00;
                    D3 = 0x00;
                    D4 = 0x00;
                }
            }

            public int Index { get; set; }

            public void Read_CTPK_UnknownDataArea(BinaryReader br)
            {
                Unknown_ByteArea.Read_UnknownByteArea(br);
                Index = br.ReadInt32();
            }

            public void Write_CTPK_UnknownDataArea(BinaryWriter bw)
            {
                Unknown_ByteArea.Write_UnknownByteArea(bw);
                bw.Write(Index);
            }

            public CTPK_UnknownDataArea(UnknownByteArea unknownByteArea, int Index)
            {
                Unknown_ByteArea = unknownByteArea;
                this.Index = Index;
            }

            public CTPK_UnknownDataArea()
            {
                Unknown_ByteArea = new UnknownByteArea(0x00, 0x00, 0x00, 0x00);
                Index = 0;
            }
        }

        public int CTPK_UnknownFlagDataAreaListOffset { get; set; } //From : CTPK_Header
        public List<CTPK_UnknownFlagDataArea> CTPK_UnknownFlagDataArea_List { get; set; }
        public class CTPK_UnknownFlagDataArea
        {
            public byte F1 { get; set; }
            public byte F2 { get; set; }
            public byte F3 { get; set; }
            public byte F4 { get; set; }

            public void Read_CTPK_UnknownFlagDataArea(BinaryReader br)
            {
                F1 = br.ReadByte();
                F2 = br.ReadByte();
                F3 = br.ReadByte();
                F4 = br.ReadByte();
            }

            public void Write_CTPK_UnknownFlagDataArea(BinaryWriter bw)
            {
                bw.Write(F1);
                bw.Write(F2);
                bw.Write(F3);
                bw.Write(F4);
            }

            public CTPK_UnknownFlagDataArea(byte F1, byte F2, byte F3, byte F4)
            {
                this.F1 = F1;
                this.F2 = F2;
                this.F3 = F3;
                this.F4 = F4;
            }

            public CTPK_UnknownFlagDataArea()
            {
                F1 = 0x00;
                F2 = 0x00;
                F3 = 0x00;
                F4 = 0x00;
            }
        }

        public byte[] UnknownByteData1 { get; set; } //4byte

        public List<CTPKData> Root_CTPKDataList { get; set; }
        public List<CTPKData> CTPKDataList { get; set; }
        public class CTPKData
        {
            public byte[] UnknownByteData2 { get; set; } //4byte

            public string Name { get; set; }
            public int CTPK_StringDataOffset { get; set; } //From : CTPK_Header, public string[] or char[] ...

            public byte[] UnknownByteData3 { get; set; } //4byte
            public byte[] UnknownByteData4 { get; set; } //4byte

            public int UnknownData1 { get; set; }
            public short ImageHeight { get; set; }
            public short ImageWidth { get; set; }

            public UnknownByteArea Unknown_ByteArea { get; set; }
            public class UnknownByteArea
            {
                public byte D1 { get; set; }
                public byte D2 { get; set; }
                public byte D3 { get; set; }
                public byte D4 { get; set; }

                public void Read_UnknownByteArea(BinaryReader br)
                {
                    D1 = br.ReadByte();
                    D2 = br.ReadByte();
                    D3 = br.ReadByte();
                    D4 = br.ReadByte();
                }

                public void Write_UnknownByteArea(BinaryWriter bw)
                {
                    bw.Write(D1);
                    bw.Write(D2);
                    bw.Write(D3);
                    bw.Write(D4);
                }

                public UnknownByteArea(byte D1, byte D2, byte D3, byte D4)
                {
                    this.D1 = D1;
                    this.D2 = D2;
                    this.D3 = D3;
                    this.D4 = D4;
                }

                public UnknownByteArea()
                {
                    D1 = 0x00;
                    D2 = 0x00;
                    D3 = 0x00;
                    D4 = 0x00;
                }
            }

            public int UnknownData4 { get; set; }

            public void Read_CTPKData(BinaryReader br)
            {
                UnknownByteData2 = br.ReadBytes(4);

                CTPK_StringDataOffset = br.ReadInt32();
                if (CTPK_StringDataOffset != 0)
                {
                    long Pos = br.BaseStream.Position;

                    br.BaseStream.Seek(CTPK_StringDataOffset, SeekOrigin.Begin);

                    ReadByteLine readByteLine = new ReadByteLine(new List<byte>());
                    readByteLine.ReadByte(br, 0x00);
                    Name = new string(readByteLine.ConvertToCharArray());

                    br.BaseStream.Position = Pos;
                }
                else if (CTPK_StringDataOffset == 256) //0x0100
                {
                    Name = "Excluded Item";
                }

                UnknownByteData3 = br.ReadBytes(4);
                UnknownByteData4 = br.ReadBytes(4);

                UnknownData1 = br.ReadInt32();
                ImageHeight = br.ReadInt16();
                ImageWidth = br.ReadInt16();

                Unknown_ByteArea.Read_UnknownByteArea(br);

                UnknownData4 = br.ReadInt32();
            }

            public void Write_CTPKData(BinaryWriter bw)
            {
                bw.Write(UnknownByteData2);
                bw.Write(CTPK_StringDataOffset);

                bw.Write(UnknownByteData3);
                bw.Write(UnknownByteData4);

                bw.Write(UnknownData1);
                bw.Write(ImageHeight);
                bw.Write(ImageWidth);

                Unknown_ByteArea.Write_UnknownByteArea(bw);

                bw.Write(UnknownData4);
            }

            public CTPKData()
            {
                UnknownByteData2 = new byte[4];

                CTPK_StringDataOffset = 0;

                UnknownByteData3 = new byte[4];
                UnknownByteData4 = new byte[4];

                UnknownData1 = 0;
                ImageHeight = 0;
                ImageWidth = 0;

                Unknown_ByteArea = new UnknownByteArea(0x00, 0x00, 0x00, 0x00);

                UnknownData4 = 0;
            }
        }

        public void Read_CTPK(BinaryReader br)
        {
            CTPK_Header = br.ReadChars(4);
            if (new string(CTPK_Header) != "CTPK") throw new Exception("Unknown Format.");

            //TODO : Reference => Note 1

            Root_CTPKDataCount = br.ReadInt16();
            CTPKDataCount = br.ReadInt16();
            ImageDataOffset = br.ReadInt32();

            UnknownByteData0 = br.ReadBytes(4);

            CTPK_UnknownDataAreaOffset = br.ReadInt32();
            if (CTPK_UnknownDataAreaOffset != 0)
            {
                long Pos = br.BaseStream.Position;

                br.BaseStream.Seek(CTPK_UnknownDataAreaOffset, SeekOrigin.Begin);

                for (int i = 0; i < CTPKDataCount; i++)
                {
                    CTPK_UnknownDataArea cTPK_UnknownDataArea = new CTPK_UnknownDataArea();
                    cTPK_UnknownDataArea.Read_CTPK_UnknownDataArea(br);
                    CTPKUnknownDataArea_List.Add(cTPK_UnknownDataArea);
                }

                br.BaseStream.Position = Pos;
            }

            CTPK_UnknownFlagDataAreaListOffset = br.ReadInt32();
            if (CTPK_UnknownFlagDataAreaListOffset != 0)
            {
                long Pos = br.BaseStream.Position;

                br.BaseStream.Seek(CTPK_UnknownFlagDataAreaListOffset, SeekOrigin.Begin);

                for (int i = 0; i < CTPKDataCount; i++)
                {
                    CTPK_UnknownFlagDataArea cTPK_UnknownFlagDataArea = new CTPK_UnknownFlagDataArea();
                    cTPK_UnknownFlagDataArea.Read_CTPK_UnknownFlagDataArea(br);
                    CTPK_UnknownFlagDataArea_List.Add(cTPK_UnknownFlagDataArea);
                }

                br.BaseStream.Position = Pos;
            }

            UnknownByteData1 = br.ReadBytes(4);

            for (int i = 0; i < CTPKDataCount; i++)
            {
                CTPKData cTPKData = new CTPKData();
                cTPKData.Read_CTPKData(br);
                CTPKDataList.Add(cTPKData);
            }

            for (int i = 0; i < Root_CTPKDataCount; i++)
            {
                CTPKData cTPKData = new CTPKData();
                cTPKData.Read_CTPKData(br);
                Root_CTPKDataList.Add(cTPKData);
            }
        }

        public void Write_CTPK(BinaryWriter bw)
        {

        }

        public CTPK()
        {
            CTPK_Header = "CTPK".ToCharArray();
            Root_CTPKDataCount = 0;
            CTPKDataCount = 0;
            ImageDataOffset = 0;
            UnknownByteData0 = new byte[4];

            CTPK_UnknownDataAreaOffset = 0;
            CTPKUnknownDataArea_List = new List<CTPK_UnknownDataArea>();

            CTPK_UnknownFlagDataAreaListOffset = 0;
            CTPK_UnknownFlagDataArea_List = new List<CTPK_UnknownFlagDataArea>();

            UnknownByteData1 = new byte[4];

            Root_CTPKDataList = new List<CTPKData>();
            CTPKDataList = new List<CTPKData>();
        }
    }
}
