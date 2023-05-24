﻿using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Profiles
{
    public class ProfileManager : IProfileManager
    {
        private readonly IProfileRepository profileRepository;

        public ProfileManager(IProfileRepository profileRepository)
        {
            this.profileRepository = profileRepository;
        }

        public void AddPreferedGenres(Profile profile)
        {
            profileRepository.AddPreferredGenres(profile.GetAllPreferredGenres().ToArray(), profile.Id);
        }
        public void DeleteContentFromList(Profile profile)
        {
            profileRepository.DeleteContentFromList(profile.Id);
        }
    }
}
