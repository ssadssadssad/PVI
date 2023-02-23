using System;
using System.Web;

namespace LR1
{
    public class IISHandler6 : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //разместите здесь вашу реализацию обработчика.
            var method = context.Request.HttpMethod;
            HttpResponse response = context.Response;
            if (method.Equals("GET"))
            {
                response.Write("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n  " +
                    "  <meta charset=\"utf-8\" />\r\n  " +
                    "  <title></title>\r\n</head>\r\n<body>\r\n  " +
                    "  <h1>TASK 6 </h1>" +
                    "  <h2> Вывод html страницы GET запрос</h2>\r\n  " +
                    "  <form action=\"/handler6/\" method=\"post\">\r\n    " +
                    "    <input value=\"10\" name=\"parmX\"/>\r\n     " +
                    "   <input value=\"10\" name=\"parmY\"/>\r\n   " +
                    "     <button type=\"submit\">Результат</button>\r\n  " +
                    "  </form>\r\n</body>\r\n</html>");
            }
            else if (method.Equals("POST"))
            {
                string parmX = context.Request.Params["parmX"];
                string parmY = context.Request.Params["parmY"];
                int result = int.Parse(parmX) * int.Parse(parmY);
                response.Write(result);
            }
        }

        #endregion
    }
}
