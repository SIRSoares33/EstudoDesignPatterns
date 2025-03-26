using AbstractFactory.Factories;
using AbstractFactory.Factories.Constructors;
using AbstractFactory.Factories.Constructors.Ferrari;
using AbstractFactory.Factories.Constructors.Mercedes;
using AbstractFactory.MVP.Model;
using AbstractFactory.MVP.Presenter;
using AbstractFactory.Services;
using AbstractFactory.Services.Relatory.RelatoryFormatters;

namespace AbstractFactory;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        #region MainModel Dependencies
        Dictionary<string, IConstructorsFactory> constructorFactories = new()
        {
            {"Ferrari", new FerrariFactory()},
            {"Mercedes", new MercedesFactory()}
        };

        IConstructorsFactoryCreator constructorsFactoryCreator = new ConstructorsFactoryCreator(constructorFactories);
        ICreateCarRelatory createCarRelatory                   = new CreateCarRelatory(new RelatoryTextCarFormatter());
        #endregion

        #region MVP Instance
        var mainView  = new MainView();
        var mainModel = new MainModel(constructorsFactoryCreator, createCarRelatory);
        _             = new MainPresenter(mainView, mainModel);
        #endregion

        Application.Run(mainView);
    }    
}