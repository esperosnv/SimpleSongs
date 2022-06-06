using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSongs.Controllers.Interfaces;
using SimpleSongs.Views.Interfaces;
using SimpleSongs.Controllers.Utils;

namespace SimpleSongs.Controllers
{
    public abstract class BaseHandler<T> : IUserDataManager
    {
        protected IInputSystem _inputSystem;
        protected IMenuDisplay _display;
        protected IView<T> _view;
        protected string[] _availableCommands;



        protected BaseHandler(IInputSystem inputSystem, IView<T> view, IMenuDisplay display)
        {
            _view = view;
            _inputSystem = inputSystem;
            _display = display;
        }


        public void Run()
        {
            string userInput = null;
           // _display.ClearScreen();

            while (userInput != "quit")
            {
                _display.PrintOptions(new List<string>(_availableCommands));
                userInput = _inputSystem.FetchStringValue("Provide option").Trim();

                RunFeatureBasedOn(userInput);
                _inputSystem.FetchStringValue("Press enter to proceed...");
               // _display.ClearScreen();
            }
        }

        public abstract void RunFeatureBasedOn(string userInput);

    }
}
