using System;
using System.Web;

namespace LR1
{
    public class IISHandler5 : IHttpHandler
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
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            if (req.HttpMethod == "POST")
            {
                int x = Convert.ToInt32(context.Request.Params["X"]);
                int y = Convert.ToInt32(context.Request.Params["Y"]);

                string result = $"{x} * {y} = {x * y}";
                res.Write(result);
            }
            else if (req.HttpMethod == "GET")
            {
                res.WriteFile("task5.html");
            }
        }

        #endregion
    }
}
