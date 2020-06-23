using AutomationPractice.Models;

namespace AutomationPractice.Factories
{
    public static class FormFactory
    {
        public static FormModel Create()
        {
            return new FormModel
            {
                FirstName = "FirstName",
                LastName = "LastName",
                Password = "Password123$",
                Address = "ul. Nqkyde v grada 32",
                City = "Sofia",
                PostCode = "01000",
                PhoneNumber = "0888888888",
            };
        }
    }
}
