using System.Collections.ObjectModel;

namespace Xamarin.Netflix.Services.Profile
{
    public class ProfileService : IProfileService
    {
        public ObservableCollection<Models.Profile> GetProfiles()
        {
            return new ObservableCollection<Models.Profile>
            {
                new Models.Profile { Name = "Sam", Picture = "profile1.png", ProfileType = Models.ProfileType.Profile },
                new Models.Profile { Name = "Some", Picture = "profile2.png", ProfileType = Models.ProfileType.Profile },
                new Models.Profile { Name = "Other", Picture = "profile3.png", ProfileType = Models.ProfileType.Profile },
                new Models.Profile { Name = "Dude", Picture = "profile4.png", ProfileType = Models.ProfileType.Profile },
                new Models.Profile { Name = "Add profile", Picture = "add.png", ProfileType = Models.ProfileType.NewProfile },
                new Models.Profile { ProfileType = Models.ProfileType.None }
            };
        }
    }
}