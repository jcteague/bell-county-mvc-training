namespace MvcTraining.Services
{
    public interface IFormsAuthenticationService {
        void SignIn(string userName, bool createPersistentCookie);
        void SignOut();
    }
}