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
        public void Test_FilledPassword_SizeLess8()
        {
            bool isPasswordStrength = PasswordStrength.IsStrongPassword("123456");
            Assert.False(isPasswordStrength);
        }

        [Fact]
        public void Test_FilledPassword_SizeThen8()
        {
            bool isPasswordStrength = PasswordStrength.IsStrongPassword("1234567A");
            Assert.True(isPasswordStrength);
        }

        [Fact]
        public void Test_FilledPassword_SizeMax16_False()
        {
            bool isPasswordStrength = PasswordStrength.IsStrongPassword("12345678123456789");
            Assert.False(isPasswordStrength);
        }

        [Fact]
        public void Test_FilledPassword_SizeMax16_True()
        {
            bool isPasswordStrength = PasswordStrength.IsStrongPassword("123456789012345A");
            Assert.True(isPasswordStrength);
        }

        [Fact]
        public void Test_OnlyNumbers_False()
        {
            bool isPasswordStrength = PasswordStrength.IsStrongPassword("12345678");
            Assert.False(isPasswordStrength);
        }

        [Fact]
        public void Test_UpperCase()
        {
            bool isPasswordStrength = PasswordStrength.IsStrongPassword("12345678aA");
            Assert.True(isPasswordStrength);
        }
    }
}
