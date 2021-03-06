using MvvmCross.Core.ViewModels;

namespace Azure.Screenshots.Core.ViewModels
{
    public class NavigateRoot : MvxViewModel
    {
        public NavigateRoot()
        {
            ShowViewModel<FirstViewModel>();
        }
    }

    public class FirstViewModel
        : MvxViewModel
    {

        string hello = "Hello MvvmCross - Bound from FirstViewModel";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }

        string firstName;
        public string FirstName
        {
            get { return firstName;  }
            set { SetProperty(ref firstName, value);}
        }

        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { SetProperty(ref lastName, value); }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", firstName, lastName); }
        }

        public IMvxCommand GoCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<SecondViewModel>();
                });
            }
        }

    }
}
