// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterLevelExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterLevelExcel GetRootAsCharacterLevelExcel(ByteBuffer _bb) { return GetRootAsCharacterLevelExcel(_bb, new CharacterLevelExcel()); }
  public static CharacterLevelExcel GetRootAsCharacterLevelExcel(ByteBuffer _bb, CharacterLevelExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterLevelExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long Exp { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TotalExp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.CharacterLevelExcel> CreateCharacterLevelExcel(FlatBufferBuilder builder,
      int Level = 0,
      long Exp = 0,
      long TotalExp = 0) {
    builder.StartTable(3);
    CharacterLevelExcel.AddTotalExp(builder, TotalExp);
    CharacterLevelExcel.AddExp(builder, Exp);
    CharacterLevelExcel.AddLevel(builder, Level);
    return CharacterLevelExcel.EndCharacterLevelExcel(builder);
  }

  public static void StartCharacterLevelExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(0, level, 0); }
  public static void AddExp(FlatBufferBuilder builder, long exp) { builder.AddLong(1, exp, 0); }
  public static void AddTotalExp(FlatBufferBuilder builder, long totalExp) { builder.AddLong(2, totalExp, 0); }
  public static Offset<SCHALE.Common.FlatData.CharacterLevelExcel> EndCharacterLevelExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CharacterLevelExcel>(o);
  }
}


static public class CharacterLevelExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Level*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Exp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*TotalExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}