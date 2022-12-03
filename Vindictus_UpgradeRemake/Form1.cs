using System;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace Vindictus_UpgradeRemake
{
    public partial class Form1 : Form
    {
        BigInteger stone = 0, elixir = 0, gold = 0;
        ulong upgrade_count = 0, broken = 0;
        byte level, targetlevel;
        public delegate void MyInvoke(string input);
        public delegate void ResultInvoke();


        public Form1()
        {
            InitializeComponent();
        }


        private void start_button_Click(object sender, EventArgs e)
        {
            targetlevel = Convert.ToByte(TargetLevel_input.Value);
            if (From0_radio.Checked == true)
                level = 0;
            else
                level = Convert.ToByte(LockLevel_input.Value);



            if (level < targetlevel)
            {
                timer_show.Visible = false;
                start_button.Enabled = false;
                reset_button.Enabled = false;
                if (From0_radio.Checked == true)
                {
                    Thread thread = new Thread(compute);
                    thread.Start();
                }
                else
                {
                    Thread locklevel_thread = new Thread(compute_LockLevel);
                    locklevel_thread.Start();
                }
            }
            else
            {
                MessageBox.Show("目前等級需要小於目標等級", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void compute()
        {
            ulong T1 = 0, T2 = 0, T3 = 0, T4 = 0, T11 = 0, T12 = 0, T13 = 0, T14 = 0, T15 = 0, T16 = 0, T17 = 0, T18 = 0, T19 = 0, T20 = 0;
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            DateTime starttimer = DateTime.Now;     //開始計時

            //模擬開始
            while (level != targetlevel)
            {
                upgrade_count++;
                switch (level)
                {
                    case 0:
                    case 1:
                    case 2:
                        {
                            T1++;
                            level++;
                            break;
                        }
                    case 3:
                    case 4:
                        {
                            T2++;
                            if (ran.Next(1, 101) <= 90)
                            {
                                level++;
                            }
                            else
                            {
                                level--;
                            }
                            break;
                        }
                    case 5:
                        {
                            T3++;
                            if (ran.Next(1, 101) <= 80)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                            }
                            break;
                        }
                    case 6:
                        {
                            T3++;
                            if (ran.Next(1, 101) <= 70)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                            }
                            break;
                        }
                    case 7:
                        {
                            T3++;
                            if (ran.Next(1, 101) <= 60)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                            }
                            break;
                        }
                    case 8:
                        {
                            T4++;
                            if (ran.Next(1, 101) <= 55)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 9:
                        {
                            T4++;
                            if (ran.Next(1, 101) <= 50)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 10:
                        {
                            T11++;
                            if (ran.Next(1, 101) <= 45)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 11:
                        {
                            T12++;
                            if (ran.Next(1, 101) <= 40)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 12:
                        {
                            T13++;
                            if (ran.Next(1, 101) <= 20)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 13:
                        {
                            T14++;
                            if (ran.Next(1, 101) <= 16)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 14:
                        {
                            T15++;
                            if (ran.Next(1, 101) <= 15)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 15:
                        {
                            T16++;
                            if (ran.Next(1, 101) <= 14)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 16:
                        {
                            T17++;
                            if (ran.Next(1, 101) <= 13)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 17:
                        {
                            T18++;
                            if (ran.Next(1, 101) <= 10)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 18:
                        {
                            T19++;
                            if (ran.Next(1, 101) <= 8)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }
                    case 19:
                        {
                            T20++;
                            if (ran.Next(1, 101) == 1)
                            {
                                level++;
                            }
                            else
                            {
                                level = 0;
                                broken++;
                            }
                            break;
                        }

                }



            }
            //模擬完成

            DateTime endtimer = DateTime.Now;
            TimeSpan diff = endtimer - starttimer;
            MyInvoke timereturn = new MyInvoke(UpdateTimer);
            if (diff.TotalMilliseconds > 10000)
                this.BeginInvoke(timereturn, new Object[] { "花費時間: " + diff.TotalSeconds.ToString("f2") + " 秒" });
            else
                this.BeginInvoke(timereturn, new Object[] { "花費時間: " + diff.TotalMilliseconds.ToString("f2") + " 毫秒" });
            Tier_1(T1);
            Tier_2(T2);
            Tier_3(T3);
            Tier_4(T4);
            Tier_level11(T11);
            Tier_level12(T12);
            Tier_level13(T13);
            Tier_level14(T14);
            Tier_level15(T15);
            Tier_level16(T16);
            Tier_level17(T17);
            Tier_level18(T18);
            Tier_level19(T19);
            Tier_level20(T20);
            ResultInvoke ControlReturn = new ResultInvoke(UpdateControl_Return);
            this.BeginInvoke(ControlReturn);
        }
        private void compute_LockLevel()
        {
            ulong T1 = 0, T2 = 0, T3 = 0, T4 = 0, T11 = 0, T12 = 0, T13 = 0, T14 = 0, T15 = 0, T16 = 0, T17 = 0, T18 = 0, T19 = 0, T20 = 0;
            byte levellock = level;
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            DateTime starttimer = DateTime.Now;     //開始計時

            //模擬開始
            while (level != targetlevel)
            {
                upgrade_count++;
                switch (level)
                {
                    case 0:
                    case 1:
                    case 2:
                        {
                            T1++;
                            level++;
                            break;
                        }
                    case 3:
                    case 4:
                        {
                            T2++;
                            if (ran.Next(1, 101) <= 90)
                            {
                                level++;
                            }
                            else
                            {
                                level--;
                            }
                            break;
                        }
                    case 5:
                        {
                            T3++;
                            if (ran.Next(1, 101) <= 80)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                            }
                            break;
                        }
                    case 6:
                        {
                            T3++;
                            if (ran.Next(1, 101) <= 70)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                            }
                            break;
                        }
                    case 7:
                        {
                            T3++;
                            if (ran.Next(1, 101) <= 60)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                            }
                            break;
                        }
                    case 8:
                        {
                            T4++;
                            if (ran.Next(1, 101) <= 55)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 9:
                        {
                            T4++;
                            if (ran.Next(1, 101) <= 50)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 10:
                        {
                            T11++;
                            if (ran.Next(1, 101) <= 45)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 11:
                        {
                            T12++;
                            if (ran.Next(1, 101) <= 40)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 12:
                        {
                            T13++;
                            if (ran.Next(1, 101) <= 20)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 13:
                        {
                            T14++;
                            if (ran.Next(1, 101) <= 16)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 14:
                        {
                            T15++;
                            if (ran.Next(1, 101) <= 15)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 15:
                        {
                            T16++;
                            if (ran.Next(1, 101) <= 14)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 16:
                        {
                            T17++;
                            if (ran.Next(1, 101) <= 13)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 17:
                        {
                            T18++;
                            if (ran.Next(1, 101) <= 10)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 18:
                        {
                            T19++;
                            if (ran.Next(1, 101) <= 8)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }
                    case 19:
                        {
                            T20++;
                            if (ran.Next(1, 101) == 1)
                            {
                                level++;
                            }
                            else
                            {
                                level = levellock;
                                broken++;
                            }
                            break;
                        }

                }



            }
            //模擬完成

            DateTime endtimer = DateTime.Now;
            TimeSpan diff = endtimer - starttimer;
            MyInvoke timereturn = new MyInvoke(UpdateTimer);
            if (diff.TotalMilliseconds > 10000)
                this.BeginInvoke(timereturn, new Object[] { "花費時間: " + diff.TotalSeconds.ToString("f2") + " 秒" });
            else
                this.BeginInvoke(timereturn, new Object[] { "花費時間: " + diff.TotalMilliseconds.ToString("f2") + " 毫秒" });
            Tier_1(T1);
            Tier_2(T2);
            Tier_3(T3);
            Tier_4(T4);
            Tier_level11(T11);
            Tier_level12(T12);
            Tier_level13(T13);
            Tier_level14(T14);
            Tier_level15(T15);
            Tier_level16(T16);
            Tier_level17(T17);
            Tier_level18(T18);
            Tier_level19(T19);
            Tier_level20(T20);
            ResultInvoke ControlReturn = new ResultInvoke(UpdateControl_Return);
            this.BeginInvoke(ControlReturn);
        }
        private void Tier_1(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 20000 * counttobig;
            stone = stone + 2 * counttobig;
        }
        private void Tier_2(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 27500 * counttobig;
            stone = stone + 3 * counttobig;
        }
        private void Tier_3(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 35000 * counttobig;
            stone = stone + 4 * counttobig;
            elixir = elixir + 1 * counttobig;
        }
        private void Tier_4(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 42500 * counttobig;
            stone = stone + 5 * counttobig;
            elixir = elixir + 2 * counttobig;
        }
        private void Tier_level11(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 52500 * counttobig;
            stone = stone + 6 * counttobig;
            elixir = elixir + 2 * counttobig;
        }
        private void Tier_level12(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 52500 * counttobig;
            stone = stone + 7 * counttobig;
            elixir = elixir + 3 * counttobig;
        }
        private void Tier_level13(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 52500 * counttobig;
            stone = stone + 8 * counttobig;
            elixir = elixir + 3 * counttobig;
        }
        private void Tier_level14(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 62500 * counttobig;
            stone = stone + 9 * counttobig;
            elixir = elixir + 3 * counttobig;
        }
        private void Tier_level15(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 62500 * counttobig;
            stone = stone + 10 * counttobig;
            elixir = elixir + 4 * counttobig;
        }
        private void Tier_level16(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 72500 * counttobig;
            stone = stone + 11 * counttobig;
            elixir = elixir + 4 * counttobig;
        }
        private void Tier_level17(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 72500 * counttobig;
            stone = stone + 12 * counttobig;
            elixir = elixir + 4 * counttobig;
        }
        private void Tier_level18(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 82500 * counttobig;
            stone = stone + 13 * counttobig;
            elixir = elixir + 4 * counttobig;
        }
        private void Tier_level19(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 82500 * counttobig;
            stone = stone + 14 * counttobig;
            elixir = elixir + 4 * counttobig;
        }
        private void Tier_level20(ulong count)
        {
            BigInteger counttobig = count;
            gold = gold + 92500 * counttobig;
            stone = stone + 15 * counttobig;
            elixir = elixir + 4 * counttobig;
        }
        private void reset_button_Click(object sender, EventArgs e)
        {
            gold = 0;
            stone = 0;
            elixir = 0;
            level = 0;
            level_show.Text = ("+0");
            broken = 0;
            gold_show.Text = gold.ToString();
            stone_show.Text = stone.ToString();
            elixir_show.Text = elixir.ToString();
            broken_show.Text = "0";
            upgrade_count = 0;
            upgrade_count_show.Text = "0";
        }
        public void UpdateTimer(string text)
        {
            timer_show.Text = text;
        }
        public void UpdateControl_Return()
        {
            timer_show.Visible = true;
            gold_show.Text = gold.ToString("#,0");
            stone_show.Text = stone.ToString("#,0");
            elixir_show.Text = elixir.ToString("#,0");
            upgrade_count_show.Text = upgrade_count.ToString("#,0");
            broken_show.Text = broken.ToString("#,0");
            level_show.Text = ("+" + level.ToString());
            start_button.Enabled = true;
            reset_button.Enabled = true;
        }

    }
}
