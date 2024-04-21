// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentArchiveBannerOffsetExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentArchiveBannerOffsetExcel GetRootAsEventContentArchiveBannerOffsetExcel(ByteBuffer _bb) { return GetRootAsEventContentArchiveBannerOffsetExcel(_bb, new EventContentArchiveBannerOffsetExcel()); }
  public static EventContentArchiveBannerOffsetExcel GetRootAsEventContentArchiveBannerOffsetExcel(ByteBuffer _bb, EventContentArchiveBannerOffsetExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentArchiveBannerOffsetExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float OffsetX { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float OffsetY { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ScaleX { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ScaleY { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<SCHALE.Common.FlatData.EventContentArchiveBannerOffsetExcel> CreateEventContentArchiveBannerOffsetExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      float OffsetX = 0.0f,
      float OffsetY = 0.0f,
      float ScaleX = 0.0f,
      float ScaleY = 0.0f) {
    builder.StartTable(5);
    EventContentArchiveBannerOffsetExcel.AddEventContentId(builder, EventContentId);
    EventContentArchiveBannerOffsetExcel.AddScaleY(builder, ScaleY);
    EventContentArchiveBannerOffsetExcel.AddScaleX(builder, ScaleX);
    EventContentArchiveBannerOffsetExcel.AddOffsetY(builder, OffsetY);
    EventContentArchiveBannerOffsetExcel.AddOffsetX(builder, OffsetX);
    return EventContentArchiveBannerOffsetExcel.EndEventContentArchiveBannerOffsetExcel(builder);
  }

  public static void StartEventContentArchiveBannerOffsetExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddOffsetX(FlatBufferBuilder builder, float offsetX) { builder.AddFloat(1, offsetX, 0.0f); }
  public static void AddOffsetY(FlatBufferBuilder builder, float offsetY) { builder.AddFloat(2, offsetY, 0.0f); }
  public static void AddScaleX(FlatBufferBuilder builder, float scaleX) { builder.AddFloat(3, scaleX, 0.0f); }
  public static void AddScaleY(FlatBufferBuilder builder, float scaleY) { builder.AddFloat(4, scaleY, 0.0f); }
  public static Offset<SCHALE.Common.FlatData.EventContentArchiveBannerOffsetExcel> EndEventContentArchiveBannerOffsetExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EventContentArchiveBannerOffsetExcel>(o);
  }
}


static public class EventContentArchiveBannerOffsetExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*OffsetX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*OffsetY*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ScaleX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ScaleY*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}