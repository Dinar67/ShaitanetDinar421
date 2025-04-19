using System.Windows;

namespace ShaitanetDinar421
{
    public static class Logger
    {
        public static bool ShowYesNo(string text)
        {
            return MessageBox.Show(text, "Вы точно хотите подтвердить операцию?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes? true : false;
        }
        public static void ShowWarning(string text)
        {
            MessageBox.Show(text, "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        public static void ShowInformation(string text)
        {
            MessageBox.Show(text, "Ифнормация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
