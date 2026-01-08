using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MediatR;

namespace AdvocateOS.Presentation.WPF.Features.Cases.Create;

public sealed partial class CreateCaseViewModel : ObservableObject
{
    private readonly IMediator _mediator;

    [ObservableProperty]
    private string _title = string.Empty;

    public CreateCaseViewModel(IMediator mediator)
    {
        _mediator = mediator;
    }

    [RelayCommand]
    private async Task CreateAsync()
    {
        // send command
    }
}
