using System;

namespace VideoGameCatalogue
{
    public class ReviewOwner
    {
        private static Game game;
        private static User user;
        

        public static implicit operator ReviewOwner(Game game)
        {
            return game;
        }

        public static implicit operator ReviewOwner(User user)
        {
            return user;
        }
    }
}