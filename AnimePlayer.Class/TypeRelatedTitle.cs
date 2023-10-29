using System;

namespace AnimePlayer.Class
{
    [Serializable]
    public enum TypeRelatedTitle : int
    {
        Sequel = 0,
        Prequel = 1,
        Main_history = 2,
        Side_story = 3,
        Summary = 4,
        Other = 5,
        NA = 6
    }

    public static class TypeRelatedTitleHelper
    {
        public static string ConvertToFriendlyString(this TypeRelatedTitle typeRelatedTitle)
        {
            string result = null;
            switch((int)typeRelatedTitle)
            {
                case 0: result = "Sequel";break;
                case 1: result = "Prequel";break;
                case 2: result = "Główna historia"; break;
                case 3: result = "Poboczna historia"; break;
                case 4: result = "Podsumowanie";break;
                case 5: result = "Inne";break;
                case 6: result = "N/A";break;
            }

            return result;
        }

        public static TypeRelatedTitle ConvertFromString(string text)
        {
            text = text.ToLower();
            TypeRelatedTitle typeRelatedTitle = TypeRelatedTitle.NA;
            if(text == "sequel")
            {
                typeRelatedTitle = TypeRelatedTitle.Sequel;
            }
            if(text == "prequel")
            {
                typeRelatedTitle = TypeRelatedTitle.Prequel;
            }
            if(text == "mainhistory")
            {
                typeRelatedTitle = TypeRelatedTitle.Main_history;
            }
            if(text == "sidestory")
            {
                typeRelatedTitle = TypeRelatedTitle.Side_story;
            }
            if(text == "summary")
            {
                typeRelatedTitle = TypeRelatedTitle.Summary;
            }
            if(text == "other")
            {
                typeRelatedTitle = TypeRelatedTitle.Other;
            }
            if(text == "na")
            {
                typeRelatedTitle = TypeRelatedTitle.NA;
            }
            return typeRelatedTitle;
        }
    }
}