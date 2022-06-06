using NUnit.Framework;
using NSubstitute;
using System;
using SimpleSongs.Data.DAL;
using SimpleSongs.Data.Entities;
using SimpleSongs.Controllers.Utils;
using SimpleSongs.Views.Interfaces;
using SimpleSongs.Controllers;

namespace SimpleSong.UnitTests
{
        [TestFixture]
        public class SongHandlerTests
        {
            private SongHandler _songHandler;
            private IBaseRepository<Song> _songRepository;
            private IInputSystem _inputSystem;
            private IView<Song> _view;
            private IMenuDisplay _display;


            [SetUp]
            public void SetUp()
            {
                _songRepository = Substitute.For<IBaseRepository<Song>>();
                _inputSystem = Substitute.For<IInputSystem>();
                _view = Substitute.For<IView<Song>>();
                _display = Substitute.For<IMenuDisplay>();
                _songHandler = new SongHandler(_songRepository, _inputSystem, _view, _display);
            }

            [Test]
            public void UpdateSong_ChangeValue()
            {
                _inputSystem.FetchStringValue($"Enter the name of the song you want to update").Returns("Imagine");
                _songRepository.GetSingle(Arg.Any<Func<Song, bool>>()).Returns(new Song
                {
                    SongId = Guid.NewGuid(),
                    Title = "Imagine",
                    Author = "John Lennon",
                    AlbumName = "Imagine",
                    Length = 3.05
                });
                _inputSystem.FetchStringValue("What do you want update: \n1. Title\n2. Author\n3. Album name\n4. Length").Returns("1");
                _inputSystem.FetchStringValue("Enter new title for song:").Returns("New Imagine");

                Song updatedSong = _songHandler.UpdateSong();
                Assert.That(updatedSong.Title, Is.EqualTo("New Imagine"));
            }
        }
    
}
