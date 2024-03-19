﻿using System.ComponentModel.DataAnnotations;

namespace VehicleTable;

public partial class Vehicle
{
    [Key]
    public long CId { get; set; }

    public string? CIdOnSource { get; set; }

    public byte CSource { get; set; }

    public string? CUrl { get; set; }

    public DateTime? CCreatedDate { get; set; }

    public DateTime? CUpdateDate { get; set; }

    public DateTime CParsingDate { get; set; }

    public string? CSalerId { get; set; }

    public string? CSalerName { get; set; }

    public string? CTitle { get; set; }

    public byte CType { get; set; }

    public byte? CSubType { get; set; }

    public short? CBrand { get; set; }

    public string? CBrandName { get; set; }

    public string? CModel { get; set; }

    public string? CSuperGen { get; set; }

    public string? CVendor { get; set; }

    public byte CRegion { get; set; }

    public string? CLocation { get; set; }

    public long? CLocationId { get; set; }

    public string? CAddressOrigin { get; set; }

    public float? CLatitude { get; set; }

    public float? CLongitude { get; set; }

    public string? CSubwayStations { get; set; }

    public string? CSubwayStationsDistances { get; set; }

    public short? CProductionYear { get; set; }

    public DateTime? CPurchaseDate { get; set; }

    public int? CMileage { get; set; }

    public string? CMileageInfo { get; set; }

    public short? COwnersCount { get; set; }

    public bool? CStateNotBeaten { get; set; }

    public bool? CIsNew { get; set; }

    public string? CDescription { get; set; }

    public long? CPrice { get; set; }

    public bool? CPtsOriginal { get; set; }

    public bool? CCustomCleared { get; set; }

    public string? CVinResolution { get; set; }

    public byte? CVinResolutionsType { get; set; }

    public bool? CRegisteredInRussia { get; set; }

    public string? CRegisteredInRussiaString { get; set; }

    public string? CAvailability { get; set; }

    public bool? CWithNds { get; set; }

    public string? CColorHex { get; set; }

    public string? CColorName { get; set; }

    public string? CBodyType { get; set; }

    public string? CMainTechParam { get; set; }

    public byte? CSteeringWheel { get; set; }

    public string? CSteeringPower { get; set; }

    public string? CGearTypeName { get; set; }

    public string? CClimatControl { get; set; }

    public string? CSalon { get; set; }

    public string? CLights { get; set; }

    public string? CPowerWindow { get; set; }

    public string? CAudio { get; set; }

    public string? CDisks { get; set; }

    public byte? CGearType { get; set; }

    public string? CEngineTypeName { get; set; }

    public byte? CEngineType { get; set; }

    public string? CTransmissionName { get; set; }

    public byte? CTransmissionsType { get; set; }

    public decimal? CDisplacement { get; set; }

    public int? CPower { get; set; }

    public int? CPowerKvt { get; set; }

    public byte? CDoorsCount { get; set; }

    public Guid CAdGuid { get; set; }

    public float? CAcceleration { get; set; }

    public int? CClearanceMin { get; set; }

    public float? CFuelRate { get; set; }

    public decimal? CLoading { get; set; }

    public byte? CAxlesСount { get; set; }

    public string? CBrakes { get; set; }

    public string? CTrailerType { get; set; }

    public bool? CIsDeleted { get; set; }

    public DateTime COriginDate { get; set; }

    public string? CBrandKmu { get; set; }

    public int CBucketCapacity { get; set; }

    public string? CCabinHeight { get; set; }

    public string? CCabinType { get; set; }

    public string? CChassisLength { get; set; }

    public string? CCondition { get; set; }

    public string? CEcoClass { get; set; }

    public string? CExtraType { get; set; }

    public string? CHasChassi { get; set; }

    public string? CHasKmu { get; set; }

    public string? CHasTrailer { get; set; }

    public decimal? CMaxLoading { get; set; }

    public string? CModelKmu { get; set; }

    public string? CModification { get; set; }

    public int? CMotoHours { get; set; }

    public string? CPts { get; set; }

    public string? CSeries { get; set; }

    public string? CSpeciality { get; set; }

    public string? CSuspension { get; set; }

    public string? CTrim { get; set; }

    public string? CVarietyType { get; set; }

    public string? CWeelFormula { get; set; }

    public bool CIsRecovered { get; set; }
}
