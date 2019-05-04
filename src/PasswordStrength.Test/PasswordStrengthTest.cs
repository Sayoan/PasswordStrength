using Xunit;

namespace PasswordStrength.Test
{
    public class PasswordStrengthTest
    {
        [Fact]
        public void Test_EmptyPassword_False()
        {
            bool isPasswordStrength = PasswordStrength.IsStrongPassword(string.Empty);
            Assert.False(isPasswordStrength);
        }

        [Fact]
        public void Test_FilledPassword_True()
        {
            bool isPasswordStrength = PasswordStrength.IsStrongPassword("123456");
            Assert.True(isPasswordStrength);
        }
    }
}
