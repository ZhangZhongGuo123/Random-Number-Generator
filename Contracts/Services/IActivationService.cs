namespace Random_Number_Generator.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
