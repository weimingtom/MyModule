using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyModule
{
    public class SyncModule : IHttpModule
    {
        public void Init(HttpApplication app)
        {
            app.BeginRequest += new EventHandler(OnBeginRequest);
        }

        public void Dispose() { }

        public delegate void MyEventHandler(Object s, EventArgs e);
        private MyEventHandler _eventHandler = null;

        public event MyEventHandler MyEvent
        {
            add { _eventHandler += value; }
            remove { _eventHandler -= value; }
        }

        public void OnBeginRequest(Object s, EventArgs e) 
        {
            HttpApplication app = s as HttpApplication;
            app.Context.Response.Write("Hola desde el módulo personalizado OnBeginRequest.<br>");
            if (_eventHandler != null)
                _eventHandler(this, null);
        }
    }
}
