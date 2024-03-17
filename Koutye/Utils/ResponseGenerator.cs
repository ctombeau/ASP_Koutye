using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Koutye.Utils
{
    public class ResponseGenerator
    {
        public static int code { get; set; }
        public static string message { get; set; }
        public static Object obj { get; set; }
        public static bool succees { get; set; }


        public ResponseGenerator successResponse(bool succees,Object obj,int code, string message)
        {
            return new ResponseGenerator();
        }

        public ResponseGenerator errorResponse(bool succees, Object obj, int code, string message)
        {
            return new ResponseGenerator();
        }
    }
}
