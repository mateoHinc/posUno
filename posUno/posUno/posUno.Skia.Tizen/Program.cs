using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace posUno.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new posUno.App(), args);
            host.Run();
        }
    }
}
