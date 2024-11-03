using System.Diagnostics.CodeAnalysis;

namespace Frosty.Sdk.Managers.Entries;

/// <summary>
/// Types of the Resources. The value is a hash of the name to lower, calculated using <see cref="Utils.Utils.HashString"/>.
/// </summary>
[SuppressMessage("ReSharper", "InconsistentNaming")]
public enum ResourceType : uint
{
    AnimTrackData = 0xD070EED1,
    AntResource = 0xEC1B7BF4,
    AssetBank = 0x51A3C853,
    AtlasGroupResource = 0x1445F2DB,
    AtlasTexture = 0x957C32B1,
    BundleRefTableResource = 0x428EC9D4,
    ClothColliderSetAssetData = 0x8EF3938D,
    CompiledBytecode = 0xE2B02F7,
    CompiledLuaResource = 0xAFECB022,
    CompressedClipData = 0x85548684,
    DelayLoadBundleResource = 0x76742DC8,
    DestructionResource = 0x41CBC351,
    Dx11ShaderProgramDatabase = 0xF04F0C81,
    Dx11NvRvmDatabase = 0xF7CC814D,
    Dx11RvmDatabase = 0x8DA16895,
    Dx12NvRvmDatabase = 0x50E8E7EE,
    Dx12PcRvmDatabase = 0x6B4B6E85,
    DxShaderProgramDatabase = 0x10F0E5A1,
    DxTexture = 0x5C4954A6,
    EAClothAssetData = 0x85AC783D,
    EAClothData = 0x387CA0AD,
    EAClothEntityData = 0x85EA8656,
    EmitterGraphResource = 0x78791C75,
    EnlightenDatabase = 0x70C5CB3E,
    EnlightenShaderDatabase = 0x59CEEB57,
    EnlightenShaderDatabaseResource = 0xB15AD3FD,
    EnlightenStaticDatabase = 0xC6CD3286,
    FaceFxResource = 0x59C79990,
    FifaLuaAssetResource = 0x9584958F,
    FifaPhysicsResourceData = 0xEF23407C,
    FootballMetaMorphMeshDeltaPositionsResource = 0x4C4D624A,
    FootballMetaMorphVertexRegionWeightsResource = 0x59BBF1E8,
    GiGridStreamingGroupResource = 0xF20A477A,
    GtsoLut = 0xCB8BCD07,
    HavokClothPhysicsData = 0xE36F0D59,
    HavokDestructionPhysicsData = 0x4864737B,
    HavokPhysicsData = 0x91043F65,
    HeightfieldDecal = 0x9C4FAA17,
    IesResource = 0x0DEAFE10,
    IShaderDatabase = 0x36F3F2C0,
    LargeParticleCloud = 0xAD1AC4FD,
    LinearMediaAsset = 0x86521D6C,
    LocalizedStringResource = 0x5E862E05,
    MeshAdjancencyResource = 0xBA02FEE0,
    MeshComputeFaceAdjacencyResource = 0x0EDE7594,
    MeshComputeIndexBufferResource = 0x2C3E1E37,
    MeshComputeMeshDefinitionResource = 0x81F0E34F,
    MeshEmitterResource = 0xC611F34A,
    MeshSet = 0x49B156D4,
    MetaMorphTargetMeshResourceAsset = 0x39173AB8,
    MorphMaterialResource = 0x24A019CC,
    MorphResource = 0xEB228507,
    MorphTargetsResource = 0x1091C8C5,
    NavMeshResource = 0x2EBF5E85,
    NewWaveResource = 0xB2C465F6,
    OccluderMesh = 0x30B4A553,
    PamReplayResource = 0xC664A660,
    PathfindingRuntimeResource = 0x4B803D3B,
    PcaComponentWeightsResource = 0x8D9E6F01,
    PersistenceDefRuntimeResource = 0x0EE85483,
    PhysicsResource = 0x41759364,
    PlayerPresetResource = 0x52EE0D39,
    PSDComputeResource = 0x8F20121D,
    PSDResource = 0x3B9D1688,
    PSDWrapResource = 0xB3C7B15C,
    RaceGroundTextureResource = 0xD41D60,
    RagdollResource = 0x319D8CD0,
    RawFileData = 0x3568E2B7,
    RenderTexture = 0x41D57E10,
    RimeTtfFontFile = 0x63994C5,
    ScenarioDefRuntimeResource = 0x2EEC1D7A,
    SerializedAudioPatch = 0x5297A88F,
    SerializedExpressionNodeGraph = 0x7DD4CC89,
    ShaderBlockDepot = 0xD8F5DAAF,
    ShaderBlockDepotAsset = 0xDDB3E17F,
    ShaderBlockDepotResource = 0x73312045,
    SoundResource = 0x68FC328C,
    StrandHairResource = 0xC4841A63,
    SvgImage = 0x89983F10,
    SwfMovie = 0x2D47A5FF,
    TerrainDecals = 0x15E1F32E,
    TerrainLayerCombinations = 0xA23E75DB,
    TerrainStreamingTree = 0x22FE8AC8,
    Texture = 0x6BDE20BA,
    UITtfFontFile = 0x9D00966A,
    VisualTerrain = 0x1CA38E06,
    ZoneStreamerGrid = 0xEFC70728,
    Invalid = 0xFFFFFFFF
}