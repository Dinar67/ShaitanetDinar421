using ShaitanetDinar421.Databases;
using System.Windows;

namespace ShaitanetDinar421
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ExamDinarEntities db = new ExamDinarEntities();
    }
}
