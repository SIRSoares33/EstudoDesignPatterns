using FactoryMethod.Adapters.Mobilia;
using FactoryMethod.factories;
using FactoryMethod.factories.Mobilia;
using FactoryMethod.Factories;
using FactoryMethod.MVP.Model;
using FactoryMethod.MVP.Presenter;
using FactoryMethod.Services;

namespace FactoryMethod;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        // Create the mobilia factories dictionary
        var furnitureFactories = new Dictionary<string, IFurnitureFactory>
        {
            { "Chair", new ChairFactory() },
            { "Table", new TableFactory() },
            { "Sofá", new SofaFactory()   },
            { "Bed",  new BedFactory()    }
        };
        //---------------------------------------------------------------------------------
        // Create the dependencies
        var furnitureFactoryCreator = new FurnitureFactoryCreator(furnitureFactories);
        var furnitureAdapter        = new FurnitureAdapter();
        var furnitureRelatory       = new FurnitureRelatory(new TextRelatoryFormatter());
        //---------------------------------------------------------------------------------

        // Create the main view, model and presenter
        var mainView  = new MainView();
        var mainModel = new MainModel(furnitureFactoryCreator, furnitureAdapter, furnitureRelatory);
        _             = new MainPresenter(mainView, mainModel);

        Application.Run(mainView);
    }
}