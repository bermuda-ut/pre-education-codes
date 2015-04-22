using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DotaKeyGlobalBind
{


    public partial class MainBinding : Form
    {
        public string savedir;

        bool movekey = false;
        string movecommand;

        public string autoexec;
        public string TEMPautoexec;
        public string config;
        public string TEMPconfig;
        public string settings;
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Dota 2 Universal Key Bind by Bermuda/dota2keybind_settings.txt");

        string defaultset = @"unused :dota_hold
unused :+dota_control_group 10
unused :+dota_control_group 1
unused :+dota_control_group 2
unused :+dota_control_group 3
unused :+dota_control_group 4
unused :+dota_control_group 5
unused :+dota_control_group 6
unused :+dota_control_group 7
unused :+dota_control_group 8
unused :+dota_control_group 9
unused :mc_attack
unused :dota_ability_learn_mode
unused :inspectheroinworld
unused :dota_glyph
unused :dota_stop
unused :dota_learn_stats
unused :dota_item_execute 5
unused :dota_item_execute 4
unused :dota_item_execute 2
unused :dota_item_execute 3
unused :dota_item_execute 1
unused :use_item_client current_hero taunt
unused :dota_item_execute 0
unused :dota_select_all_others
unused :dota_courier_deliver
unused :dota_courier_burst
unused :use_item_client player_loadout action_item
unused :+chatwheel
unused :+voicerecord
unused :+showscores
unused :+cameragrip
unused :say
unused :stash_grab_all
unused :toggleshoppanel
unused :dota_recent_event
unused :dota_select_all
unused :dota_cycle_selected
unused :cancelselect
unused :dota_purchase_stickybuy
unused :pause
unused :+forward
unused :+moveleft
unused :+back
unused :+moveright
unused :+dota_camera_follow
unused :dota_select_courier
unused :jpeg
unused :dota_pause
unused :mc_move
unused :dota_purchase_quickbuy
unused :chatwheel_say 0
unused :chatwheel_say 1
unused :chatwheel_say 2
unused :chatwheel_say 3
unused :chatwheel_say 4
unused :chatwheel_say 5
unused :chatwheel_say 6
unused :chatwheel_say 7
unused :chatwheel_say 8
unused :chatwheel_say 9
unused :chatwheel_say 10
unused :chatwheel_say 11
unused :chatwheel_say 12
unused :chatwheel_say 13
unused :chatwheel_say 14
unused :chatwheel_say 15
unused :chatwheel_say 16
unused :chatwheel_say 17
unused :chatwheel_say 18
unused :chatwheel_say 19
unused :chatwheel_say 20
unused :chatwheel_say 21
unused :chatwheel_say 22
unused :chatwheel_say 23
unused :chatwheel_say 24
unused :chatwheel_say 25
unused :chatwheel_say 26
unused :chatwheel_say 27
unused :chatwheel_say 28
unused :chatwheel_say 29
unused :chatwheel_say 30
unused :chatwheel_say 31
unused :chatwheel_say 32
unused :chatwheel_say 33
unused :chatwheel_say 34
unused :chatwheel_say 35
unused :chatwheel_say 36
unused :chatwheel_say 37
unused :chatwheel_say 38
unused :chatwheel_say 39
unused :chatwheel_say 40
unused :chatwheel_say 41
unused :chatwheel_say 42
unused :chatwheel_say 43
unused :chatwheel_say 44
unused :chatwheel_say 45
unused :chatwheel_say 46
unused :chatwheel_say 47
unused :chatwheel_say 48
unused :chatwheel_say 49
unused :chatwheel_say 50
unused :chatwheel_say 51
unused :chatwheel_say 52
unused :chatwheel_say 53
unused :chatwheel_say 54
unused :chatwheel_say 55
unused :chatwheel_say 56
unused :chatwheel_say 57
unused :chatwheel_say 58
unused :chatwheel_say 59
unused :chatwheel_say 60
unused :chatwheel_say 61
unused :chatwheel_say 62
unused :chatwheel_say 63
unused :chatwheel_say 64
unused :chatwheel_say 65
unused :chatwheel_say 66
unused :chatwheel_say 67
unused :chatwheel_say 68
unused :chatwheel_say 69
unused :chatwheel_say 70
unused :chatwheel_say 71
unused :chatwheel_say 72
unused :chatwheel_say 73
unused :chatwheel_say 74
unused :chatwheel_say 75
unused :chatwheel_say 76
unused :chatwheel_say 77
unused :chatwheel_say 78
unused :chatwheel_say 79
unused :chatwheel_say 80
unused :chatwheel_say 81
unused :chatwheel_say 82
unused :chatwheel_say 83
unused :chatwheel_say 84
unused :chatwheel_say 85";

        int[] syncing =       { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        string[] syncingKEY = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "[", "]", "a", "s", "d", "f", "g", "h", "j", "k", "l", ";", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "/", "`", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "TAB", "CAPSLOCK", "\\", "ENTER", "SPACE", "BACKSPACE", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "INS", "HOME", "PGUP", "DEL", "END", "PGDN", "KP_DIVIDE", "KP_MULTIPLY", "KP_MINUS", "KP_PLUS", "KP_ENTER", "KP_DEL", "KP_0", "KP_1", "KP_2", "KP_3", "KP_4", "KP_5", "KP_6", "KP_7", "KP_8", "KP_9", "UPARROW", "LEFTARROW", "DOWNARROW", "RIGHTARROW", "ESC"};
        string[] syncingCMD = { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null};
        string[] syncingVIEW = { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null};


        public MainBinding()
        {
            if (File.Exists(fileName))
            {
                string lineq;
                System.IO.StreamReader file5 = new System.IO.StreamReader(fileName);
                while ((lineq = file5.ReadLine()) != null)
                {
                    if (lineq.StartsWith("Directory"))
                    {
                        string[] divided = lineq.Split('>'); // split the line with ", results in 1=key, 3=function
                        savedir = divided[1];
                    }
                }
                file5.Close();
                InitializeComponent();
            }
            else
            {
                this.Hide();
                Directory settingsForm = new Directory();
                // Show the settings form
                settingsForm.Show();
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
        }

        public void readkey(string key, string func)
        {
            switch (key.ToUpper())//the most fucking stupid long way of doing this. Much way to do using for loop, lazy to fix :P
            {
                case "Q": key_q.Text = func; break;
                case "W": key_w.Text = func; break;
                case "E": key_e.Text = func; break;
                case "R": key_r.Text = func; break;
                case "T": key_t.Text = func; break;
                case "Y": key_y.Text = func; break;
                case "U": key_u.Text = func; break;
                case "I": key_i.Text = func; break;
                case "O": key_o.Text = func; break;
                case "P": key_p.Text = func; break;
                case "A": key_a.Text = func; break;
                case "S": key_s.Text = func; break;
                case "D": key_d.Text = func; break;
                case "F": key_f.Text = func; break;
                case "G": key_g.Text = func; break;
                case "H": key_h.Text = func; break;
                case "J": key_j.Text = func; break;
                case "K": key_k.Text = func; break;
                case "L": key_l.Text = func; break;
                case "Z": key_z.Text = func; break;
                case "X": key_x.Text = func; break;
                case "C": key_c.Text = func; break;
                case "V": key_v.Text = func; break;
                case "B": key_b.Text = func; break;
                case "N": key_n.Text = func; break;
                case "M": key_m.Text = func; break;
                case "1": key_1.Text = func; break;
                case "2": key_2.Text = func; break;
                case "3": key_3.Text = func; break;
                case "4": key_4.Text = func; break;
                case "5": key_5.Text = func; break;
                case "6": key_6.Text = func; break;
                case "7": key_7.Text = func; break;
                case "8": key_8.Text = func; break;
                case "9": key_9.Text = func; break;
                case "0": key_0.Text = func; break;
                case "-": minus.Text = func; break;
                case "=": equal.Text = func; break;
                case "`": shop.Text = func; break;
                case "TAB": TAB.Text = func; break;
                case "CAPSLOCK": CAPSLOCK.Text = func; break;
                case "[": sqbrktopen.Text = func; break;
                case "]": sqbrktclose.Text = func; break;
                case ";": colon.Text = func; break;
                case "'": quote.Text = func; break;
                case ",": comma.Text = func; break;
                case ".": stop.Text = func; break;
                case "SPACE": SPACE.Text = func; break;
                case "BACKSPACE": BACKSPACE.Text = func; break;
                case "/": slash.Text = func; break;
                case "\\": won.Text = func; break;
                case "F1": F1.Text = func; break;
                case "F2": F2.Text = func; break;
                case "F3": F3.Text = func; break;
                case "F4": F4.Text = func; break;
                case "F5": F5.Text = func; break;
                case "F6": F6.Text = func; break;
                case "F7": F7.Text = func; break;
                case "F8": F8.Text = func; break;
                case "F9": F9.Text = func; break;
                case "F10": F10.Text = func; break;
                case "F11": F11.Text = func; break;
                case "F12": F12.Text = func; break;
                case "ESC": ESC.Text = func; break;
                case "INS": INS.Text = func; break;
                case "HOME": HOME.Text = func; break;
                case "DEL": DEL.Text = func; break;
                case "END": END.Text = func; break;
                case "PGUP": PGUP.Text = func; break;
                case "PGDN": PGDN.Text = func; break;
                case "UPARROW": UPARROW.Text = func; break;
                case "DOWNARROW": DOWNARROW.Text = func; break;
                case "LEFTARROW": LEFTARROW.Text = func; break;
                case "RIGHTARROW": RIGHTARROW.Text = func; break;
                case "KP_MINUS": KP_MINUS.Text = func; break;
                case "KP_PLUS": KP_PLUS.Text = func; break;
                case "KP_MULTIPLY": KP_MULTIPLY.Text = func; break;
                case "KP_ENTER": KP_ENTER.Text = func; break;
                case "KP_DEL": KP_DEL.Text = func; break;
                case "KP_DIVIDE": KP_DIVIDE.Text = func; break;
                case "ENTER": ENT.Text = func; break;
                case "KP_1": KP_1.Text = func; break;
                case "KP_2": KP_2.Text = func; break;
                case "KP_3": KP_3.Text = func; break;
                case "KP_4": KP_4.Text = func; break;
                case "KP_5": KP_5.Text = func; break;
                case "KP_6": KP_6.Text = func; break;
                case "KP_7": KP_7.Text = func; break;
                case "KP_8": KP_8.Text = func; break;
                case "KP_9": KP_9.Text = func; break;
                case "KP_0": KP_0.Text = func; break;
            }
        }

        public void givestatus(string str)
        {
            status.Text = str;
            status.Refresh();
        }

        public void print(string str)
        {
            if (output.Text != "")
                output.Text = output.Text + Environment.NewLine + str;
            else
                output.Text = str;

            output.SelectionStart = output.Text.Length;
            output.ScrollToCaret();
        }

        public void savetosync()
        {
            syncingCMD[0] = key_q.Text;
            syncingCMD[1] = key_w.Text;
            syncingCMD[2] = key_e.Text;
            syncingCMD[3] = key_r.Text;
            syncingCMD[4] = key_t.Text;
            syncingCMD[5] = key_y.Text;
            syncingCMD[6] = key_u.Text;
            syncingCMD[7] = key_i.Text;
            syncingCMD[8] = key_o.Text;
            syncingCMD[9] = key_p.Text;
            syncingCMD[10] = sqbrktopen.Text;
            syncingCMD[11] = sqbrktclose.Text;
            syncingCMD[12] = key_a.Text;
            syncingCMD[13] = key_s.Text;
            syncingCMD[14] = key_d.Text;
            syncingCMD[15] = key_f.Text;
            syncingCMD[16] = key_g.Text;
            syncingCMD[17] = key_h.Text;
            syncingCMD[18] = key_j.Text;
            syncingCMD[19] = key_k.Text;
            syncingCMD[20] = key_l.Text;
            syncingCMD[21] = colon.Text;
            syncingCMD[22] = quote.Text;
            syncingCMD[23] = key_z.Text;
            syncingCMD[24] = key_x.Text;
            syncingCMD[25] = key_c.Text;
            syncingCMD[26] = key_v.Text;
            syncingCMD[27] = key_b.Text;
            syncingCMD[28] = key_n.Text;
            syncingCMD[29] = key_m.Text;
            syncingCMD[30] = comma.Text;
            syncingCMD[31] = stop.Text;
            syncingCMD[32] = slash.Text;
            syncingCMD[33] = shop.Text;
            syncingCMD[34] = key_1.Text;
            syncingCMD[35] = key_2.Text;
            syncingCMD[36] = key_3.Text;
            syncingCMD[37] = key_4.Text;
            syncingCMD[38] = key_5.Text;
            syncingCMD[39] = key_6.Text;
            syncingCMD[40] = key_7.Text;
            syncingCMD[41] = key_8.Text;
            syncingCMD[42] = key_9.Text;
            syncingCMD[43] = key_0.Text;
            syncingCMD[44] = minus.Text;
            syncingCMD[45] = equal.Text;
            syncingCMD[46] = TAB.Text;
            syncingCMD[47] = CAPSLOCK.Text;
            syncingCMD[48] = won.Text;
            syncingCMD[49] = ENT.Text;
            syncingCMD[50] = SPACE.Text;
            syncingCMD[51] = BACKSPACE.Text;
            syncingCMD[52] = F1.Text;
            syncingCMD[53] = F2.Text;
            syncingCMD[54] = F3.Text;
            syncingCMD[55] = F4.Text;
            syncingCMD[56] = F5.Text;
            syncingCMD[57] = F6.Text;
            syncingCMD[58] = F7.Text;
            syncingCMD[59] = F8.Text;
            syncingCMD[60] = F9.Text;
            syncingCMD[61] = F10.Text;
            syncingCMD[62] = F11.Text;
            syncingCMD[63] = F12.Text;
            syncingCMD[64] = INS.Text;
            syncingCMD[65] = HOME.Text;
            syncingCMD[66] = PGUP.Text;
            syncingCMD[67] = DEL.Text;
            syncingCMD[68] = END.Text;
            syncingCMD[69] = PGDN.Text;
            syncingCMD[70] = KP_DIVIDE.Text;
            syncingCMD[71] = KP_MULTIPLY.Text;
            syncingCMD[72] = KP_MINUS.Text;
            syncingCMD[73] = KP_PLUS.Text;
            syncingCMD[74] = KP_ENTER.Text;
            syncingCMD[75] = KP_DEL.Text;
            syncingCMD[76] = KP_0.Text;
            syncingCMD[77] = KP_1.Text;
            syncingCMD[78] = KP_2.Text;
            syncingCMD[79] = KP_3.Text;
            syncingCMD[80] = KP_4.Text;
            syncingCMD[81] = KP_5.Text;
            syncingCMD[82] = KP_6.Text;
            syncingCMD[83] = KP_7.Text;
            syncingCMD[84] = KP_8.Text;
            syncingCMD[85] = KP_9.Text;
            syncingCMD[86] = UPARROW.Text;
            syncingCMD[87] = LEFTARROW.Text;
            syncingCMD[88] = DOWNARROW.Text;
            syncingCMD[89] = RIGHTARROW.Text;
            syncingCMD[90] = ESC.Text;
        }

        public void synckeyview()
        {
            syncingVIEW[0] = key_q.Text;
            syncingVIEW[1] = key_w.Text;
            syncingVIEW[2] = key_e.Text;
            syncingVIEW[3] = key_r.Text;
            syncingVIEW[4] = key_t.Text;
            syncingVIEW[5] = key_y.Text;
            syncingVIEW[6] = key_u.Text;
            syncingVIEW[7] = key_i.Text;
            syncingVIEW[8] = key_o.Text;
            syncingVIEW[9] = key_p.Text;
            syncingVIEW[10] = sqbrktopen.Text;
            syncingVIEW[11] = sqbrktclose.Text;
            syncingVIEW[12] = key_a.Text;
            syncingVIEW[13] = key_s.Text;
            syncingVIEW[14] = key_d.Text;
            syncingVIEW[15] = key_f.Text;
            syncingVIEW[16] = key_g.Text;
            syncingVIEW[17] = key_h.Text;
            syncingVIEW[18] = key_j.Text;
            syncingVIEW[19] = key_k.Text;
            syncingVIEW[20] = key_l.Text;
            syncingVIEW[21] = colon.Text;
            syncingVIEW[22] = quote.Text;
            syncingVIEW[23] = key_z.Text;
            syncingVIEW[24] = key_x.Text;
            syncingVIEW[25] = key_c.Text;
            syncingVIEW[26] = key_v.Text;
            syncingVIEW[27] = key_b.Text;
            syncingVIEW[28] = key_n.Text;
            syncingVIEW[29] = key_m.Text;
            syncingVIEW[30] = comma.Text;
            syncingVIEW[31] = stop.Text;
            syncingVIEW[32] = slash.Text;
            syncingVIEW[33] = shop.Text;
            syncingVIEW[34] = key_1.Text;
            syncingVIEW[35] = key_2.Text;
            syncingVIEW[36] = key_3.Text;
            syncingVIEW[37] = key_4.Text;
            syncingVIEW[38] = key_5.Text;
            syncingVIEW[39] = key_6.Text;
            syncingVIEW[40] = key_7.Text;
            syncingVIEW[41] = key_8.Text;
            syncingVIEW[42] = key_9.Text;
            syncingVIEW[43] = key_0.Text;
            syncingVIEW[44] = minus.Text;
            syncingVIEW[45] = equal.Text;
            syncingVIEW[46] = TAB.Text;
            syncingVIEW[47] = CAPSLOCK.Text;
            syncingVIEW[48] = won.Text;
            syncingVIEW[49] = ENT.Text;
            syncingVIEW[50] = SPACE.Text;
            syncingVIEW[51] = BACKSPACE.Text;
            syncingVIEW[52] = F1.Text;
            syncingVIEW[53] = F2.Text;
            syncingVIEW[54] = F3.Text;
            syncingVIEW[55] = F4.Text;
            syncingVIEW[56] = F5.Text;
            syncingVIEW[57] = F6.Text;
            syncingVIEW[58] = F7.Text;
            syncingVIEW[59] = F8.Text;
            syncingVIEW[60] = F9.Text;
            syncingVIEW[61] = F10.Text;
            syncingVIEW[62] = F11.Text;
            syncingVIEW[63] = F12.Text;
            syncingVIEW[64] = INS.Text;
            syncingVIEW[65] = HOME.Text;
            syncingVIEW[66] = PGUP.Text;
            syncingVIEW[67] = DEL.Text;
            syncingVIEW[68] = END.Text;
            syncingVIEW[69] = PGDN.Text;
            syncingVIEW[70] = KP_DIVIDE.Text;
            syncingVIEW[71] = KP_MULTIPLY.Text;
            syncingVIEW[72] = KP_MINUS.Text;
            syncingVIEW[73] = KP_PLUS.Text;
            syncingVIEW[74] = KP_ENTER.Text;
            syncingVIEW[75] = KP_DEL.Text;
            syncingVIEW[76] = KP_0.Text;
            syncingVIEW[77] = KP_1.Text;
            syncingVIEW[78] = KP_2.Text;
            syncingVIEW[79] = KP_3.Text;
            syncingVIEW[80] = KP_4.Text;
            syncingVIEW[81] = KP_5.Text;
            syncingVIEW[82] = KP_6.Text;
            syncingVIEW[83] = KP_7.Text;
            syncingVIEW[84] = KP_8.Text;
            syncingVIEW[85] = KP_9.Text;
            syncingVIEW[86] = UPARROW.Text;
            syncingVIEW[87] = LEFTARROW.Text;
            syncingVIEW[88] = DOWNARROW.Text;
            syncingVIEW[89] = RIGHTARROW.Text;
            syncingVIEW[90] = ESC.Text;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string line;
            givestatus("Preparing to save... (1/2)");
            print("Preparing to save... (1/2)");
            FileStream file = new FileStream(autoexec, FileMode.Open, FileAccess.ReadWrite);
            //FileStream nobinding = new FileStream(u)
            StreamReader reader = new StreamReader(file);
            savetosync();

            if (File.Exists(TEMPautoexec))
            {
                File.Delete(TEMPautoexec);
                print("Deleted TEMP file.");
            }
            StreamWriter writer = new StreamWriter(TEMPautoexec);
            writer.AutoFlush = true;

            givestatus("Saving... (1/2)");
            print("Saving... (1/2)");
            while ((line = reader.ReadLine()) != null)
            {

                if (line.StartsWith("bind"))
                 {
                    string[] divided = line.Split('"'); // split the line with ", results in 1=key, 3=function

                    for (int v = 0; v < 89; v++)
                    {
                        if (divided[3] == syncingCMD[v])
                        {
                            writer.WriteLine("bind \"" + syncingKEY[v] + "\" \"" + syncingCMD[v] + "\""); print("Writing " + syncingKEY[v] + "..");
                            syncing[v] = 1;//chg this loc and may be no collision to autoexec.cfg
                            break;
                        }
                    }

                    for (int v = 0; v < 91; v++)
                    {
                        if (divided[1] == syncingKEY[v] && syncing[v] == 0)
                        {
                            if (syncingCMD[v] != syncingVIEW[v])
                            {
                                writer.WriteLine("bind \"" + syncingKEY[v] + "\" \"" + syncingCMD[v] + "\""); print("Writing " + syncingKEY[v] + "..");
                            }
                            else
                            {
                                writer.WriteLine();
                            }

                            syncing[v] = 1;
                            break;
                        }
                    }
                }
                else
                {
                    writer.WriteLine(line);
                }
            }

            givestatus("Preparing to save... (2/2)");
            print("Preparing to save... (2/2)");
            writer.Close();
            file.Close();
            reader.Close();

            FileStream file2 = new FileStream(config, FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader2 = new StreamReader(file2);

            if (File.Exists(TEMPconfig))
            {
                File.Delete(TEMPconfig);
                print("Deleted TEMP file.");
            }
            StreamWriter writer2 = new StreamWriter(TEMPconfig);
            writer2.AutoFlush = true;

            givestatus("Saving... (2/2)");
            print("Saving... (2/2)");

            while ((line = reader2.ReadLine()) != null)
            {
                if (line.StartsWith("bind"))
                {
                    string[] divided = line.Split('"'); // split the line with ", results in 1=key, 3=function

                    for (int v = 0; v < 91; v++)
                    {
                        if (divided[1] == syncingKEY[v])
                        {
                            if (syncingCMD[v] != syncingVIEW[v])
                            {
                                writer2.WriteLine("bind \"" + syncingKEY[v] + "\" \"" + syncingCMD[v] + "\""); print("Writing " + syncingKEY[v] + "..");
                            }
                            else
                            {
                                writer2.WriteLine();
                            }

                            syncing[v] = 1;
                            break;
                        }
                    }
                }
                else
                {
                    writer2.WriteLine(line);
                }
            }

            for (int v = 0; v < 91; v++)
            {
                if (syncing[v] == 0 && syncingCMD[v] != syncingVIEW[v])
                {
                    writer2.WriteLine("bind \"" + syncingKEY[v] + "\" \"" + syncingCMD[v] + "\""); print("Generating " + syncingKEY[v] + "..");
                }
            }

            writer2.Close();
            file2.Close();
            reader2.Close();

            File.Replace(TEMPautoexec, autoexec, null);
            File.Replace(TEMPconfig, config, null);

            print("Binding Done.");

            print("Checking for unbinded fucntions..");
            FileStream cfg = new FileStream(config, FileMode.Open, FileAccess.ReadWrite);//**FINAL CHG
            FileStream auto = new FileStream(autoexec, FileMode.Open, FileAccess.ReadWrite);
            FileStream setting = new FileStream(settings, FileMode.Open, FileAccess.ReadWrite);

            StreamReader readcfg = new StreamReader(cfg);
            StreamReader readauto = new StreamReader(auto);
            StreamWriter writeset = new StreamWriter(setting);
            writeset.AutoFlush = true;
            writeset.WriteLine("Bermuda's Dota 2 Universal Key Bind Settings" + Environment.NewLine);
            // Get the function from listbox > check with config.cfg
            for (int x = 0; x < listBox1.Items.Count; x++)
            {
                if (listBox1.Items[x].ToString() != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.Items[x].ToString() != "■■■■■■■ User Defined ■■■■■■■" && listBox1.Items[x].ToString() != "■■■■■■■■ Unbinded ■■■■■■■■")
                {
                    bool usedcfg = false;
                    bool usedauto = false;

                    while ((line = readcfg.ReadLine()) != null)
                    {
                        if (line.StartsWith("bind"))
                        {
                            string[] divided = line.Split('"');
                            if (divided[3] == listBox1.Items[x].ToString())
                            {
                                usedcfg = true;
                            }
                        }
                    }

                    while ((line = readauto.ReadLine()) != null)
                    {
                        if (line.StartsWith("bind"))
                        {
                            string[] divided = line.Split('"');
                            if (divided[3] == listBox1.Items[x].ToString())
                            {
                                usedauto = true;
                            }
                        }
                    }

                    if (usedcfg == false && usedauto == false)
                    {
                        writeset.WriteLine("unused :" + listBox1.Items[x].ToString());
                    }
                }
            }
            //}
            save.Enabled = false;
            checkBox1.Enabled = false;
            changedir.Enabled = false;
            print("------");
            print("Done!");
            print("------");
            givestatus("Save complete!");
            if (checkBox1.Checked == true)
            {
                print("Restarting application in 3..");
                givestatus("Restarting application in 3..");
                System.Threading.Thread.Sleep(1000);
                print("Restarting application in 2..");
                givestatus("Restarting application in 2..");
                System.Threading.Thread.Sleep(1000);
                print("Restarting application in 1..");
                givestatus("Restarting application in 1..");
                System.Threading.Thread.Sleep(1000);
                givestatus("Restarting.");
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
                //Application.Restart();
            }
            else
            {
                print("You may now close the application. :)");
            }
        }

        private void MainBinding_Load(object sender, EventArgs e)
        {
            synckeyview();
            autoexec = savedir + "/dota/cfg/autoexec.cfg";
            TEMPautoexec = savedir + "/dota/cfg/TEMPautoexec.txt";
            config = savedir + "/dota/cfg/config.cfg";
            TEMPconfig = savedir + "/dota/cfg/TEMPconfig.txt";
            settings = savedir + "/dota/cfg/dota2universalbind.txt";

            if (File.Exists(config))
            {
                List<string> _bindkeys = new List<string>();
                string line;
                _bindkeys.Add("■■■■■■■ User Defined ■■■■■■■");//User defined first.
                if (File.Exists(autoexec))
                {
                    givestatus("Reading Autoexec.cfg..");
                    System.IO.StreamReader file = new System.IO.StreamReader(autoexec);
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.StartsWith("bind"))
                        {
                            string[] divided = line.Split('"'); // split the line with ", results in 1=key, 3=function

                            if (_bindkeys.Contains(divided[3]) == false)
                            {
                                _bindkeys.Add(divided[3].ToString()); // add function
                            }

                            readkey(divided[1], divided[3]);
                        }
                    }
                    file.Close();
                }
                _bindkeys.Add("■■■■■■■■■ Default ■■■■■■■■■");
                status.Text = "Reading config.cfg";
                System.IO.StreamReader file2 = new System.IO.StreamReader(config);
                while ((line = file2.ReadLine()) != null)
                {

                    if (line.StartsWith("bind"))
                    {
                        string[] divided = line.Split('"'); // split the line with ", results in 1=key, 3=function

                        readkey(divided[1], divided[3]);

                        if (_bindkeys.Contains(divided[3]) == false)
                        {
                            _bindkeys.Add(divided[3].ToString()); // add function
                        }
                    }
                }
                file2.Close();

                //if (File.Exists(settings))
                //{
                //firstlaunch = false;

                if (!File.Exists(settings))
                {
                    File.WriteAllText(settings, "Bermuda's Dota 2 Global Bind Settings!" + Environment.NewLine + "Directory " + savedir + defaultset);//TODO: add all commands
                }

                System.IO.StreamReader file3 = new System.IO.StreamReader(settings);
                _bindkeys.Add("■■■■■■■■ Unbinded ■■■■■■■■");
                while ((line = file3.ReadLine()) != null)
                {
                    if (line.StartsWith("unused"))
                    {
                        string[] divided = line.Split(':');
                        //_bindkeys.Add(divided[1]);
                        if (_bindkeys.Contains(divided[1]) == false)
                        {
                            _bindkeys.Add(divided[1].ToString()); // add function
                        }
                    }
                }
                file3.Close();

                listBox1.DataSource = _bindkeys; // dump all the functions
                givestatus("Completed reading files.");
            }
            else if (!File.Exists(config))
            {
                MessageBox.Show("Invaoid Dota 2 directory. Please re-locate 'dota 2 beta' folder.");
                File.Delete(fileName);
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
                //Application.Restart();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://imnotbermuda.com");
        }



        //Each buttons nogada.

        private void key_q_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_q.Text = "Q";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_q.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_q.Text != "Q")
                {
                    movecommand = key_q.Text;
                    key_q.Text = "Q";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_q.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_w_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_w.Text = "W";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_w.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_w.Text != "W")
                {
                    movecommand = key_w.Text;
                    key_w.Text = "W";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_w.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_e_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_e.Text = "E";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_e.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_e.Text != "E")
                {
                    movecommand = key_e.Text;
                    key_e.Text = "E";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_e.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_r_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_r.Text = "R";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_r.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_r.Text != "R")
                {
                    movecommand = key_r.Text;
                    key_r.Text = "R";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_r.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_t_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_t.Text = "T";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_t.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_t.Text != "T")
                {
                    movecommand = key_t.Text;
                    key_t.Text = "T";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_t.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_y_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_y.Text = "Y";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_y.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_y.Text != "Y")
                {
                    movecommand = key_y.Text;
                    key_y.Text = "Y";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_y.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_u_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_u.Text = "U";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_u.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_u.Text != "U")
                {
                    movecommand = key_u.Text;
                    key_u.Text = "U";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_u.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_i_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_i.Text = "I";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_i.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_i.Text != "I")
                {
                    movecommand = key_i.Text;
                    key_i.Text = "I";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_i.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_o_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_o.Text = "O";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_o.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_o.Text != "O")
                {
                    movecommand = key_o.Text;
                    key_o.Text = "O";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_o.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_p_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_p.Text = "P";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_p.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_p.Text != "P")
                {
                    movecommand = key_p.Text;
                    key_p.Text = "P";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_p.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_a_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_a.Text = "A";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_a.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_a.Text != "A")
                {
                    movecommand = key_a.Text;
                    key_a.Text = "A";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_a.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_s_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_s.Text = "S";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_s.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_s.Text != "S")
                {
                    movecommand = key_s.Text;
                    key_s.Text = "S";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_s.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_d_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_d.Text = "D";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_d.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_d.Text != "D")
                {
                    movecommand = key_d.Text;
                    key_d.Text = "D";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_d.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_f_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_f.Text = "F";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_f.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_f.Text != "F")
                {
                    movecommand = key_f.Text;
                    key_f.Text = "F";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_f.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_g_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_g.Text = "G";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_g.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_g.Text != "G")
                {
                    movecommand = key_g.Text;
                    key_g.Text = "G";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_g.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_h_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_h.Text = "H";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_h.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_h.Text != "H")
                {
                    movecommand = key_h.Text;
                    key_h.Text = "H";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_h.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_j_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_j.Text = "J";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_j.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_j.Text != "J")
                {
                    movecommand = key_j.Text;
                    key_j.Text = "J";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_j.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_k_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_k.Text = "K";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_k.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_k.Text != "K")
                {
                    movecommand = key_k.Text;
                    key_k.Text = "K";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_k.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_l_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_l.Text = "L";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_l.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_l.Text != "L")
                {
                    movecommand = key_l.Text;
                    key_l.Text = "L";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_l.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_z_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_z.Text = "Z";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_z.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_z.Text != "Z")
                {
                    movecommand = key_z.Text;
                    key_z.Text = "Z";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_z.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_x_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_x.Text = "X";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_x.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_x.Text != "X")
                {
                    movecommand = key_x.Text;
                    key_x.Text = "X";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_x.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_c_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_c.Text = "C";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_c.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_c.Text != "C")
                {
                    movecommand = key_c.Text;
                    key_c.Text = "C";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_c.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_v_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_v.Text = "V";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_v.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_v.Text != "V")
                {
                    movecommand = key_v.Text;
                    key_v.Text = "V";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_v.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_b_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_b.Text = "B";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_b.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_b.Text != "B")
                {
                    movecommand = key_b.Text;
                    key_b.Text = "B";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_b.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_n_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_n.Text = "N";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_n.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_n.Text != "N")
                {
                    movecommand = key_n.Text;
                    key_n.Text = "N";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_n.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_m_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_m.Text = "M";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_m.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_m.Text != "M")
                {
                    movecommand = key_m.Text;
                    key_m.Text = "M";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_m.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_1.Text = "1";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_1.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_1.Text != "1")
                {
                    movecommand = key_1.Text;
                    key_1.Text = "1";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_1.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_2.Text = "2";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_2.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_2.Text != "2")
                {
                    movecommand = key_2.Text;
                    key_2.Text = "2";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_2.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_3.Text = "3";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_3.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_3.Text != "3")
                {
                    movecommand = key_3.Text;
                    key_3.Text = "3";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_3.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_4.Text = "4";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_4.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_4.Text != "4")
                {
                    movecommand = key_4.Text;
                    key_4.Text = "4";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_4.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_5.Text = "5";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_5.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_5.Text != "5")
                {
                    movecommand = key_5.Text;
                    key_5.Text = "5";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_5.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_6.Text = "6";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_6.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_6.Text != "6")
                {
                    movecommand = key_6.Text;
                    key_6.Text = "6";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_6.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_7_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_7.Text = "7";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_7.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_7.Text != "7")
                {
                    movecommand = key_7.Text;
                    key_7.Text = "7";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_7.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_8_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_8.Text = "8";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_8.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_8.Text != "8")
                {
                    movecommand = key_8.Text;
                    key_8.Text = "8";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_8.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_9_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_9.Text = "9";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_9.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_9.Text != "9")
                {
                    movecommand = key_9.Text;
                    key_9.Text = "9";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_9.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void key_0_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                key_0.Text = "0";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    key_0.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && key_0.Text != "0")
                {
                    movecommand = key_0.Text;
                    key_0.Text = "0";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    key_0.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void minus_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                minus.Text = "-";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    minus.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && minus.Text != "-")
                {
                    movecommand = minus.Text;
                    minus.Text = "-";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    minus.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void equal_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                equal.Text = "=";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    equal.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && equal.Text != "=")
                {
                    movecommand = equal.Text;
                    equal.Text = "=";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    equal.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void BACKSPACE_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                BACKSPACE.Text = "<-";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    BACKSPACE.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && equal.Text != "<-")
                {
                    movecommand = BACKSPACE.Text;
                    BACKSPACE.Text = "<-";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    BACKSPACE.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void won_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                won.Text = "\\";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    won.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && won.Text != "\\")
                {
                    movecommand = won.Text;
                    won.Text = "\\";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    won.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void ENT_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                ENT.Text = "Enter";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    ENT.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && ENT.Text != "Enter")
                {
                    movecommand = ENT.Text;
                    ENT.Text = "Enter";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    ENT.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void SPACE_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                SPACE.Text = "Space";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    SPACE.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && SPACE.Text != "Space")
                {
                    movecommand = SPACE.Text;
                    SPACE.Text = "Space";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    SPACE.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void CAPSLOCK_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                CAPSLOCK.Text = "Caps Lock";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    CAPSLOCK.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && CAPSLOCK.Text != "Caps Lock")
                {
                    movecommand = CAPSLOCK.Text;
                    CAPSLOCK.Text = "Caps Lock";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    CAPSLOCK.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void TAB_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                TAB.Text = "Tab";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    TAB.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && TAB.Text != "Tab")
                {
                    movecommand = TAB.Text;
                    TAB.Text = "Tab";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    TAB.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void shop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                shop.Text = "`";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    shop.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && shop.Text != "`")
                {
                    movecommand = shop.Text;
                    shop.Text = "`";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    shop.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void sqbrktopen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                sqbrktopen.Text = "[";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    sqbrktopen.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && sqbrktopen.Text != "[")
                {
                    movecommand = sqbrktopen.Text;
                    sqbrktopen.Text = "[";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    sqbrktopen.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void sqbrktclose_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                sqbrktclose.Text = "]";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    sqbrktclose.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && sqbrktclose.Text != "]")
                {
                    movecommand = sqbrktclose.Text;
                    sqbrktclose.Text = "]";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    sqbrktclose.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void colon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                colon.Text = ";";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    colon.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && colon.Text != ";")
                {
                    movecommand = colon.Text;
                    colon.Text = ";";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    colon.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void quote_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                quote.Text = "'";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    quote.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && quote.Text != "'")
                {
                    movecommand = quote.Text;
                    quote.Text = "'";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    quote.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void comma_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                comma.Text = ",";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    comma.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && comma.Text != ",")
                {
                    movecommand = comma.Text;
                    comma.Text = ",";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    comma.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void stop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                stop.Text = ".";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    stop.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && stop.Text != ".")
                {
                    movecommand = stop.Text;
                    stop.Text = ".";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    stop.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void slash_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                slash.Text = "/";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    slash.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && slash.Text != "/")
                {
                    movecommand = slash.Text;
                    slash.Text = "/";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    slash.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F1.Text = "F1";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F1.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F1.Text != "F1")
                {
                    movecommand = F1.Text;
                    F1.Text = "F1";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F1.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F2.Text = "F2";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F2.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F2.Text != "F2")
                {
                    movecommand = F2.Text;
                    F2.Text = "F2";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F2.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F3.Text = "F3";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F3.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F3.Text != "F3")
                {
                    movecommand = F3.Text;
                    F3.Text = "F3";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F3.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F4.Text = "F4";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F4.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F4.Text != "F4")
                {
                    movecommand = F4.Text;
                    F4.Text = "F4";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F4.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F5.Text = "F5";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F5.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F5.Text != "F5")
                {
                    movecommand = F5.Text;
                    F5.Text = "F5";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F5.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F6.Text = "F6";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F6.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F6.Text != "F6")
                {
                    movecommand = F6.Text;
                    F6.Text = "F6";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F6.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F7_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F7.Text = "F7";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F7.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F7.Text != "F7")
                {
                    movecommand = F7.Text;
                    F7.Text = "F7";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F7.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F8_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F8.Text = "F8";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F8.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F8.Text != "F8")
                {
                    movecommand = F8.Text;
                    F8.Text = "F8";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F8.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F9_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F9.Text = "F9";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F9.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F9.Text != "F9")
                {
                    movecommand = F9.Text;
                    F9.Text = "F9";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F9.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F10_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F10.Text = "F10";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F10.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F10.Text != "F10")
                {
                    movecommand = F10.Text;
                    F10.Text = "F10";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F10.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F11_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F11.Text = "F11";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F11.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F11.Text != "F11")
                {
                    movecommand = F11.Text;
                    F11.Text = "F11";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F11.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void F12_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                F12.Text = "F12";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    F12.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && F12.Text != "F12")
                {
                    movecommand = F12.Text;
                    F12.Text = "F12";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    F12.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void END_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                END.Text = "End";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    END.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && END.Text != "End")
                {
                    movecommand = END.Text;
                    END.Text = "End";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    END.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void HOME_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                HOME.Text = "Home";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    HOME.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && HOME.Text != "Home")
                {
                    movecommand = HOME.Text;
                    HOME.Text = "Home";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    HOME.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void DEL_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                DEL.Text = "Del";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    DEL.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && END.Text != "Del")
                {
                    movecommand = DEL.Text;
                    DEL.Text = "Del";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    DEL.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void INS_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                INS.Text = "Ins";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    INS.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && INS.Text != "Ins")
                {
                    movecommand = INS.Text;
                    INS.Text = "Ins";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    INS.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void PGUP_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                PGUP.Text = "Page Up";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    PGUP.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && PGUP.Text != "Page Up")
                {
                    movecommand = PGUP.Text;
                    PGUP.Text = "Page Up";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    PGUP.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void PGDN_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                PGDN.Text = "Page Down";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    PGDN.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && PGDN.Text != "Page Down")
                {
                    movecommand = PGDN.Text;
                    PGDN.Text = "Page Down";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    PGDN.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_1.Text = "1";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_1.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_1.Text != "1")
                {
                    movecommand = KP_1.Text;
                    KP_1.Text = "1";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_1.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_2.Text = "2";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_2.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_2.Text != "2")
                {
                    movecommand = KP_2.Text;
                    KP_2.Text = "2";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_2.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_3.Text = "3";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_3.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_3.Text != "3")
                {
                    movecommand = KP_3.Text;
                    KP_3.Text = "3";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_3.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_4.Text = "4";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_4.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_4.Text != "4")
                {
                    movecommand = KP_4.Text;
                    KP_4.Text = "4";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_4.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_5.Text = "5";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_5.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_5.Text != "5")
                {
                    movecommand = KP_5.Text;
                    KP_5.Text = "5";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_5.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_6.Text = "6";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_6.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_6.Text != "6")
                {
                    movecommand = KP_6.Text;
                    KP_6.Text = "6";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_6.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_7_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_7.Text = "7";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_7.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_7.Text != "7")
                {
                    movecommand = KP_7.Text;
                    KP_7.Text = "7";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_7.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_8_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_8.Text = "8";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_8.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_8.Text != "8")
                {
                    movecommand = KP_8.Text;
                    KP_8.Text = "8";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_8.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_9_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_9.Text = "9";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_9.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_9.Text != "9")
                {
                    movecommand = KP_9.Text;
                    KP_9.Text = "9";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_9.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_0_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_0.Text = "0";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_0.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_0.Text != "0")
                {
                    movecommand = KP_0.Text;
                    KP_0.Text = "0";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_0.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_DIVIDE_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_DIVIDE.Text = "/";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_DIVIDE.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_DIVIDE.Text != "/")
                {
                    movecommand = KP_DIVIDE.Text;
                    KP_DIVIDE.Text = "/";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_DIVIDE.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_MULTIPLY_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_MULTIPLY.Text = "*";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_MULTIPLY.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_MULTIPLY.Text != "*")
                {
                    movecommand = KP_MULTIPLY.Text;
                    KP_MULTIPLY.Text = "*";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_MULTIPLY.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_MINUS_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_MINUS.Text = "-";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_MINUS.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_MINUS.Text != "-")
                {
                    movecommand = KP_MINUS.Text;
                    KP_MINUS.Text = "-";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_MINUS.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_PLUS_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_PLUS.Text = "+";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_PLUS.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_PLUS.Text != "+")
                {
                    movecommand = KP_PLUS.Text;
                    KP_PLUS.Text = "+";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_PLUS.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_ENTER_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_ENTER.Text = "Enter";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_ENTER.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_ENTER.Text != "Enter")
                {
                    movecommand = KP_ENTER.Text;
                    KP_ENTER.Text = "Enter";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_ENTER.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void KP_DEL_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                KP_DEL.Text = ".";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    KP_DEL.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && KP_DEL.Text != ".")
                {
                    movecommand = KP_DEL.Text;
                    KP_DEL.Text = ".";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    KP_DEL.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void DOWNARROW_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                DOWNARROW.Text = "↓";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    DOWNARROW.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && DOWNARROW.Text != "↓")
                {
                    movecommand = DOWNARROW.Text;
                    DOWNARROW.Text = "↓";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    DOWNARROW.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void UPARROW_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                UPARROW.Text = "↑";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    UPARROW.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && UPARROW.Text != "↑")
                {
                    movecommand = UPARROW.Text;
                    UPARROW.Text = "↑";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    UPARROW.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void LEFTARROW_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                LEFTARROW.Text = "←";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    LEFTARROW.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && LEFTARROW.Text != "←")
                {
                    movecommand = LEFTARROW.Text;
                    LEFTARROW.Text = "←";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    LEFTARROW.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void RIGHTARROW_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                RIGHTARROW.Text = "→";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    RIGHTARROW.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && RIGHTARROW.Text != "→")
                {
                    movecommand = RIGHTARROW.Text;
                    RIGHTARROW.Text = "→";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    RIGHTARROW.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void ESC_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                ESC.Text = "Esc";
                status.Text = "Keybinding deleted.";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■■ Default ■■■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■ User Defined ■■■■■■■" && listBox1.GetItemText(listBox1.SelectedItem) != "■■■■■■■■ Unbinded ■■■■■■■■" )
                {
                    ESC.Text = listBox1.GetItemText(listBox1.SelectedItem);
                    status.Text = "Key binded.";
                }
            }
            else
            {
                if (movekey == false && ESC.Text != "Esc")
                {
                    movecommand = ESC.Text;
                    ESC.Text = "Esc";
                    status.Text = movecommand;
                    moving.Text = movecommand;
                    movekey = true;
                }
                else if (movekey == true)
                {
                    ESC.Text = movecommand;
                    status.Text = "Keybinding Moved.";
                    moving.Text = " ";
                    movekey = false;
                }
            }
        }

        private void changedir_Click(object sender, EventArgs e)
        {
            File.Delete(fileName);
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
            //Application.Restart();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://imnotbermuda.com/2014/11/22/dota-2-universal-keybind/");
        }

    }
}
