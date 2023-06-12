namespace LadyParty.WinForms.Compartilhado
{
    public static class UserControlExtension
    {
        public static void ConfigurarUserControl(this UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
        }
    }
}
