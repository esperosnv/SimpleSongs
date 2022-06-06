using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSongs.Views.Interfaces;
using SimpleSongs.Data.Entities;

namespace SimpleSongs.Views
{
    internal class UserConsoleView : IView<User>
    {
        public void DisplayAll(List<User> entities)
        {
            throw new NotImplementedException();
        }

        public void DisplaySingle(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
