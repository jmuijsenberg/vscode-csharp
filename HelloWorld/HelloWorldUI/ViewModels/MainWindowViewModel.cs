using Greeting;

namespace HelloWorldUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting
        {
            get
            {
                Greet greet = new Greet();
                return greet.GetText();
            }
        }
    }
}
