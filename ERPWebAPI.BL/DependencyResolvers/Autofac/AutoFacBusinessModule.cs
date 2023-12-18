using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using ERPWebAPI.BL.Abstract;
using ERPWebAPI.BL.Abstract.DASHBOARD;
using ERPWebAPI.BL.Abstract.GRAPH;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Abstract.Session;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Abstract.TA;
using ERPWebAPI.BL.Concrete;
using ERPWebAPI.BL.Concrete.DASHBOARD;
using ERPWebAPI.BL.Concrete.GRAPH;
using ERPWebAPI.BL.Concrete.HR;
using ERPWebAPI.BL.Concrete.LGN;
using ERPWebAPI.BL.Concrete.OHS;
using ERPWebAPI.BL.Concrete.PRF;
using ERPWebAPI.BL.Concrete.Session;
using ERPWebAPI.BL.Concrete.SYS;
using ERPWebAPI.BL.Concrete.TA;
using ERPWebAPI.DAL.Abstract;
using ERPWebAPI.DAL.Abstract.DASHBOARD;
using ERPWebAPI.DAL.Abstract.GRAPH;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.DAL.Abstract.Session;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.DAL.Abstract.TA;
using ERPWebAPI.DAL.Concrete;
using ERPWebAPI.DAL.Concrete.DASHBOARD;
using ERPWebAPI.DAL.Concrete.GRAPH;
using ERPWebAPI.DAL.Concrete.HR;
using ERPWebAPI.DAL.Concrete.LGN;
using ERPWebAPI.DAL.Concrete.OHS;
using ERPWebAPI.DAL.Concrete.PRF;
using ERPWebAPI.DAL.Concrete.Session;
using ERPWebAPI.DAL.Concrete.SYS;
using ERPWebAPI.DAL.Concrete.TA;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.DASHBOARD;
using ERPWebAPI.EL.Concrete.GRAPHS;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete.LGN;
using ERPWebAPI.EL.Concrete.OHS;
using ERPWebAPI.EL.Concrete.PRF;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete.TA;
using Microsoft.AspNetCore.Http;

namespace ERPWebAPI.BL.DependencyResolvers.Autofac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region GRAPH
            builder.RegisterType<CommonGraphManager>().As<ICommonGraphService<CommonGraph, SqlResult>>();
            builder.RegisterType<CommonGraphDal>().As<ICommonGraphDal>();
            #endregion

            #region DASHBOARD
            builder.RegisterType<DashBoardElementManager>().As<IDashBoardElementService<DashBoardElement, SqlResult>>();
            builder.RegisterType<DashBoardElementDal>().As<IDashBoardElementDal>();
            builder.RegisterType<DashBoardListHeaderManager>().As<IDashBoardListHeaderService<DashBoardListHeader, SqlResult>>();
            builder.RegisterType<DashBoardListHeaderDal>().As<IDashBoardListHeaderDal>();
            builder.RegisterType<DashBoardListDetailManager>().As<IDashBoardListDetailService<DashBoardListDetail, SqlResult>>();
            builder.RegisterType<DashBoardListDetailDal>().As<IDashBoardListDetailDal>();
            #endregion

            #region HR
            builder.RegisterType<HR_cmb_BloodTypeDal>().As<IHR_cmb_BloodTypeDal>().SingleInstance();
            builder.RegisterType<HR_cmb_BloodTypeManager>().As<IHR_cmb_BloodTypeService<HR_cmb_BloodType, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_CollarDal>().As<IHR_cmb_CollarDal>().SingleInstance();
            builder.RegisterType<HR_cmb_CollarManager>().As<IHR_cmb_CollarService<HR_cmb_Collar, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_CompanyDal>().As<IHR_cmb_CompanyDal>().SingleInstance();
            builder.RegisterType<HR_cmb_CompanyManager>().As<IHR_cmb_CompanyService<HR_cmb_Company, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_ContactInfoTypeDal>().As<IHR_cmb_ContactInfoTypeDal>().SingleInstance();
            builder.RegisterType<HR_cmb_ContactInfoTypeManager>().As<IHR_cmb_ContactInfoTypeService<HR_cmb_ContactInfoType, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_ContactTypeDal>().As<IHR_cmb_ContactTypeDal>().SingleInstance();
            builder.RegisterType<HR_cmb_ContactTypeManager>().As<IHR_cmb_ContactTypeService<HR_cmb_ContactType, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_CostCenterDal>().As<IHR_cmb_CostCenterDal>().SingleInstance();
            builder.RegisterType<HR_cmb_CostCenterManager>().As<IHR_cmb_CostCenterService<HR_cmb_CostCenter, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_DepartmentDal>().As<IHR_cmb_DepartmentDal>().SingleInstance();
            builder.RegisterType<HR_cmb_DepartmentManager>().As<IHR_cmb_DepartmentService<HR_cmb_Department, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_EducationStatusDal>().As<IHR_cmb_EducationStatusDal>().SingleInstance();
            builder.RegisterType<HR_cmb_EducationStatusManager>().As<IHR_cmb_EducationStatusService<HR_cmb_EducationStatu, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_GraduationTypeDal>().As<IHR_cmb_GraduationTypeDal>().SingleInstance();
            builder.RegisterType<HR_cmb_GraduationTypeManager>().As<IHR_cmb_GraduationTypeService<HR_cmb_GraduationType, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_JobDal>().As<IHR_cmb_JobDal>().SingleInstance();
            builder.RegisterType<HR_cmb_JobManager>().As<IHR_cmb_JobService<HR_cmb_Job, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_LocationDal>().As<IHR_cmb_LocationDal>().SingleInstance();
            builder.RegisterType<HR_cmb_LocationManager>().As<IHR_cmb_LocationService<HR_cmb_Location, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_MaritalStatusDal>().As<IHR_cmb_MaritalStatusDal>().SingleInstance();
            builder.RegisterType<HR_cmb_MaritalStatusManager>().As<IHR_cmb_MaritalStatusService<HR_cmb_MaritalStatu, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_MilitaryStatusTypeDal>().As<IHR_cmb_MilitaryStatusTypeDal>().SingleInstance();
            builder.RegisterType<HR_cmb_MilitaryStatusTypeManager>().As<IHR_cmb_MilitaryStatusTypeService<HR_cmb_MilitaryStatusType, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_MissingDayReasonDal>().As<IHR_cmb_MissingDayReasonDal>().SingleInstance();
            builder.RegisterType<HR_cmb_MissingDayReasonManager>().As<IHR_cmb_MissingDayReasonService<HR_cmb_MissingDayReason, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_PositionDal>().As<IHR_cmb_PositionDal>().SingleInstance();
            builder.RegisterType<HR_cmb_PositionManager>().As<IHR_cmb_PositionService<HR_cmb_Position, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_QuitReasonDal>().As<IHR_cmb_QuitReasonDal>().SingleInstance();
            builder.RegisterType<HR_cmb_QuitReasonManager>().As<IHR_cmb_QuitReasonService<HR_cmb_QuitReason, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_SchoolDal>().As<IHR_cmb_SchoolDal>().SingleInstance();
            builder.RegisterType<HR_cmb_SchoolManager>().As<IHR_cmb_SchoolService<HR_cmb_School, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_SchoolDepartmentDal>().As<IHR_cmb_SchoolDepartmentDal>().SingleInstance();
            builder.RegisterType<HR_cmb_SchoolDepartmentManager>().As<IHR_cmb_SchoolDepartmentService<HR_cmb_SchoolDepartment, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_SchoolLocationDal>().As<IHR_tbl_SchoolLocationDal>().SingleInstance();
            builder.RegisterType<HR_tbl_SchoolLocationManager>().As<IHR_tbl_SchoolLocationService<HR_tbl_SchoolLocation, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_SchoolTypeDal>().As<IHR_cmb_SchoolTypeDal>().SingleInstance();
            builder.RegisterType<HR_cmb_SchoolTypeManager>().As<IHR_cmb_SchoolTypeService<HR_cmb_SchoolType, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_VacationTypeDal>().As<IHR_cmb_VacationTypeDal>().SingleInstance();
            builder.RegisterType<HR_cmb_VacationTypeManager>().As<IHR_cmb_VacationTypeService<HR_cmb_VacationType, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_VacationGroupDal>().As<IHR_cmb_VacationGroupDal>().SingleInstance();
            builder.RegisterType<HR_cmb_VacationGroupManager>().As<IHR_cmb_VacationGroupService<HR_cmb_VacationGroup, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_ExtJobDal>().As<IHR_tbl_ExtJobDal>().SingleInstance();
            builder.RegisterType<HR_tbl_ExtJobManager>().As<IHR_tbl_ExtJobService<HR_tbl_ExtJob, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_ContactInfoDal>().As<IHR_tbl_ContactInfoDal>().SingleInstance();
            builder.RegisterType<HR_tbl_ContactInfoManager>().As<IHR_tbl_ContactInfoService<HR_tbl_ContactInfo, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_DisabilityDal>().As<IHR_tbl_DisabilityDal>().SingleInstance();
            builder.RegisterType<HR_tbl_DisabilityManager>().As<IHR_tbl_DisabilityService<HR_tbl_Disability, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_EmployeeDal>().As<IHR_tbl_EmployeeDal>().SingleInstance();
            builder.RegisterType<HR_tbl_EmployeeManager>().As<IHR_tbl_EmployeeService<HR_tbl_Employee, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_LeaveDal>().As<IHR_tbl_LeaveDal>().SingleInstance();
            builder.RegisterType<HR_tbl_LeaveManager>().As<IHR_tbl_LeaveService<HR_tbl_Leave, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_ResidenceInfoDal>().As<IHR_tbl_ResidenceInfoDal>().SingleInstance();
            builder.RegisterType<HR_tbl_ResidenceInfoManager>().As<IHR_tbl_ResidenceInfoService<HR_tbl_ResidenceInfo, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_StartEndHistoryDal>().As<IHR_tbl_StartEndHistoryDal>().SingleInstance();
            builder.RegisterType<HR_tbl_StartEndHistoryManager>().As<IHR_tbl_StartEndHistoryService<HR_tbl_StartEndHistory, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_EmployeePhotoDal>().As<IHR_tbl_EmployeePhotoDal>().SingleInstance();
            builder.RegisterType<HR_tbl_EmployeePhotoManager>().As<IHR_tbl_EmployeePhotoService<HR_tbl_EmployeePhoto, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_LeaveEarningDal>().As<IHR_tbl_LeaveEarningDal>().SingleInstance();
            builder.RegisterType<HR_tbl_LeaveEarningManager>().As<IHR_tbl_LeaveEarningService<HR_tbl_LeaveEarning, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_MistakeAdmireDal>().As<IHR_tbl_MistakeAdmireDal>().SingleInstance();
            builder.RegisterType<HR_tbl_MistakeAdmireManager>().As<IHR_tbl_MistakeAdmireService<HR_tbl_MistakeAdmire, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_MistakeAdmireTypeDal>().As<IHR_cmb_MistakeAdmireTypeDal>().SingleInstance();
            builder.RegisterType<HR_cmb_MistakeAdmireTypeManager>().As<IHR_cmb_MistakeAdmireTypeService<HR_cmb_MistakeAdmireType, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_EducationInfoDal>().As<IHR_tbl_EducationInfoDal>().SingleInstance();
            builder.RegisterType<HR_tbl_EducationInfoManager>().As<IHR_tbl_EducationInfoService<HR_tbl_EducationInfo, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_VacationGroupContentDal>().As<IHR_tbl_VacationGroupContentDal>().SingleInstance();
            builder.RegisterType<HR_tbl_VacationGroupContentManager>().As<IHR_tbl_VacationGroupContentService<HR_tbl_VacationGroupContent, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_OrganisationChangeHistoryDal>().As<IHR_tbl_OrganisationChangeHistoryDal>().SingleInstance();
            builder.RegisterType<HR_tbl_OrganisationChangeHistoryManager>().As<IHR_tbl_OrganisationChangeHistoryService<HR_tbl_OrganisationChangeHistory, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_OrganisationChangeReasonDal>().As<IHR_cmb_OrganisationChangeReasonDal>().SingleInstance();
            builder.RegisterType<HR_cmb_OrganisationChangeReasonManager>().As<IHR_cmb_OrganisationChangeReasonService<HR_cmb_OrganisationChangeReason, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_OrganisationChangeReasonDal>().As<IHR_cmb_OrganisationChangeReasonDal>().SingleInstance();
            builder.RegisterType<HR_cmb_OrganisationChangeReasonManager>().As<IHR_cmb_OrganisationChangeReasonService<HR_cmb_OrganisationChangeReason, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_sp_AnnualLeaveDetailDal>().As<IHR_sp_AnnualLeaveDetailDal>().SingleInstance();
            builder.RegisterType<HR_sp_AnnualLeaveDetailManager>().As<IHR_sp_AnnualLeaveDetailService<HR_sp_AnnualLeaveDetail, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_EmployeeLeaveEarningTypeHistoryDal>().As<IHR_tbl_EmployeeLeaveEarningTypeHistoryDal>().SingleInstance();
            builder.RegisterType<HR_tbl_EmployeeLeaveEarningTypeHistoryManager>().As<IHR_tbl_EmployeeLeaveEarningTypeHistoryService<HR_tbl_EmployeeLeaveEarningTypeHistory, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_LeaveEarningTypeDal>().As<IHR_cmb_LeaveEarningTypeDal>().SingleInstance();
            builder.RegisterType<HR_cmb_LeaveEarningTypeManager>().As<IHR_cmb_LeaveEarningTypeService<HR_cmb_LeaveEarningType, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_cmb_AnnualLeaveDecreaseTypeDal>().As<IHR_cmb_AnnualLeaveDecreaseTypeDal>().SingleInstance();
            builder.RegisterType<HR_cmb_AnnualLeaveDecreaseTypeManager>().As<IHR_cmb_AnnualLeaveDecreaseTypeService<HR_cmb_AnnualLeaveDecreaseType, SqlResult>>().SingleInstance();
            builder.RegisterType<HR_tbl_AnnualLeaveDecreaseDal>().As<IHR_tbl_AnnualLeaveDecreaseDal>().SingleInstance();
            builder.RegisterType<HR_tbl_AnnualLeaveDecreaseManager>().As<IHR_tbl_AnnualLeaveDecreaseService<HR_tbl_AnnualLeaveDecrease, SqlResult>>().SingleInstance();

            #endregion

            #region SYS
            builder.RegisterType<SYS_cmb_CityDal>().As<ISYS_cmb_CityDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_CityManager>().As<ISYS_cmb_CityService<SYS_cmb_City, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_CountryDal>().As<ISYS_cmb_CountryDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_CountryManager>().As<ISYS_cmb_CountryService<SYS_cmb_Country, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_DistrictDal>().As<ISYS_cmb_DistrictDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_DistrictManager>().As<ISYS_cmb_DistrictService<SYS_cmb_District, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_LanguageListDal>().As<ISYS_cmb_LanguageListDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_LanguageListManager>().As<ISYS_cmb_LanguageListService<SYS_cmb_LanguageList, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_ModuleDal>().As<ISYS_cmb_ModuleDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_ModuleManager>().As<ISYS_cmb_ModuleService<SYS_cmb_Module, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_RegionDal>().As<ISYS_cmb_RegionDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_RegionManager>().As<ISYS_cmb_RegionService<SYS_cmb_Region, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_TownDal>().As<ISYS_cmb_TownDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_TownManager>().As<ISYS_cmb_TownService<SYS_cmb_Town, SqlResult>>().SingleInstance();
            builder.RegisterType<LGN_tbl_LoginUserDal>().As<ILGN_tbl_LoginUserDal>().SingleInstance();
            builder.RegisterType<LGN_tbl_LoginUserManager>().As<ILGN_tbl_LoginUserService<LGN_tbl_LoginUser, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_SessionAuthorityDal>().As<ISYS_SessionAuthorityDal>().SingleInstance();
            builder.RegisterType<SYS_SessionAuthorityManager>().As<ISYS_SessionAuthorityService<SYS_SessionAuthority, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_ClassificationTypeDal>().As<ISYS_cmb_ClassificationTypeDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_ClassificationTypeManager>().As<ISYS_cmb_ClassificationTypeService<SYS_cmb_ClassificationType, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_DatePeriodTypeDal>().As<ISYS_cmb_DatePeriodTypeDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_DatePeriodTypeManager>().As<ISYS_cmb_DatePeriodTypeService<SYS_cmb_DatePeriodType, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_DocumentTypeDal>().As<ISYS_cmb_DocumentTypeDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_DocumentTypeManager>().As<ISYS_cmb_DocumentTypeService<SYS_cmb_DocumentType, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_tbl_UserPrivacyClassificationDal>().As<ISYS_tbl_UserPrivacyClassificationDal>().SingleInstance();
            builder.RegisterType<SYS_tbl_UserPrivacyClassificationManager>().As<ISYS_tbl_UserPrivacyClassificationService<SYS_tbl_UserPrivacyClassification, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_tbl_DocumentDal>().As<ISYS_tbl_DocumentDal>().SingleInstance();
            builder.RegisterType<SYS_tbl_DocumentManager>().As<ISYS_tbl_DocumentService<SYS_tbl_Document, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_OrganisationPyramidTitleDal>().As<ISYS_cmb_OrganisationPyramidTitleDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_OrganisationPyramidTitleManager>().As<ISYS_cmb_OrganisationPyramidTitleService<SYS_cmb_OrganisationPyramidTitle, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_tbl_OrganisationPyramidMatchDal>().As<ISYS_tbl_OrganisationPyramidMatchDal>().SingleInstance();
            builder.RegisterType<SYS_tbl_OrganisationPyramidMatchManager>().As<ISYS_tbl_OrganisationPyramidMatchService<SYS_tbl_OrganisationPyramidMatch, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_SqlFunctionResultDal>().As<ISYS_SqlFunctionResultDal>().SingleInstance();
            builder.RegisterType<SYS_SqlFunctionResultManager>().As<ISYS_SqlFunctionResultService<SYS_SqlFunctionResult, SqlResult>>().SingleInstance();
            builder.RegisterType<SYS_cmb_CmbTableDal>().As<ISYS_cmb_CmbTableDal>().SingleInstance();
            builder.RegisterType<SYS_cmb_CmbTableManager>().As<ISYS_cmb_CmbTableService<SYS_cmb_CmbTable, SqlResult>>().SingleInstance();
            


            #endregion

            #region LGN
            builder.RegisterType<LGN_cmb_MenuDal>().As<ILGN_cmb_MenuDal>().SingleInstance();
            builder.RegisterType<LGN_cmb_MenuManager>().As<ILGN_cmb_MenuService<LGN_cmb_Menu, SqlResult>>().SingleInstance();
            builder.RegisterType<LGN_cmb_RoleDal>().As<ILGN_cmb_RoleDal>().SingleInstance();
            builder.RegisterType<LGN_cmb_RoleManager>().As<ILGN_cmb_RoleService<LGN_cmb_Role, SqlResult>>().SingleInstance();
            builder.RegisterType<LGN_cmb_SectionDal>().As<ILGN_cmb_SectionDal>().SingleInstance();
            builder.RegisterType<LGN_cmb_SectionManager>().As<ILGN_cmb_SectionService<LGN_cmb_Section, SqlResult>>().SingleInstance();
            builder.RegisterType<LGN_tbl_AuthorityMenuDal>().As<ILGN_tbl_AuthorityMenuDal>().SingleInstance();
            builder.RegisterType<LGN_tbl_AuthorityMenuManager>().As<ILGN_tbl_AuthorityMenuService<LGN_tbl_Authority_Menu, SqlResult>>().SingleInstance();
            builder.RegisterType<LGN_tbl_AuthorityModuleDal>().As<ILGN_tbl_AuthorityModuleDal>().SingleInstance();
            builder.RegisterType<LGN_tbl_AuthorityModuleManager>().As<ILGN_tbl_AuthorityModuleService<LGN_tbl_Authority_Module, SqlResult>>().SingleInstance();
            builder.RegisterType<LGN_tbl_AuthorityRoleDal>().As<ILGN_tbl_AuthorityRoleDal>().SingleInstance();
            builder.RegisterType<LGN_tbl_AuthorityRoleManager>().As<ILGN_tbl_AuthorityRoleService<LGN_tbl_Authority_Role, SqlResult>>().SingleInstance();
            builder.RegisterType<LGN_tbl_AuthoritySectionDal>().As<ILGN_tbl_AuthoritySectionDal>().SingleInstance();
            builder.RegisterType<LGN_tbl_AuthoritySectionManager>().As<ILGN_tbl_AuthoritySectionService<LGN_tbl_Authority_Section, SqlResult>>().SingleInstance();

            #endregion

            #region TA

            builder.RegisterType<TA_EmployeeListDal>().As<ITA_EmployeeListDal>().SingleInstance();
            builder.RegisterType<TA_EmployeeListManager>().As<ITA_EmployeeListService<TA_EmployeeList, SqlResult>>().SingleInstance();
            builder.RegisterType<TA_ShiftDal>().As<ITA_ShiftDal>().SingleInstance();
            builder.RegisterType<TA_ShiftManager>().As<ITA_ShiftService<TA_Shift, SqlResult>>().SingleInstance();
            builder.RegisterType<TA_ShiftScheduleDal>().As<ITA_ShiftScheduleDal>().SingleInstance();
            builder.RegisterType<TA_ShiftScheduleManager>().As<ITA_ShiftScheduleService<TA_ShiftSchedule, SqlResult>>().SingleInstance();
            builder.RegisterType<TA_TimeAttendenceDal>().As<ITA_TimeAttendenceDal>().SingleInstance();
            builder.RegisterType<TA_TimeAttendenceManager>().As<ITA_TimeAttendenceService<TA_TimeAttendence, SqlResult>>().SingleInstance();
            builder.RegisterType<TA_WorkPlaceTypeDal>().As<ITA_WorkPlaceTypeDal>().SingleInstance();
            builder.RegisterType<TA_WorkPlaceTypeManager>().As<ITA_WorkPlaceTypeService<TA_WorkPlaceType, SqlResult>>().SingleInstance();

            #endregion TA

            #region OHS

            builder.RegisterType<OHS_cmb_EmergencyJobDal>().As<IOHS_cmb_EmergencyJobDal>().SingleInstance();
            builder.RegisterType<OHS_cmb_EmergencyJobManager>().As<IOHS_cmb_EmergencyJobService<OHS_cmb_EmergencyJob, SqlResult>>().SingleInstance();
            builder.RegisterType<OHS_cmb_EmergencyRegionDal>().As<IOHS_cmb_EmergencyRegionDal>().SingleInstance();
            builder.RegisterType<OHS_cmb_EmergencyRegionManager>().As<IOHS_cmb_EmergencyRegionService<OHS_cmb_EmergencyRegion, SqlResult>>().SingleInstance();
            builder.RegisterType<OHS_tbl_EmergencyEmpJobDal>().As<IOHS_tbl_EmergencyEmpJobDal>().SingleInstance();
            builder.RegisterType<OHS_tbl_EmergencyEmpJobManager>().As<IOHS_tbl_EmergencyEmpJobService<OHS_tbl_EmergencyEmpJob, SqlResult>>().SingleInstance();
            builder.RegisterType<OHS_tbl_EmployeeListDal>().As<IOHS_tbl_EmployeeListDal>().SingleInstance();
            builder.RegisterType<OHS_tbl_EmployeeListManager>().As<IOHS_tbl_EmployeeListService<OHS_tbl_EmployeeList, SqlResult>>().SingleInstance();

            #endregion OHS

            #region PRF

            builder.RegisterType<PRF_cmb_AnswerRatingDal>().As<IPRF_cmb_AnswerRatingDal>().SingleInstance();
            builder.RegisterType<PRF_cmb_AnswerRatingManager>().As<IPRF_cmb_AnswerRatingService<PRF_cmb_AnswerRating, SqlResult>>().SingleInstance();
            builder.RegisterType<PRF_cmb_AnswerRatingGroupDal>().As<IPRF_cmb_AnswerRatingGroupDal>().SingleInstance();
            builder.RegisterType<PRF_cmb_AnswerRatingGroupManager>().As<IPRF_cmb_AnswerRatingGroupService<PRF_cmb_AnswerRatingGroup, SqlResult>>().SingleInstance();
            builder.RegisterType<PRF_cmb_PeriodDal>().As<IPRF_cmb_PeriodDal>().SingleInstance();
            builder.RegisterType<PRF_cmb_PeriodManager>().As<IPRF_cmb_PeriodService<PRF_cmb_Period, SqlResult>>().SingleInstance();
            builder.RegisterType<PRF_cmb_QuestionGroupDal>().As<IPRF_cmb_QuestionGroupDal>().SingleInstance();
            builder.RegisterType<PRF_cmb_QuestionGroupManager>().As<IPRF_cmb_QuestionGroupService<PRF_cmb_QuestionGroup, SqlResult>>().SingleInstance();
            builder.RegisterType<PRF_cmb_QuestionTypeDal>().As<IPRF_cmb_QuestionTypeDal>().SingleInstance();
            builder.RegisterType<PRF_cmb_QuestionTypeManager>().As<IPRF_cmb_QuestionTypeService<PRF_cmb_QuestionType, SqlResult>>().SingleInstance();
            builder.RegisterType<PRF_tbl_AnswerDal>().As<IPRF_tbl_AnswerDal>().SingleInstance();
            builder.RegisterType<PRF_tbl_AnswerManager>().As<IPRF_tbl_AnswerService<PRF_tbl_Answer, SqlResult>>().SingleInstance();
            builder.RegisterType<PRF_tbl_EvaluationDal>().As<IPRF_tbl_EvaluationDal>().SingleInstance();
            builder.RegisterType<PRF_tbl_EvaluationManager>().As<IPRF_tbl_EvaluationService<PRF_tbl_Evaluation, SqlResult>>().SingleInstance();
            builder.RegisterType<PRF_tbl_EmployeeListDal>().As<IPRF_tbl_EmployeeListDal>().SingleInstance();
            builder.RegisterType<PRF_tbl_EmployeeListManager>().As<IPRF_tbl_EmployeeListService<PRF_tbl_EmployeeList, SqlResult>>().SingleInstance();
            builder.RegisterType<PRF_tbl_PeriodMatchDal>().As<IPRF_tbl_PeriodMatchDal>().SingleInstance();
            builder.RegisterType<PRF_tbl_PeriodMatchManager>().As<IPRF_tbl_PeriodMatchService<PRF_tbl_PeriodMatch, SqlResult>>().SingleInstance();
            builder.RegisterType<PRF_tbl_QuestionDal>().As<IPRF_tbl_QuestionDal>().SingleInstance();
            builder.RegisterType<PRF_tbl_QuestionManager>().As<IPRF_tbl_QuestionService<PRF_tbl_Question, SqlResult>>().SingleInstance();
            builder.RegisterType<PRF_tbl_QuestionGroupMatchDal>().As<IPRF_tbl_QuestionGroupMatchDal>().SingleInstance();
            builder.RegisterType<PRF_tbl_QuestionGroupMatchManager>().As<IPRF_tbl_QuestionGroupMatchService<PRF_tbl_QuestionGroupMatch, SqlResult>>().SingleInstance();

            #endregion PRF

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<UserDal>().As<IUserDal>();

            builder.RegisterType<SessionManager>().As<ISessionService>();
            builder.RegisterType<SessionDal>().As<ISessionDal>();
            builder.RegisterType<LoginInfoManager>().As<ILoginInfoService>();
            builder.RegisterType<LoginInfoDal>().As<ILoginInfoDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>().SingleInstance();

        }
    }
}
