using Microsoft.AspNetCore.Identity;

namespace EmailApp.Validations
{
    public class CustomErrorDescriber:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code="PasswordRequiresDigit",
                Description="Şifre En Az 1 Rakam İçermelidir."
            };

        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = "Şifre En Az 1 Küçük Harf İçermelidir."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Şifre En Az 1 Büyük Harf İçermelidir."
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = $"Şifre En Az {length} karakterden oluşmalıdır."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Şifre En Az 1 Özel Karakter İçermelidir"
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = "DuplicateUserName",
                Description = $"{userName} kullanıcı adı daha önce alınmıştır."
            };
        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = "DuplicateEmail",
                Description = $"{email} Email'i daha önce sisteme kaydolmuş."
            };
        }

    }
}
