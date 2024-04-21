// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterWeaponExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterWeaponExcel GetRootAsCharacterWeaponExcel(ByteBuffer _bb) { return GetRootAsCharacterWeaponExcel(_bb, new CharacterWeaponExcel()); }
  public static CharacterWeaponExcel GetRootAsCharacterWeaponExcel(ByteBuffer _bb, CharacterWeaponExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterWeaponExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ImagePath { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetImagePathBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetImagePathArray() { return __p.__vector_as_array<byte>(6); }
  public long SetRecipe { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.StatLevelUpType StatLevelUpType { get { int o = __p.__offset(10); return o != 0 ? (SCHALE.Common.FlatData.StatLevelUpType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.StatLevelUpType.Standard; } }
  public long AttackPower { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackPower100 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHP { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHP100 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HealPower { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HealPower100 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool Unlock(int j) { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(__p.__vector(o) + j * 1) : false; }
  public int UnlockLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<bool> GetUnlockBytes() { return __p.__vector_as_span<bool>(24, 1); }
#else
  public ArraySegment<byte>? GetUnlockBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public bool[] GetUnlockArray() { return __p.__vector_as_array<bool>(24); }
  public long RecipeId(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RecipeIdLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRecipeIdBytes() { return __p.__vector_as_span<long>(26, 8); }
#else
  public ArraySegment<byte>? GetRecipeIdBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public long[] GetRecipeIdArray() { return __p.__vector_as_array<long>(26); }
  public int MaxLevel(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MaxLevelLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMaxLevelBytes() { return __p.__vector_as_span<int>(28, 4); }
#else
  public ArraySegment<byte>? GetMaxLevelBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public int[] GetMaxLevelArray() { return __p.__vector_as_array<int>(28); }
  public string LearnSkillSlot(int j) { int o = __p.__offset(30); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int LearnSkillSlotLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
  public SCHALE.Common.FlatData.EquipmentOptionType StatType(int j) { int o = __p.__offset(32); return o != 0 ? (SCHALE.Common.FlatData.EquipmentOptionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.EquipmentOptionType)0; }
  public int StatTypeLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.EquipmentOptionType> GetStatTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.EquipmentOptionType>(32, 4); }
#else
  public ArraySegment<byte>? GetStatTypeBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public SCHALE.Common.FlatData.EquipmentOptionType[] GetStatTypeArray() { int o = __p.__offset(32); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.EquipmentOptionType[] a = new SCHALE.Common.FlatData.EquipmentOptionType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.EquipmentOptionType)__p.bb.GetInt(p + i * 4); } return a; }
  public long StatValue(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StatValueLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStatValueBytes() { return __p.__vector_as_span<long>(34, 8); }
#else
  public ArraySegment<byte>? GetStatValueBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public long[] GetStatValueArray() { return __p.__vector_as_array<long>(34); }

  public static Offset<SCHALE.Common.FlatData.CharacterWeaponExcel> CreateCharacterWeaponExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset ImagePathOffset = default(StringOffset),
      long SetRecipe = 0,
      SCHALE.Common.FlatData.StatLevelUpType StatLevelUpType = SCHALE.Common.FlatData.StatLevelUpType.Standard,
      long AttackPower = 0,
      long AttackPower100 = 0,
      long MaxHP = 0,
      long MaxHP100 = 0,
      long HealPower = 0,
      long HealPower100 = 0,
      VectorOffset UnlockOffset = default(VectorOffset),
      VectorOffset RecipeIdOffset = default(VectorOffset),
      VectorOffset MaxLevelOffset = default(VectorOffset),
      VectorOffset LearnSkillSlotOffset = default(VectorOffset),
      VectorOffset StatTypeOffset = default(VectorOffset),
      VectorOffset StatValueOffset = default(VectorOffset)) {
    builder.StartTable(16);
    CharacterWeaponExcel.AddHealPower100(builder, HealPower100);
    CharacterWeaponExcel.AddHealPower(builder, HealPower);
    CharacterWeaponExcel.AddMaxHP100(builder, MaxHP100);
    CharacterWeaponExcel.AddMaxHP(builder, MaxHP);
    CharacterWeaponExcel.AddAttackPower100(builder, AttackPower100);
    CharacterWeaponExcel.AddAttackPower(builder, AttackPower);
    CharacterWeaponExcel.AddSetRecipe(builder, SetRecipe);
    CharacterWeaponExcel.AddId(builder, Id);
    CharacterWeaponExcel.AddStatValue(builder, StatValueOffset);
    CharacterWeaponExcel.AddStatType(builder, StatTypeOffset);
    CharacterWeaponExcel.AddLearnSkillSlot(builder, LearnSkillSlotOffset);
    CharacterWeaponExcel.AddMaxLevel(builder, MaxLevelOffset);
    CharacterWeaponExcel.AddRecipeId(builder, RecipeIdOffset);
    CharacterWeaponExcel.AddUnlock(builder, UnlockOffset);
    CharacterWeaponExcel.AddStatLevelUpType(builder, StatLevelUpType);
    CharacterWeaponExcel.AddImagePath(builder, ImagePathOffset);
    return CharacterWeaponExcel.EndCharacterWeaponExcel(builder);
  }

  public static void StartCharacterWeaponExcel(FlatBufferBuilder builder) { builder.StartTable(16); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddImagePath(FlatBufferBuilder builder, StringOffset imagePathOffset) { builder.AddOffset(1, imagePathOffset.Value, 0); }
  public static void AddSetRecipe(FlatBufferBuilder builder, long setRecipe) { builder.AddLong(2, setRecipe, 0); }
  public static void AddStatLevelUpType(FlatBufferBuilder builder, SCHALE.Common.FlatData.StatLevelUpType statLevelUpType) { builder.AddInt(3, (int)statLevelUpType, 0); }
  public static void AddAttackPower(FlatBufferBuilder builder, long attackPower) { builder.AddLong(4, attackPower, 0); }
  public static void AddAttackPower100(FlatBufferBuilder builder, long attackPower100) { builder.AddLong(5, attackPower100, 0); }
  public static void AddMaxHP(FlatBufferBuilder builder, long maxHP) { builder.AddLong(6, maxHP, 0); }
  public static void AddMaxHP100(FlatBufferBuilder builder, long maxHP100) { builder.AddLong(7, maxHP100, 0); }
  public static void AddHealPower(FlatBufferBuilder builder, long healPower) { builder.AddLong(8, healPower, 0); }
  public static void AddHealPower100(FlatBufferBuilder builder, long healPower100) { builder.AddLong(9, healPower100, 0); }
  public static void AddUnlock(FlatBufferBuilder builder, VectorOffset unlockOffset) { builder.AddOffset(10, unlockOffset.Value, 0); }
  public static VectorOffset CreateUnlockVector(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddBool(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnlockVectorBlock(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnlockVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnlockVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<bool>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnlockVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddRecipeId(FlatBufferBuilder builder, VectorOffset recipeIdOffset) { builder.AddOffset(11, recipeIdOffset.Value, 0); }
  public static VectorOffset CreateRecipeIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRecipeIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRecipeIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRecipeIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRecipeIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMaxLevel(FlatBufferBuilder builder, VectorOffset maxLevelOffset) { builder.AddOffset(12, maxLevelOffset.Value, 0); }
  public static VectorOffset CreateMaxLevelVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMaxLevelVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxLevelVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxLevelVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMaxLevelVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLearnSkillSlot(FlatBufferBuilder builder, VectorOffset learnSkillSlotOffset) { builder.AddOffset(13, learnSkillSlotOffset.Value, 0); }
  public static VectorOffset CreateLearnSkillSlotVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateLearnSkillSlotVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLearnSkillSlotVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLearnSkillSlotVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLearnSkillSlotVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStatType(FlatBufferBuilder builder, VectorOffset statTypeOffset) { builder.AddOffset(14, statTypeOffset.Value, 0); }
  public static VectorOffset CreateStatTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.EquipmentOptionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.EquipmentOptionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStatValue(FlatBufferBuilder builder, VectorOffset statValueOffset) { builder.AddOffset(15, statValueOffset.Value, 0); }
  public static VectorOffset CreateStatValueVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatValueVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatValueVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatValueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatValueVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.CharacterWeaponExcel> EndCharacterWeaponExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CharacterWeaponExcel>(o);
  }
}


static public class CharacterWeaponExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*ImagePath*/, false)
      && verifier.VerifyField(tablePos, 8 /*SetRecipe*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*StatLevelUpType*/, 4 /*SCHALE.Common.FlatData.StatLevelUpType*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*AttackPower*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*AttackPower100*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*MaxHP*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*MaxHP100*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*HealPower*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*HealPower100*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 24 /*Unlock*/, 1 /*bool*/, false)
      && verifier.VerifyVectorOfData(tablePos, 26 /*RecipeId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*MaxLevel*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 30 /*LearnSkillSlot*/, false)
      && verifier.VerifyVectorOfData(tablePos, 32 /*StatType*/, 4 /*SCHALE.Common.FlatData.EquipmentOptionType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 34 /*StatValue*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}