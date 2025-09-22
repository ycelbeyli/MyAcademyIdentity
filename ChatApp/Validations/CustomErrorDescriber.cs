using Microsoft.AspNetCore.Identity;

namespace ChatApp.Validations
{
    public class CustomErrorDescriber:IdentityErrorDescriber
    {

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresDigit",
                Description="Şifre en az bir rakam içermelidir"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = "Şifre en az bir küçük harf içermelidir."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Şifre en az bir büyük harf içermelidir."
            };

        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = $"Şifre en az {length} karakterden oluşmalıdır."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Şifre en az bir özel karakter içermelidir."
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = "DuplicateUserName",
                Description = $"{userName} kullanıcı adı daha önce alınmış."
            };

        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = "DuplicateEmail",
                Description = "Daha önce bu mail ile sisteme kaydolunmuş."
            };

        }

    }
}
