using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Xml.Linq;

namespace Sessao5
{
    public partial class FrmTelaSplash : Form
    {

        public FrmTelaSplash()
        {
            InitializeComponent();
        }
        string currentFile = $@"{AppDomain.CurrentDomain.BaseDirectory}Video.xml";
        private void FrmTelaSplash_Load(object sender, EventArgs e)
        {
            XElement x = XElement.Load(currentFile);
            if (!File.Exists(currentFile))
            {
                var document = new XDocument(new XElement("video"));
                document.Save(currentFile);
                x.Add(new XElement("ID", 1));
            }
            int tentativas = int.Parse(x.Element("ID").Value);
            switch (tentativas)
            {
                case 1:
                    var path1 = Path.Combine(Application.StartupPath, "video1.mp4");
                    File.WriteAllBytes(path1, Properties.Resources.video1);
                    player.URL = path1;
                    player.settings.autoStart = true;
                    XElement xml = new XElement("video");
                    xml.Add(new XElement("ID", 2));
                    xml.Save(currentFile);
                    break;
                case 2:
                    var path2 = Path.Combine(Application.StartupPath, "video2.mp4");
                    File.WriteAllBytes(path2, Properties.Resources.video2);
                    player.URL = path2;
                    player.settings.autoStart = true;
                    XElement xml2 = new XElement("video");
                    xml2.Add(new XElement("ID", 3));
                    xml2.Save(currentFile);
                    break;
                case 3:
                    var path3 = Path.Combine(Application.StartupPath, "video3.mp4");
                    File.WriteAllBytes(path3, Properties.Resources.video3);
                    player.URL = path3;
                    player.settings.autoStart = true;
                    XElement xml3 = new XElement("video");
                    xml3.Add(new XElement("ID", 1));
                    xml3.Save(currentFile);
                    break;
            }
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
