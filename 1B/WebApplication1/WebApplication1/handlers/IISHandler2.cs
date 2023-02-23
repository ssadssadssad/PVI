﻿using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.WebSockets;

namespace WebApplication1.handlers
{
    public class IISHandler2 : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        WebSocket   socket;
        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            if (context.IsWebSocketRequest)
                context.AcceptWebSocketRequest(WebSocketRequest);  //подтверждение использования вебсокет
        }

        private async Task WebSocketRequest(AspNetWebSocketContext context)
        {
            socket = context.WebSocket;
            string s = await Receive();
            await Send(s);
            int i = 0;
            while(socket.State == WebSocketState.Open)  //когда вебсокет открыт
            {
                Send(DateTime.Now.ToString("HH:mm:ss")); //записывание времени в переменную
                Thread.Sleep(2000);
            }
        }

        private async Task Send(string s)
        {
            var sendbuffer = new ArraySegment<byte>(System.Text.Encoding.UTF8.GetBytes("Ответ: " + s));  //генерация ответа
            await socket.SendAsync(sendbuffer, System.Net.WebSockets.WebSocketMessageType.Text, true, CancellationToken.None); //Строка+Тип+асинхронность+токен закрытия
        }

        private async Task<string> Receive()
        {
            string rc = null;
            var buffer = new ArraySegment<byte>(new byte[512]);  //переменная типа байт для result  
            var result = await socket.ReceiveAsync(buffer, CancellationToken.None);  //записывание в buffer
            rc = System.Text.Encoding.UTF8.GetString(buffer.Array, 0, result.Count);  //пихаем в переменную строку байт buffer, индекс декодируемого байта, число байт для декодирования
            return rc;
        }
        #endregion
    }
}
