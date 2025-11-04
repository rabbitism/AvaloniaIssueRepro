using Avalonia.Controls;
using Avalonia.Headless;
using Avalonia.Headless.XUnit;
using Avalonia.Input;

namespace AccessKeyFocusTest;

public class FocusTest
{
    [AvaloniaFact]
    public void Test1()
    {
        TestWindow window = new TestWindow();
        window.Show();
        var text = window.text;
        var text2 = window.text2;

        text2.Focus();
        
        Assert.False(text.IsFocused);
        Assert.True(text2.IsFocused);
        
        window.KeyPressQwerty(PhysicalKey.N, RawInputModifiers.Alt);

        Assert.True(text.IsFocused);
        Assert.False(text2.IsFocused);
    }
}