﻿using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientWeightData
    {
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public DateTime? LapBandDate { get; set; }
        public string Notes { get; set; }
        public decimal? Height { get; set; }
        public decimal? StartWeight { get; set; }
        public DateTime? StartWeightDate { get; set; }
        public decimal? IdealWeight { get; set; }
        public decimal? CurrentWeight { get; set; }
        public decimal? OpWeight { get; set; }
        public decimal? TargetWeight { get; set; }
        public bool? Excluded { get; set; }
        public decimal? LastReservoirVol { get; set; }
        public bool? Losttofollowup { get; set; }
        public decimal? StartBmiweight { get; set; }
        public decimal? Bmiheight { get; set; }
        public string LastImageLocation { get; set; }
        public DateTime? LastImageDate { get; set; }
        public string SurgeryType { get; set; }
        public string Approach { get; set; }
        public string Category { get; set; }
        public string Group { get; set; }
        public DateTime? BaseAssessmentDate { get; set; }
        public string BaseOtherDetails { get; set; }
        public bool? BaseHypertensionProblems { get; set; }
        public string BaseBloodPressureRxDetails { get; set; }
        public int? BaseSystolicBp { get; set; }
        public int? BaseDiastolicBp { get; set; }
        public bool? HypertensionResolved { get; set; }
        public DateTime? HypertensionResolvedDate { get; set; }
        public int? HypertensionResolvedSystolic { get; set; }
        public int? HypertensionResolvedDiastolic { get; set; }
        public bool? BaseLipidProblems { get; set; }
        public string BaseLipidRxDetails { get; set; }
        public decimal? BaseTriglycerides { get; set; }
        public decimal? BaseTotalCholesterol { get; set; }
        public decimal? BaseHdlcholesterol { get; set; }
        public bool? LipidsResolved { get; set; }
        public DateTime? LipidsResolvedDate { get; set; }
        public bool? BaseDiabetesProblems { get; set; }
        public string BaseDiabetesRxDetails { get; set; }
        public bool? DiabetesResolved { get; set; }
        public DateTime? DiabetesResolvedDate { get; set; }
        public int? DiabetesResolvedFbglucose { get; set; }
        public bool? BaseAsthmaProblems { get; set; }
        public string BaseAsthmaLevel { get; set; }
        public string BaseAsthmaDetails { get; set; }
        public bool? AsthmaResolved { get; set; }
        public DateTime? AsthmaResolvedDate { get; set; }
        public string AsthmaResolvedLevel { get; set; }
        public string AsthmaCurrentLevel { get; set; }
        public bool? BaseRefluxProblems { get; set; }
        public string BaseRefluxDetails { get; set; }
        public string BaseRefluxLevel { get; set; }
        public bool? RefluxResolved { get; set; }
        public DateTime? RefluxResolvedDate { get; set; }
        public string RefluxResolvedLevel { get; set; }
        public string RefluxCurrentLevel { get; set; }
        public bool? BaseOtherRx { get; set; }
        public string BaseOtherRxDetails { get; set; }
        public bool? BaseSleepProblems { get; set; }
        public string BaseSleepDetails { get; set; }
        public string BaseSleepLevel { get; set; }
        public bool? SleepResolved { get; set; }
        public DateTime? SleepResolvedDate { get; set; }
        public string SleepResolvedLevel { get; set; }
        public string SleepCurrentLevel { get; set; }
        public bool? BaseFertilityProblems { get; set; }
        public string BaseFertilityLevel { get; set; }
        public string BaseFertilityDetails { get; set; }
        public bool? FertilityResolved { get; set; }
        public DateTime? FertilityResolvedDate { get; set; }
        public string FertilityResolvedLevel { get; set; }
        public string FertilityCurrentLevel { get; set; }
        public bool? BaseArthritisProblems { get; set; }
        public string BaseArthritisDetails { get; set; }
        public string BaseArthritisLevel { get; set; }
        public bool? ArthritisResolved { get; set; }
        public DateTime? ArthritisResolvedDate { get; set; }
        public string ArthritisResolvedLevel { get; set; }
        public string ArthritisCurrentLevel { get; set; }
        public bool? BaseIncontinenceProblems { get; set; }
        public string BaseIncontinenceDetails { get; set; }
        public string BaseIncontinenceLevel { get; set; }
        public bool? IncontinenceResolved { get; set; }
        public DateTime? IncontinenceResolvedDate { get; set; }
        public string IncontinenceResolvedLevel { get; set; }
        public string IncontinenceCurrentLevel { get; set; }
        public bool? BaseBackProblems { get; set; }
        public string BaseBackDetails { get; set; }
        public string BaseBackPainLevel { get; set; }
        public bool? BackResolved { get; set; }
        public DateTime? BackResolvedDate { get; set; }
        public string BackResolvedLevel { get; set; }
        public string BackCurrentLevel { get; set; }
        public bool? BaseCvdproblems { get; set; }
        public string BaseCvddetails { get; set; }
        public string BaseCvdlevel { get; set; }
        public bool? CvdlevelResolved { get; set; }
        public DateTime? CvdlevelResolvedDate { get; set; }
        public string CvdlevelCurrentLevel { get; set; }
        public string CvdlevelResolvedLevel { get; set; }
        public decimal? StartNeck { get; set; }
        public decimal? StartWaist { get; set; }
        public decimal? StartHip { get; set; }
        public decimal? BaseBodyFat { get; set; }
        public decimal? BaseFatMass { get; set; }
        public decimal? BaseBmr { get; set; }
        public decimal? BaseImpedance { get; set; }
        public decimal? BaseFatPerCent { get; set; }
        public decimal? BaseFreeFatMass { get; set; }
        public decimal? BaseTotalBodyWater { get; set; }
        public int? BaseHomocysteine { get; set; }
        public int? BaseTsh { get; set; }
        public int? BaseT4 { get; set; }
        public int? BaseT3 { get; set; }
        public decimal? BaseHba1c { get; set; }
        public decimal? BaseFserumInsulin { get; set; }
        public decimal? BaseFbloodGlucose { get; set; }
        public decimal? BaseIron { get; set; }
        public decimal? BaseFerritin { get; set; }
        public decimal? BaseTransferrin { get; set; }
        public decimal? BaseIbc { get; set; }
        public decimal? BaseFolate { get; set; }
        public decimal? BaseB12 { get; set; }
        public decimal? BaseHemoglobin { get; set; }
        public decimal? BasePlatelets { get; set; }
        public decimal? BaseWcc { get; set; }
        public decimal? BaseCalcium { get; set; }
        public decimal? BasePhosphate { get; set; }
        public decimal? BaseVitD { get; set; }
        public decimal? BaseBilirubin { get; set; }
        public decimal? BaseTprotein { get; set; }
        public decimal? BaseAlkPhos { get; set; }
        public decimal? BaseAlt { get; set; }
        public decimal? BaseAst { get; set; }
        public decimal? BaseGgt { get; set; }
        public decimal? BaseCpk { get; set; }
        public decimal? BaseAlbumin { get; set; }
        public decimal? BaseSodium { get; set; }
        public decimal? BasePotassium { get; set; }
        public decimal? BaseChloride { get; set; }
        public decimal? BaseBicarbonate { get; set; }
        public decimal? BaseUrea { get; set; }
        public decimal? BaseCreatinine { get; set; }
        public string BaseUserField1 { get; set; }
        public string BaseUserField2 { get; set; }
        public string BaseUserField3 { get; set; }
        public string BaseUserField4 { get; set; }
        public string BaseUserField5 { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? NextComorbidVisit { get; set; }
        public decimal? ComorbidityMonths { get; set; }
        public bool? ComorbidtyOnFile { get; set; }
        public decimal? OpBmiweight { get; set; }
        public decimal? BaseLdlcholesterol { get; set; }
        public string BaseUserMemoField1 { get; set; }
        public string BaseUserMemoField2 { get; set; }
        public string BaseReason7 { get; set; }
        public string BaseReason8 { get; set; }
        public decimal? Bmi { get; set; }
        public bool? BaseHdlcholesterolProblems { get; set; }
        public bool? BaseTriglycerideProblems { get; set; }
        public bool? BaseBaselineHstatus { get; set; }
        public bool? BaseCholesterolProblems { get; set; }
        public DateTime? BaseOtherProblems { get; set; }
        public bool? BaseDiabetesRx { get; set; }
        public bool? BaseLipidRx { get; set; }
        public bool? BaseBloodPressureRx { get; set; }
        public decimal? BaseBloodGlucoseLevel { get; set; }
        public decimal? FirstVisitWeight { get; set; }
        public decimal? BaseBmc { get; set; }
        public decimal? BaseLeanBodyMass { get; set; }
        public decimal? BaseBodyFatPc { get; set; }
        public decimal? BaseBmipercentile { get; set; }
        public decimal? BaseZscore { get; set; }
        public bool? Comdata { get; set; }
        public string Status { get; set; }
        public string MaxWeightYr { get; set; }
        public decimal? MaxWeight { get; set; }
        public bool? Updated { get; set; }
        public bool? PatientReport { get; set; }
        public bool? ProcedureReport { get; set; }
        public short? TempFlag { get; set; }
        public string LapbandType { get; set; }
        public string LapbandSize { get; set; }
        public int? StartPr { get; set; }
        public int? StartRr { get; set; }
        public int? StartBp1 { get; set; }
        public int? StartBp2 { get; set; }
        public string InRoomTime { get; set; }
        public string OutRoomTime { get; set; }
        public string SurgeryStartTime { get; set; }
        public string SurgeryEndTime { get; set; }
        public string FirstAssistant { get; set; }
        public string PreopHematocrit { get; set; }
        public DateTime? PreopHematocritDate { get; set; }
        public string PreopAlbumin { get; set; }
        public DateTime? PreopAlbuminDate { get; set; }
        public string OtherProcedure { get; set; }
        public string Asacode { get; set; }
        public string Concurrent { get; set; }
        public DateTime? DischargeDate { get; set; }
        public decimal? BloodTransfusion { get; set; }
        public int? NumberBloodTranfusion { get; set; }
        public int? NumberIntraopTranfusion { get; set; }
        public bool? UnplannedAdmission { get; set; }
        public bool? TransferAcuteCare { get; set; }
        public DateTime? ZeroDate { get; set; }
        public int? VisitWeeksFlag { get; set; }
    }
}