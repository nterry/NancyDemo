using System.IO;
using Nancy;


namespace NancyDemo
{
    public class FooModule : NancyModule
    {
        public FooModule()
        {
            //Super awesome schizophrenic bunny
            Get["/"] = _ =>
            {
                return new Response
                {
                    StatusCode = HttpStatusCode.OK,
                    ContentType = "text/plain",
                    Contents = stream =>
                    {
                        using (var writer = new StreamWriter(stream))
                        {
                            writer.Write("   (\\_/)\n   (0_0)\n  C(\")(\")\nMoo! I'm a cow!");
                        };
                    }
                };
            };

            //Just plain OK response
            Get["/awesome"] = _ =>
            {
                return new Response
                {
                    StatusCode = HttpStatusCode.OK
                };
            };
        }
    }
}
