using System.Windows.Controls;

namespace ShaitanetDinar421
{
    public static class Navigation
    {
        public static Frame MainFrame { get; private set; }

        public static void Intialize(Frame mainFrame)
        {
            MainFrame = mainFrame;
        }

        public static void NextPage(Page page)
        {
            MainFrame?.Navigate(page);
        }

        public static void BackPage()
        {
            if (MainFrame != null && MainFrame.CanGoBack)
                MainFrame.GoBack();
        }
    }
}
