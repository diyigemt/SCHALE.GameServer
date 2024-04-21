// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ArenaNPCExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ArenaNPCExcel GetRootAsArenaNPCExcel(ByteBuffer _bb) { return GetRootAsArenaNPCExcel(_bb, new ArenaNPCExcel()); }
  public static ArenaNPCExcel GetRootAsArenaNPCExcel(ByteBuffer _bb, ArenaNPCExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ArenaNPCExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Rank { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NPCAccountLevel { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NPCLevel { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NPCLevelDeviation { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NPCStarGrade { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool UseTSS { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public SCHALE.Common.FlatData.Rarity ExceptionCharacterRarities(int j) { int o = __p.__offset(18); return o != 0 ? (SCHALE.Common.FlatData.Rarity)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.Rarity)0; }
  public int ExceptionCharacterRaritiesLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.Rarity> GetExceptionCharacterRaritiesBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.Rarity>(18, 4); }
#else
  public ArraySegment<byte>? GetExceptionCharacterRaritiesBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public SCHALE.Common.FlatData.Rarity[] GetExceptionCharacterRaritiesArray() { int o = __p.__offset(18); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.Rarity[] a = new SCHALE.Common.FlatData.Rarity[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.Rarity)__p.bb.GetInt(p + i * 4); } return a; }
  public long ExceptionMainCharacterIds(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExceptionMainCharacterIdsLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExceptionMainCharacterIdsBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetExceptionMainCharacterIdsBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetExceptionMainCharacterIdsArray() { return __p.__vector_as_array<long>(20); }
  public long ExceptionSupportCharacterIds(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExceptionSupportCharacterIdsLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExceptionSupportCharacterIdsBytes() { return __p.__vector_as_span<long>(22, 8); }
#else
  public ArraySegment<byte>? GetExceptionSupportCharacterIdsBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public long[] GetExceptionSupportCharacterIdsArray() { return __p.__vector_as_array<long>(22); }
  public long ExceptionTSSIds(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExceptionTSSIdsLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExceptionTSSIdsBytes() { return __p.__vector_as_span<long>(24, 8); }
#else
  public ArraySegment<byte>? GetExceptionTSSIdsBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public long[] GetExceptionTSSIdsArray() { return __p.__vector_as_array<long>(24); }

  public static Offset<SCHALE.Common.FlatData.ArenaNPCExcel> CreateArenaNPCExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      long Rank = 0,
      long NPCAccountLevel = 0,
      long NPCLevel = 0,
      long NPCLevelDeviation = 0,
      long NPCStarGrade = 0,
      bool UseTSS = false,
      VectorOffset ExceptionCharacterRaritiesOffset = default(VectorOffset),
      VectorOffset ExceptionMainCharacterIdsOffset = default(VectorOffset),
      VectorOffset ExceptionSupportCharacterIdsOffset = default(VectorOffset),
      VectorOffset ExceptionTSSIdsOffset = default(VectorOffset)) {
    builder.StartTable(11);
    ArenaNPCExcel.AddNPCStarGrade(builder, NPCStarGrade);
    ArenaNPCExcel.AddNPCLevelDeviation(builder, NPCLevelDeviation);
    ArenaNPCExcel.AddNPCLevel(builder, NPCLevel);
    ArenaNPCExcel.AddNPCAccountLevel(builder, NPCAccountLevel);
    ArenaNPCExcel.AddRank(builder, Rank);
    ArenaNPCExcel.AddUniqueId(builder, UniqueId);
    ArenaNPCExcel.AddExceptionTSSIds(builder, ExceptionTSSIdsOffset);
    ArenaNPCExcel.AddExceptionSupportCharacterIds(builder, ExceptionSupportCharacterIdsOffset);
    ArenaNPCExcel.AddExceptionMainCharacterIds(builder, ExceptionMainCharacterIdsOffset);
    ArenaNPCExcel.AddExceptionCharacterRarities(builder, ExceptionCharacterRaritiesOffset);
    ArenaNPCExcel.AddUseTSS(builder, UseTSS);
    return ArenaNPCExcel.EndArenaNPCExcel(builder);
  }

  public static void StartArenaNPCExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddRank(FlatBufferBuilder builder, long rank) { builder.AddLong(1, rank, 0); }
  public static void AddNPCAccountLevel(FlatBufferBuilder builder, long nPCAccountLevel) { builder.AddLong(2, nPCAccountLevel, 0); }
  public static void AddNPCLevel(FlatBufferBuilder builder, long nPCLevel) { builder.AddLong(3, nPCLevel, 0); }
  public static void AddNPCLevelDeviation(FlatBufferBuilder builder, long nPCLevelDeviation) { builder.AddLong(4, nPCLevelDeviation, 0); }
  public static void AddNPCStarGrade(FlatBufferBuilder builder, long nPCStarGrade) { builder.AddLong(5, nPCStarGrade, 0); }
  public static void AddUseTSS(FlatBufferBuilder builder, bool useTSS) { builder.AddBool(6, useTSS, false); }
  public static void AddExceptionCharacterRarities(FlatBufferBuilder builder, VectorOffset exceptionCharacterRaritiesOffset) { builder.AddOffset(7, exceptionCharacterRaritiesOffset.Value, 0); }
  public static VectorOffset CreateExceptionCharacterRaritiesVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.Rarity[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExceptionCharacterRaritiesVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.Rarity[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionCharacterRaritiesVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.Rarity> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionCharacterRaritiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.Rarity>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExceptionCharacterRaritiesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExceptionMainCharacterIds(FlatBufferBuilder builder, VectorOffset exceptionMainCharacterIdsOffset) { builder.AddOffset(8, exceptionMainCharacterIdsOffset.Value, 0); }
  public static VectorOffset CreateExceptionMainCharacterIdsVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExceptionMainCharacterIdsVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionMainCharacterIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionMainCharacterIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExceptionMainCharacterIdsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddExceptionSupportCharacterIds(FlatBufferBuilder builder, VectorOffset exceptionSupportCharacterIdsOffset) { builder.AddOffset(9, exceptionSupportCharacterIdsOffset.Value, 0); }
  public static VectorOffset CreateExceptionSupportCharacterIdsVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExceptionSupportCharacterIdsVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionSupportCharacterIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionSupportCharacterIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExceptionSupportCharacterIdsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddExceptionTSSIds(FlatBufferBuilder builder, VectorOffset exceptionTSSIdsOffset) { builder.AddOffset(10, exceptionTSSIdsOffset.Value, 0); }
  public static VectorOffset CreateExceptionTSSIdsVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExceptionTSSIdsVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionTSSIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExceptionTSSIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExceptionTSSIdsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.ArenaNPCExcel> EndArenaNPCExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ArenaNPCExcel>(o);
  }
}


static public class ArenaNPCExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Rank*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*NPCAccountLevel*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*NPCLevel*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*NPCLevelDeviation*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*NPCStarGrade*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*UseTSS*/, 1 /*bool*/, 1, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*ExceptionCharacterRarities*/, 4 /*SCHALE.Common.FlatData.Rarity*/, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*ExceptionMainCharacterIds*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 22 /*ExceptionSupportCharacterIds*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 24 /*ExceptionTSSIds*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}