using GokFramework.IoCContainer;
using GokFramework.Logger;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Logger Test
        //Application_Start'da bir kere çalıştırılacak, injection için.
        IoCResolver.getInstance.Resolve<LoggerContext, FileLogger>();

        //Tüm projelerde injection yapılan tipte çalışacaktır.
        LoggerContext.Log(MethodBase.GetCurrentMethod(), "deneme");
        #endregion
    }
}