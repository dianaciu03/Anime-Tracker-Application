﻿namespace Logic.Profiles
{
    public interface IListManager
    {
        void AddContentToCustomList(object content, CustomList customList);
        void DeleteContentFromList(object content, List<CustomList> customList);
        List<CustomList> GetAnimeListByProfileId(int id);
    }
}