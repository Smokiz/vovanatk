using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private object maskedTextBox1;

        [Fact]
        public void Test1()
        {
            if (maskedTextBox1.Text == "qwerty")
            {
                AdForm adForm = new AdForm(this);
                adForm.Show();
                this.Hide();
            }
        }
    }
}
