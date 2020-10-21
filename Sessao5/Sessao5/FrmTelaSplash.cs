using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Sessao5
{
    public partial class FrmTelaSplash : Form
    {

        WMPLib.IWMPPlayer _player;
        public FrmTelaSplash()
        {
            InitializeComponent();
        }

        private void FrmTelaSplash_Load(object sender, EventArgs e)
        {
            player.URL = @"C:\Users\mauri\Desktop\Treinamento\ProvasAprovadas\Sessao5\Projeto Teste\S5\Data Files\Videos\video1.mp4";
            player.settings.autoStart = true;
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
