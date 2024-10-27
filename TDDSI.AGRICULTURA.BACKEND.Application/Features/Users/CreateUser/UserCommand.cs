using System.ComponentModel.DataAnnotations;
using TDDSI.AGRICULTURA.BACKEND.Application.Messaging;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Features.Users.CreateUser;
public record UserCommand(
    [Required] string FirstName
    , string? SecondName
    , [Required] string SurName
    , string? SecondSurName
    ) : ICommand<UserCommandResponse>;
