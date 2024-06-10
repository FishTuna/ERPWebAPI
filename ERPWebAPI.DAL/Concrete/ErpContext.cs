using Core.Entities.Concrete;
using Core.Invocations;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.DASHBOARD;
using ERPWebAPI.EL.Concrete.GRAPHS;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete.LGN;
using ERPWebAPI.EL.Concrete.OHS;
using ERPWebAPI.EL.Concrete.PRF;
using ERPWebAPI.EL.Concrete.RPT;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete.TA;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete
{
    public class ErpContext : DbContext
    {
        //public ErpContext(DbContextOptions<ErpContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"server=YDC_ALIENWARE\AW_SQL2022;database=ERP;User ID = sa; Password = 3474399;Encrypt=False"

            optionsBuilder.UseSqlServer($"server={DbConnectionInfo.Server};" +
                         $"database={PasswordCodder.Base64Decode(DbConnectionInfo.DatabaseName)};" +
                         $"User ID = {PasswordCodder.Base64Decode(DbConnectionInfo.User)}; " +
                         $"Password = {PasswordCodder.Base64Decode(DbConnectionInfo.Password)};" +
                         $"Encrypt={DbConnectionInfo.Encrypt}");
        }

        #region DashBoard
        public DbSet<CommonGraph> CommonGraphs { get; set; }
        public DbSet<DashBoardElement> DashBoardElements { get; set; }
        public DbSet<DashBoardListHeader> DashBoardListHeaders { get; set; }
        public DbSet<DashBoardListDetail> DashBoardListDetails { get; set; }
        #endregion DashBoard

        #region HR
        public DbSet<HR_cmb_BloodType> HrBloodTypes { get; set; }
        public DbSet<HR_cmb_Collar> HrCollars { get; set; }
        public DbSet<HR_cmb_Company> HrCompanies { get; set; }
        public DbSet<HR_cmb_ContactInfoType> HrContactInfoTypes { get; set; }
        public DbSet<HR_cmb_ContactType> HrContactTypes { get; set; }
        public DbSet<HR_cmb_CostCenter> HrCostCenters { get; set; }
        public DbSet<HR_cmb_Department> HrDepartments { get; set; }
        public DbSet<HR_cmb_EducationStatu> HrEducationStatus { get; set; }
        public DbSet<HR_cmb_GraduationType> HrGraduationTypes { get; set; }
        public DbSet<HR_cmb_Job> HrJobs { get; set; }
        public DbSet<HR_cmb_Location> HrLocations { get; set; }
        public DbSet<HR_cmb_MaritalStatu> HrMaritalStatus { get; set; }
        public DbSet<HR_cmb_MilitaryStatusType> HrMilitaryStatusTypes { get; set; }
        public DbSet<HR_cmb_MissingDayReason> HrMissingDayReasons { get; set; }
        public DbSet<HR_cmb_Position> HrPositions { get; set; }
        public DbSet<HR_cmb_QuitReason> HrQuitReasons { get; set; }
        public DbSet<HR_cmb_School> HrSchools { get; set; }
        public DbSet<HR_cmb_SchoolDepartment> HrSchoolDepartments { get; set; }
        public DbSet<HR_tbl_SchoolLocation> HrSchoolLocations { get; set; }
        public DbSet<HR_cmb_SchoolType> HrSchoolTypes { get; set; }
        public DbSet<HR_cmb_VacationType> HrVacationTypes { get; set; }
        public DbSet<HR_cmb_VacationGroup> HrVacationGroups { get; set; }
        public DbSet<HR_tbl_ContactInfo> HrContactInfos { get; set; }
        public DbSet<HR_tbl_ExtJob> HrExtJobs { get; set; }
        public DbSet<HR_tbl_Disability> HrDisabilities { get; set; }
        public DbSet<HR_tbl_Employee> HrEmployees { get; set; }
        public DbSet<HR_tbl_Leave> HrLeaves { get; set; }
        public DbSet<HR_tbl_ResidenceInfo> HrResidenceInfos { get; set; }
        public DbSet<HR_tbl_StartEndHistory> HrStartEndHistories { get; set; }
        public DbSet<HR_cmb_MistakeAdmireType> HrMistakeAdmireTypes { get; set; }
        public DbSet<HR_tbl_MistakeAdmire> HrMistakeAdmires { get; set; }
        public DbSet<HR_tbl_EmployeePhoto> HrEmployeePhotos { get; set; }
        public DbSet<HR_tbl_LeaveEarning> HrAnnualLeaveEarnings { get; set; }
        public DbSet<HR_tbl_EducationInfo> HrEducationInfos { get; set; }
        public DbSet<HR_tbl_VacationGroupContent> HrVacationGroupContents { get; set; }
        public DbSet<HR_cmb_OrganisationChangeReason> HrOrganisationChangeReasons { get; set; }
        public DbSet<HR_tbl_OrganisationChangeHistory> HrOrganisationChangeHistories { get; set; }
        public DbSet<HR_sp_AnnualLeaveDetail> HrAnnualLeaveDetails { get; set; }
        public DbSet<HR_tbl_EmployeeLeaveEarningTypeHistory> HrEmployeeLeaveEarningTypeHistories { get; set; }
        public DbSet<HR_cmb_LeaveEarningType> HrLeaveEarningTypes { get; set; }
        public DbSet<HR_cmb_AnnualLeaveDecreaseType> HrAnnualLeaveDecreaseTypes { get; set; }
        public DbSet<HR_tbl_AnnualLeaveDecrease> HrAnnualLeaveDecreases { get; set; }
        public DbSet<HR_Resume> HrResumes { get; set; }
        public DbSet<HR_ResumeEducationInfo> HrResumeEducationInfos { get; set; }
        public DbSet<HR_ResumeHiringProcess> HrResumeHiringProcesses { get; set; }
        public DbSet<HR_tbl_Leave> HrLeaveForms { get; set; }

        #endregion

        #region SYS
        public DbSet<SYS_cmb_City> SysCities { get; set; }
        public DbSet<SYS_cmb_Country> SysCountries { get; set; }
        public DbSet<SYS_cmb_District> SysDistricts { get; set; }
        public DbSet<SYS_cmb_LanguageList> SysLanguages { get; set; }
        public DbSet<SYS_cmb_Module> SysModules { get; set; }
        public DbSet<SYS_cmb_Region> SysRegions { get; set; }
        public DbSet<SYS_cmb_Town> SysTowns { get; set; }
        public DbSet<SYS_cmb_CmbTable> SysCmbTables { get; set; }
        public DbSet<SYS_cmb_ClassificationType> SysClassificationTypes { get; set; }
        public DbSet<SYS_cmb_DatePeriodType> SysDatePeriodTypes { get; set; }
        public DbSet<SYS_cmb_DocumentType> SysDocumentTypes { get; set; }
        public DbSet<SYS_SessionAuthority> SysSessionAuthorities { get; set; }
        public DbSet<SYS_EmployeeOrganizationPyramid> SysEmployeeOrganizationPyramid { get; set; }
        public DbSet<SYS_OrganizationPyramid> SysOrganizationPyramid { get; set; }
        public DbSet<SYS_tbl_UserPrivacyClassification> SysUserPrivacyClassifications { get; set; }
        public DbSet<SYS_tbl_Document> SysDocuments { get; set; }
        public DbSet<SYS_tbl_OrganisationPyramidMatch> SysOrganisationPyramidMatches { get; set; }
        public DbSet<SYS_cmb_OrganisationPyramidTitle> SysOrganisationPyramidTitles { get; set; }
        public DbSet<SYS_SqlFunctionResult> SysFunctionResults { get; set; }
        public DbSet<SYS_cmb_UnitType> SysUnitTypes { get; set; }
        public DbSet<SYS_cmb_UnitTypeGroup> SysUnitTypeGroups { get; set; }
        public DbSet<SYS_cmb_YearList> SysYearsList { get; set; }
        public DbSet<SYS_cmb_MonthList> SysMonthsList { get; set; }
        public DbSet<SYS_cmb_SmsReturnNode> SysSmsReturnNodeList { get; set; }
        public DbSet<SYS_tbl_SmlOperation> SysSmlOperationList { get; set; }
        public DbSet<SYS_tbl_SendedSmsList> SysSendedSmsList { get; set; }
        public DbSet<SYS_tbl_EmployeeForSms> SysEmployeeForSmsList { get; set; }
        public DbSet<SYS_cmb_SmsTemplate> SysSmsTemplates { get; set; }
        public DbSet<SYS_Paperwork> SysPaperworks { get; set; }
        public DbSet<SYS_PaperworkDepartment> SysPaperworkDepartments { get; set; }
        public DbSet<SYS_PaperworkType> SysPaperworkTypes { get; set; }

        #endregion

        #region LGN
        public DbSet<LGN_tbl_LoginUser> LgnLoginUsers { get; set; }
        public DbSet<LGN_cmb_Menu> LngMenus { get; set; }
        public DbSet<LGN_cmb_Role> LgnRoles { get; set; }
        public DbSet<LGN_cmb_Section> LgnSections { get; set; }
        public DbSet<LGN_tbl_Authority_Module> LgnAuthorityModules { get; set; }
        public DbSet<LGN_tbl_Authority_Menu> LgnAuthorityMenus { get; set; }
        public DbSet<LGN_tbl_Authority_Section> LgnAuthoritySections { get; set; }
        public DbSet<LGN_tbl_Authority_Role> LgnAuthorityRoles { get; set; }
        #endregion

        #region TA

        public DbSet<TA_EmployeeList> TaEmployeeList { get; set; }
        public DbSet<TA_Shift> TaShifts { get; set; }
        public DbSet<TA_ShiftSchedule> TaShiftSchedules { get; set; }
        public DbSet<TA_TimeAttendence> TaTimeAttendences { get; set; }
        public DbSet<TA_WorkPlaceType> TaWorkPlaceTypes { get; set; }

        #endregion TA

        #region OHS

        public DbSet<OHS_cmb_EmergencyJob> OhsEmergencyJobs { get; set; }
        public DbSet<OHS_cmb_EmergencyRegion> OhsEmergencyRegions { get; set; }
        public DbSet<OHS_tbl_EmergencyEmpJob> OhsEmergencyEmpJobs { get; set; }
        public DbSet<OHS_tbl_EmployeeList> OhsEmployeesList { get; set; }
        public DbSet<OHS_TrainingParticipantList> OhsTrainingParticipantList { get; set; }
        public DbSet<OHS_TrainingList> OhsTrainingList { get; set; }
        public DbSet<OHS_TorkFormScoreResult> OhsTorkFormScoreResults { get; set; }
        public DbSet<OHS_TorkForm> OhsTorkForms { get; set; }
        public DbSet<OHS_TestQuestionType> OhsTestQuestionTypes { get; set; }
        public DbSet<OHS_TestQuestion> OhsTestQuestions { get; set; }
        public DbSet<OHS_ProtocolMonitoringList> OhsProtocolMonitoringList { get; set; }
        public DbSet<OHS_PersonWorkMonitoringList> OhsPersonWorkMonitoringList { get; set; }
        public DbSet<OHS_MmpiList> OhsMmpiList { get; set; }
        public DbSet<OHS_MmpiResult> OhsMmpiResults { get; set; }
        public DbSet<OHS_MachineryMonitoringList> OhsMachineryMonitoringList { get; set; }
        public DbSet<OHS_LeaveList> OhsLeaveList { get; set; }
        public DbSet<OHS_HiringList> OhsHiringList { get; set; }
        public DbSet<OHS_InstructorList> OhsInstructorList { get; set; }
        public DbSet<OHS_EmployeeOrientationList> OhsEmployeeOrientationList { get; set; }
        public DbSet<OHS_Document> OhsDocuments { get; set; }

        #endregion OHS

        #region PRF

        public DbSet<PRF_tbl_EmployeeList> PrfEmployeesList { get; set; }
        public DbSet<PRF_cmb_AnswerRating> PrfAnswerRatings { get; set; }
        public DbSet<PRF_cmb_AnswerRatingGroup> PrfAnswerRatingGroups { get; set; }
        public DbSet<PRF_cmb_Period> PrfPeriods { get; set; }
        public DbSet<PRF_cmb_QuestionGroup> PrfQuestionGroups { get; set; }
        public DbSet<PRF_cmb_QuestionType> PrfQuestionTypes { get; set; }
        public DbSet<PRF_cmb_TargetType> PrfTargetTypes { get; set; }
        public DbSet<PRF_cmb_ProcessType> PrfProcessTypes { get; set; }
        public DbSet<PRF_cmb_OrganizationStrategy> PrfOrganizationStrategies { get; set; }
        public DbSet<PRF_tbl_Answer> PrfAnswers { get; set; }
        public DbSet<PRF_tbl_Evaluation> PrfEvaluations { get; set; }
        public DbSet<PRF_tbl_PeriodMatch> PrfPeriodMatches { get; set; }
        public DbSet<PRF_tbl_Question> PrfQuestions { get; set; }
        public DbSet<PRF_tbl_Score> PrfScores { get; set; }
        public DbSet<PRF_tbl_QuestionGroupMatch> PrfQuestionGrpoupMatches { get; set; }
        public DbSet<PRF_tbl_OrganizationScoreCard> PrfOrganizationScoreCards { get; set; }
        public DbSet<PRF_tbl_OrganizationTarget> PrfOrganizationTargets { get; set; }

        #endregion PRF

        #region RPT

        public DbSet<RPT_ReportList> RptReportsList { get; set; }
        public DbSet<RPT_ReportParam> RptReportParams { get; set; }
        public DbSet<RPT_ReportParamContent> RptReportParamContents { get; set; }

        #endregion RPT

        public DbSet<SqlResult> sqlResults { get; set; }
    }
}
