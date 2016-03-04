using MvvmCross.Platform.IoC;
using Sample.Core.ViewModels;

namespace Sample.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TabHostViewModel>();
        }
    }
}
