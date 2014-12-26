using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Process[] pr = Process.GetProcesses();
            foreach(Process p in pr)
            {
                Button btn = new Button();
                btn.Text = p.Id + " : " + p.ProcessName + "\r\n";
                //btn.Click += new EventHandler((object shit, EventArgs fuck) => { try { p.CloseMainWindow(); p.Kill(); } catch { } });
                Panel1.Controls.Add(btn);
                
            }
            Button Shutdwon = new Button();
            Shutdwon.Text = ("shutdwon server");
            //Shutdwon.Click += new EventHandler((object blah, EventArgs blahblah) => { try { Process.Start("shutdown", "/s /t 0"); } catch { } });
            Panel1.Controls.Add(Shutdwon);

        }
    }
}