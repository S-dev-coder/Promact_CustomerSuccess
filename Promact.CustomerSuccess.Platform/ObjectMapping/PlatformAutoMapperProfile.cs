using AutoMapper;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos;
using Promact.CustomerSuccess.Platform.Services.Dtos.ProjectBudgets;

namespace Promact.CustomerSuccess.Platform.ObjectMapping;

public class PlatformAutoMapperProfile : Profile
{
    public PlatformAutoMapperProfile()
    {
        /* Create your AutoMapper object mappings here */
        CreateMap<CreateProjectDto, Project>();
        CreateMap<UpdateProjectDto, Project>();
        CreateMap<Project, ProjectDto>().ReverseMap();


        CreateMap<CreateClientFeedbackDto, ClientFeedback>();
        CreateMap<UpdateClientFeedbackDto, ClientFeedback>();
        CreateMap<ClientFeedback, ClientFeedbackDto>().ReverseMap();

        CreateMap<CreateProjectResourceDto, ProjectResource>();
        CreateMap<UpdateProjectResourceDto, ProjectResource>();
        CreateMap<ProjectResource, ProjectResourceDto>().ReverseMap();

        CreateMap<CreateProjectUpdateDto, ProjectUpdate>();
        CreateMap<UpdateProjectUpdateDto, ProjectUpdate>();
        CreateMap<ProjectUpdate, ProjectUpdateDto>().ReverseMap();

       CreateMap<CreateMeetingMinuteDto,MeetingMinute>();
        CreateMap<UpdateMeetingMinuteDto,MeetingMinute>();
        CreateMap<MeetingMinute,MeetingMinuteDto>().ReverseMap();

        CreateMap<CreateApprovedTeamDto, ApprovedTeam>();
        CreateMap<UpdateApprovedTeamDto, ApprovedTeam>();
        CreateMap<ApprovedTeam, ApprovedTeamDto>().ReverseMap();

        CreateMap<CreatePhaseDto, Phase>();
        CreateMap<UpdatePhaseDto, Phase>();
        CreateMap<Phase, PhaseDto>().ReverseMap();

        CreateMap<CreateProjectBudgetDto, ProjectBudget>();
        CreateMap<UpdateProjectBudgetDto, ProjectBudget>();
        CreateMap<ProjectBudget, ProjectBudgetDto>().ReverseMap();

        CreateMap<CreateAuditHistoryDto, AuditHistory>();
        CreateMap<UpdateAuditHistoryDto, AuditHistory>();
        CreateMap<AuditHistory, AuditHistoryDto>().ReverseMap();

        CreateMap<CreateVersionHistoryDto, VersionHistory>();
        CreateMap<UpdateVersionHistoryDto, VersionHistory>();
        CreateMap<VersionHistory, VersionHistoryDto>().ReverseMap();

        CreateMap<CreateStakeholdersDto, Stakeholders>();
        CreateMap<UpdateStakeholdersDto, Stakeholders>();
        CreateMap<Stakeholders, StakeholdersDto>().ReverseMap();

        CreateMap<CreateRiskProfileDto, RiskProfile>();
        CreateMap<UpdateRiskProfileDto, RiskProfile>();
        CreateMap<RiskProfile, RiskProfileDto>().ReverseMap();
    }

}

