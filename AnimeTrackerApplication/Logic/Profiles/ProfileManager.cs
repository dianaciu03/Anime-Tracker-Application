﻿using DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
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

        public Profile GetProfileById(int id)
        {
            return profileRepository.GetProfileById(id);
        }

        public void AddProfilePicture(int profileId, string name, MemoryStream ms, string contentType)
        {
            profileRepository.AddProfilePicture(profileId, name, ms, contentType);
        }

        public void UpdateProfilePicture(int profileId, string name, MemoryStream ms, string contentType)
        {
            profileRepository.UpdateProfilePicture(profileId, name, ms, contentType);
        }

        public FileContentResult GetProfilePicture(int profileId)
        {
            return profileRepository.GetProfilePicture(profileId);
        }

        public bool HasProfilePicture(int profileId)
        {
            return profileRepository.HasProfilePicture(profileId);
        }

        public void UpdateUsername(int profileId, string username)
        {
            profileRepository.UpdateUsername(profileId, username);
        }
    }
}
