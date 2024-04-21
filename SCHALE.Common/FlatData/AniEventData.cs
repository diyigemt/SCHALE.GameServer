// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AniEventData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AniEventData GetRootAsAniEventData(ByteBuffer _bb) { return GetRootAsAniEventData(_bb, new AniEventData()); }
  public static AniEventData GetRootAsAniEventData(ByteBuffer _bb, AniEventData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AniEventData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public float Time { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int IntParam { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float FloatParam { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string StringParam { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStringParamBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetStringParamBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetStringParamArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<SCHALE.Common.FlatData.AniEventData> CreateAniEventData(FlatBufferBuilder builder,
      StringOffset NameOffset = default(StringOffset),
      float Time = 0.0f,
      int IntParam = 0,
      float FloatParam = 0.0f,
      StringOffset StringParamOffset = default(StringOffset)) {
    builder.StartTable(5);
    AniEventData.AddStringParam(builder, StringParamOffset);
    AniEventData.AddFloatParam(builder, FloatParam);
    AniEventData.AddIntParam(builder, IntParam);
    AniEventData.AddTime(builder, Time);
    AniEventData.AddName(builder, NameOffset);
    return AniEventData.EndAniEventData(builder);
  }

  public static void StartAniEventData(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddTime(FlatBufferBuilder builder, float time) { builder.AddFloat(1, time, 0.0f); }
  public static void AddIntParam(FlatBufferBuilder builder, int intParam) { builder.AddInt(2, intParam, 0); }
  public static void AddFloatParam(FlatBufferBuilder builder, float floatParam) { builder.AddFloat(3, floatParam, 0.0f); }
  public static void AddStringParam(FlatBufferBuilder builder, StringOffset stringParamOffset) { builder.AddOffset(4, stringParamOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.AniEventData> EndAniEventData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.AniEventData>(o);
  }
}


static public class AniEventDataVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Name*/, false)
      && verifier.VerifyField(tablePos, 6 /*Time*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*IntParam*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*FloatParam*/, 4 /*float*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*StringParam*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}