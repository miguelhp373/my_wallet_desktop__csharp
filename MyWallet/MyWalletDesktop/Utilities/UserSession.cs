using MyWalletDesktop.Models;

namespace MyWalletDesktop.Utilities
{
    public static class UserSession
    {
        static UserSession()
        {
            // Inicializa a propriedade CurrentUser
            CurrentUser = new User();
        }

        private static User currentUser;

        public static User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
    }
}
