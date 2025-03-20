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
        var mobiliaFactories = new Dictionary<string, IMobiliaFactory>
        {
            { "Chair", new ChairFactory() },
            { "Table", new TableFactory() },
            { "Sofá", new SofaFactory()   },
            { "Bed",  new BedFactory()    }
        };
        //---------------------------------------------------------------------------------
        // Create the dependencies
        var mobiliaFactoryCreator = new MobiliaFactoryCreator(mobiliaFactories);
        var mobiliaAdapter        = new MobiliaAdapter();
        var createMobiliaRelatory = new MobiliaRelatory(new TextRelatoryFormatter());
        //---------------------------------------------------------------------------------

        // Create the main view, model and presenter
        var mainView  = new MainView();
        var mainModel = new MainModel(mobiliaFactoryCreator, mobiliaAdapter, createMobiliaRelatory);
        _             = new MainPresenter(mainView, mainModel);

        Application.Run(mainView);
    }
}