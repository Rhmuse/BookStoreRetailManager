﻿using BSRMWPFUserInterface.EventModels;
using BSRMWPFUserInterface.Library.Api;
using Caliburn.Micro;
using System.Threading;
using System.Threading.Tasks;

namespace BSRMWPFUserInterface.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName = "Rhett@email.com";
        private string _password = "Password1!";
        private IAPIHelper _apiHelper;
        private IEventAggregator _events;

        public LoginViewModel(IAPIHelper apiHelper, IEventAggregator events)
        {
            _apiHelper = apiHelper;
            _events = events;
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }



        public bool IsErrorVisible
        {
            get
            {
                bool output = false;

                if (ErrorMessage?.Length > 0)
                {
                    output = true;
                }
                return output;
            }
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }




        public bool CanLogIn
        {
            get
            {
                bool output = false;

                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }

                return output;
            }

        }

        public async Task LogIn()
        {
            try
            {
                ErrorMessage = "";
                var result = await _apiHelper.Authenticate(UserName, Password);

                // Capture more information about the user.
                await _apiHelper.GetLoggedInUserAsync(result.Access_Token);

                await _events.PublishOnUIThreadAsync(new LogOnEvent(), new CancellationToken());
            }
            catch (System.Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }
    }
}
