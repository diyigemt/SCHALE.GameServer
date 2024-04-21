// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TacticSimulatorSettingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static TacticSimulatorSettingExcel GetRootAsTacticSimulatorSettingExcel(ByteBuffer _bb) { return GetRootAsTacticSimulatorSettingExcel(_bb, new TacticSimulatorSettingExcel()); }
  public static TacticSimulatorSettingExcel GetRootAsTacticSimulatorSettingExcel(ByteBuffer _bb, TacticSimulatorSettingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TacticSimulatorSettingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroundId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GetExp { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GetStarGrade { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Equipment { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.TacticSimulatorSettingExcel> CreateTacticSimulatorSettingExcel(FlatBufferBuilder builder,
      long GroundId = 0,
      long GetExp = 0,
      long GetStarGrade = 0,
      long Equipment = 0) {
    builder.StartTable(4);
    TacticSimulatorSettingExcel.AddEquipment(builder, Equipment);
    TacticSimulatorSettingExcel.AddGetStarGrade(builder, GetStarGrade);
    TacticSimulatorSettingExcel.AddGetExp(builder, GetExp);
    TacticSimulatorSettingExcel.AddGroundId(builder, GroundId);
    return TacticSimulatorSettingExcel.EndTacticSimulatorSettingExcel(builder);
  }

  public static void StartTacticSimulatorSettingExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddGroundId(FlatBufferBuilder builder, long groundId) { builder.AddLong(0, groundId, 0); }
  public static void AddGetExp(FlatBufferBuilder builder, long getExp) { builder.AddLong(1, getExp, 0); }
  public static void AddGetStarGrade(FlatBufferBuilder builder, long getStarGrade) { builder.AddLong(2, getStarGrade, 0); }
  public static void AddEquipment(FlatBufferBuilder builder, long equipment) { builder.AddLong(3, equipment, 0); }
  public static Offset<SCHALE.Common.FlatData.TacticSimulatorSettingExcel> EndTacticSimulatorSettingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.TacticSimulatorSettingExcel>(o);
  }
}


static public class TacticSimulatorSettingExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*GroundId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*GetExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*GetStarGrade*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*Equipment*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}