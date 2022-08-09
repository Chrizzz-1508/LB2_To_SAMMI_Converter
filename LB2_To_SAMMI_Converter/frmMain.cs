using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LB2_To_SAMMI_Converter
{
    public partial class ExtensionConverter : Form
    {
        string sFilePath = "";
        public ExtensionConverter()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select your .lb2 file";
            ofd.Filter = "LB2 Extension|*.lb2";
            ofd.Multiselect = false;

            if (DialogResult.OK == ofd.ShowDialog())
            {
                using (StreamReader sr = new StreamReader(ofd.FileName,true))
                {
                    rtbLB2.Text = sr.ReadToEnd();
                    txtFileName.Text = ofd.SafeFileName.Replace(".lb2","");

                    sr.Close();
                }
                sFilePath = ofd.FileName.Replace(ofd.SafeFileName, "").Replace(".lb2","");
                btnConvert_Click(null, null);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string s = rtbLB2.Text;
            s = s.Replace("LioranBoardJSON.", "SAMMIJSON.");

            Regex reg = new Regex("\"lioranboard_version\":\"(.{4,15})\"\\W");
            Match m = reg.Match(s);
            if (m.Success)
            {
                s = s.Replace(m.Groups[1].Value, "2022.4.0");
            }

            s = s.Replace("\"lioranboard_version\":", "\"sammi_version\":");

            s = s.Replace("lioranboardclient.send(", "sammiclient.send(");
            s = s.Replace("LB.method(", "SAMMI.method(");
            s = s.Replace("LB.getVariable(", "SAMMI.getVariable(");
            s = s.Replace("LB.setVariable(", "SAMMI.setVariable(");
            s = s.Replace("LB.deleteVariable(", "SAMMI.deleteVariable(");
            s = s.Replace("LB.insertArray(", "SAMMI.insertArray(");
            s = s.Replace("LB.deleteArray(", "SAMMI.deleteArray(");
            s = s.Replace("LB.extCommand(", "SAMMI.extCommand(");
            s = s.Replace("LB.triggerExt(", "SAMMI.triggerExt(");
            s = s.Replace("LB.triggerButton(", "SAMMI.triggerButton(");
            s = s.Replace("LB.modifyButton(", "SAMMI.modifyButton(");
            s = s.Replace("LB.popUp(", "SAMMI.popUp(");
            s = s.Replace("LB.alert(", "SAMMI.alert(");
            s = s.Replace("LB.notification(", "SAMMI.notification(");
            s = s.Replace("LB.getDeckList(", "SAMMI.getDeckList(");
            s = s.Replace("LB.getDeck(", "SAMMI.getDeck(");
            s = s.Replace("LB.getImage(", "SAMMI.getImage(");
            s = s.Replace("LB.getSum(", "SAMMI.getSum(");
            s = s.Replace("LB.stayInformed(", "SAMMI.stayInformed(");
            s = s.Replace("LB.getActiveButtons(", "SAMMI.getActiveButtons(");
            s = s.Replace("LB.getModifiedButtons(", "SAMMI.getModifiedButtons(");
            s = s.Replace("LB.getTwitchList(", "SAMMI.getTwitchList(");
            s = s.Replace("LB.trigger(", "SAMMI.trigger(");
            s = s.Replace("LB.close(", "SAMMI.close(");
            s = s.Replace("lioranboard.on(", "sammiclient.on(");
            s = s.Replace("lioranboardclient.addListener(", "sammiclient.addListener(");
            s = s.Replace("lioranboardclient.removeListener(", "sammiclient.removeListener(");
            s = s.Replace("Lioranboard Startup", "SAMMI Startup");
            s = s.Replace("Lioranboard Shutdown", "SAMMI Shutdown");
            s = s.Replace("Lioranboard Reset", "SAMMI Reset");
            s = s.Replace("Lioranboard Crash", "SAMMI Crash");
            s = s.Replace("Lioranboard Deck Reload", "SAMMI Deck Reload");

            rtbSEF.Text = s;

            if(sender == null)
            {
                btnSave_Click(null, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(rtbSEF.Text) || String.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show("Not all fields were filled out correctly. Save process aborted!");
            }
            if (String.IsNullOrEmpty(sFilePath))
            {
                sFilePath = AppDomain.CurrentDomain.BaseDirectory;
            }
            using (StreamWriter sw = new StreamWriter(sFilePath + txtFileName.Text + ".sef"))
            {
                sw.Write(rtbSEF.Text.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n"));
                sw.Flush();
                sw.Close();
            }
            if (sender != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Extension " + txtFileName.Text + " was created in " + sFilePath + ". Open the folder now?", "Open folder?", MessageBoxButtons.YesNo))
                {
                    Process.Start(sFilePath);
                }
            }
        }
    }
}
