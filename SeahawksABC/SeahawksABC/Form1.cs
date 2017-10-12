using Common;
using Core;
using Common.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeahawksABC
{
    public partial class Form1 : Form
    {
        private Player player = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.save.Enabled = false;
            Task.Run(() => this.SavePlayer(player));
        }

        private void position_TextChanged(object sender, EventArgs e)
        {
            string value = ((TextBox)sender).Text;
            value = value.ToLowerInvariant();
            int positionInt;
            switch (value)
            {
                case "gb":
                    positionInt = 1;
                    break;
                case "rb":
                    positionInt = 2;
                    break;
                case "dt":
                    positionInt = 3;
                    break;
                case "rt":
                    positionInt = 4;
                    break;
                case "cb":
                    positionInt = 5;
                    break;
                case "lb":
                    positionInt = 6;
                    break;
                default:
                    positionInt = 0;
                    break;
            }
            this.player.Position = positionInt;
        }

        private int StringToInt(object sender)
        {
            string numberText = ((TextBox)sender).Text;
            int value = 0;
            int.TryParse(numberText, out value);
            return value;
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            this.player.Age = StringToInt(sender);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            this.player.Name = ((TextBox)sender).Text;
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            this.player.LastName = ((TextBox)sender).Text;
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            this.player.Number = StringToInt(sender);
        }

        private void college_TextChanged(object sender, EventArgs e)
        {
            this.player.College = ((TextBox)sender).Text;
        }

        private async Task SavePlayer(Player player)
        {
            Logger.Instance.Log(LogLevel.Info, "Guardando jugador " + player.Name);
            PlayerManager playerManager = new PlayerManager();
            bool result = await playerManager.SavePlayer(player);
            string message = string.Empty;
            if (result)
            {
                message = "Guardado"; 
            }
            else
            {
                message = "No se pudo guardar";
            }

            this.ShowStatusMessage(message);
        }

        private void ShowStatusMessage(string message)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(ShowStatusMessage), new object[]
                    {message} );
                return;
            }

            this.statusMessage.Text = message;

        }

    }
}
