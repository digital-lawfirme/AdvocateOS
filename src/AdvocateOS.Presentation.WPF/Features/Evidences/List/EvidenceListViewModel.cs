using AdvocateOS.Application.Evidences.DTOs;
using AdvocateOS.Application.Evidences.Queries;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MediatR;
using System.Collections.ObjectModel;

namespace AdvocateOS.Presentation.WPF.Features.Evidences.List;

public sealed partial class EvidenceListViewModel : ObservableObject
{
    private readonly IMediator _mediator;

    public ObservableCollection<EvidenceDto> Items { get; } = new();

    public EvidenceListViewModel(IMediator mediator)
    {
        _mediator = mediator;
    }

    [RelayCommand]
    private async Task LoadAsync(Guid caseId)
    {
        Items.Clear();
        var result = await _mediator.Send(new GetEvidencesByCaseQuery(caseId));
        foreach (var item in result)
            Items.Add(item);
    }
}
