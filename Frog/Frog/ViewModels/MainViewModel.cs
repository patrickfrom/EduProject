using RatRace.Domain;

namespace Frog.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly FluentWorldBuilder _worldBuilder = new();

    public void CreateWorld()
    {
        var result = _worldBuilder.Begin();

        // Loop through all created domains, add a stronghold then either with or without a settlement
        // Display settlement if the user selected with settlement.
        // Then we need to create a ruler
        //result.AddDomain().AddStronghold().WithSettlement().CreateRuler()

        /*for (var i = 0; i < 5; i++)
        {
            result.AddDomain().AddStronghold().NoSettlement().CreateRuler();
            When done with loop then call  result.EndDomainCreation().Build();
        }*/
    }
}