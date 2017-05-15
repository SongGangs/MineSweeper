using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        private int m_btnCount = 81;
        private Dictionary<int, ButtonClass> ButtonInformation;
        private List<int> MineList; 

        public MainForm()
        {
            InitializeComponent();
            InitalForm();
            this.panel_btn.Enabled = false;//开始时  不能直接使用
        }

        private void InitalForm()
        {
            this.panel_btn.Enabled = true;
            this.panel_btn.Controls.Clear();
            ChangeControlSizeByCount();
            InitialDictionary();
            FillButtonInForm();
        }

        /// <summary>
        /// 初始化字典  并付给其初始值
        /// </summary>
        private void InitialDictionary()
        {
            MineList = new List<int>();
            ButtonInformation = new Dictionary<int, ButtonClass>();
            for (int i = 0; i < m_btnCount; i++)
            {
                ButtonInformation.Add(i, new ButtonClass(2, i));
            }
        }

        /// <summary>
        /// 生成button控件
        /// </summary>
        /// <param name="i">计数</param>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        /// <returns></returns>
        private Button DesignButtonControl(int i, int x, int y)
        {
            Button button = new Button();
            button.Location = new System.Drawing.Point(x, y);
            button.Name = "button" + i;
            button.Size = new System.Drawing.Size(25, 25);
            button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            // button.UseVisualStyleBackColor = true;
            button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            return button;
        }

        /// <summary>
        /// 填充窗体
        /// </summary>
        private void FillButtonInForm()
        {
            if (m_btnCount <= 0)
                return;
            Panel panel = this.panel_btn;
            int line_num = Convert.ToInt32(Math.Sqrt(m_btnCount));
            for (int i = 0; i < line_num; i++)
            {
                for (int j = 0; j < line_num; j++)
                {
                    Button button = DesignButtonControl(i * line_num+j, 30 * i, j * 30);
                    panel.Controls.Add(button);
                }
            }
            ProduceRandomMine();
            CalculateButtonType();
            FillButtonText();
        }

        /// <summary>
        /// 根据选择的难度级别自动改变窗体大小
        /// </summary>
        private void ChangeControlSizeByCount()
        {
            int line_num = Convert.ToInt32(Math.Sqrt(m_btnCount));
            this.ClientSize = new Size(line_num*30 + 10, line_num*30 + this.panel_contain.Top + 5);
        }

        /// <summary>
        /// 生成随机雷
        /// </summary>
        private void ProduceRandomMine()
        {
            int mineNums = 0;
            switch (m_btnCount)
            {
                case 81:
                    mineNums = 10;
                    this.label_MineNums.Text = "010";
                    break;
                case 225:
                    mineNums = 40;
                    this.label_MineNums.Text = "040";
                    break;
                case 400:
                    mineNums = 140;
                    this.label_MineNums.Text = "140";
                    break;
            }
            for (int i = 0; i < mineNums; i++)
            {
                Random random = new Random();
                int k = random.Next(0, m_btnCount);
                if (ButtonInformation[k].ButtonType == 0)
                    i--;
                else
                {
                    ButtonInformation[k] = new ButtonClass(0, k);
                    MineList.Add(k); 
                }
                    
            }
        }

        /// <summary>
        /// 填充信息到button
        /// </summary>
        private void FillButtonText()
        {
            for (int i = 0; i < m_btnCount; i++)
            {
                try
                {
                    Button button = this.panel_btn.Controls[i] as Button;
                    //  button.Text = ButtonInformation[i].ButtonTag;
                    button.Tag = ButtonInformation[i].ButtonTag;
                }
                catch (Exception)
                {
                }

            }
        }

        private void CalculateButtonType()
        {
            for (int i = 0; i < m_btnCount; i++)
            {
                if (ButtonInformation[i].ButtonType != 0)
                {
                    int tag = CalculateButtonTag(i);
                    if (tag != 0)
                    {
                        ButtonClass buttonClass = new ButtonClass(1, i);
                        buttonClass.SurroundMineNums = tag;
                        ButtonInformation[i] = buttonClass;
                    }
                }
            }
        }

        /// <summary>
        /// 根据当前位置计算 它的标签
        /// 当前位置不可能传入地雷的位置
        /// </summary>
        /// <param name="k">当前位置</param>
        /// <returns></returns>
        private int CalculateButtonTag(int k)
        {
            int result = 0;
            int line_count = Convert.ToInt32(Math.Sqrt(m_btnCount)); //获取每一行的button个数
            int position = k%line_count; //获取这个button在这一行的那个位置
            int line = k/line_count; //获取这个button在这一行的那个位置

            for (int i = line - 1; i < line + 2; i++) //循环当前行的上下两行+本行
            {
                if (i == -1 || i == line_count) //如果当前行不存在 
                    continue;
                for (int j = position - 1; j < position + 2; j++)
                {
                    if (j == -1 || j == line_count) //如果当前列不存在 
                        continue;
                    if (ButtonInformation[line_count*i + j].ButtonType == 0)
                        result++;
                }
            }
            return result;
        }

        /// <summary>
        /// 当点击空白按钮时 周边随机翻出一些无雷按钮
        /// </summary>
        /// <param name="k"></param>
        /// <param name="nums"></param>
        private void ShowClickButtonArounds(int k,int nums)
        {
            int result = 0;
            int line_count = Convert.ToInt32(Math.Sqrt(m_btnCount)); //获取每一行的button个数
            int position = k % line_count; //获取这个button在这一行的那个位置
            int line = k / line_count; //获取这个button在这一行的那个位置

            for (int i = line - 2; i < line + 3; i++) //循环当前行的上下两行+本行
            {
                if (i < 0 || i > line_count) //如果当前行不存在 
                    continue;
                for (int j = position - 2; j < position + 3; j++)
                {
                    if (j < 0 || j > line_count) //如果当前列不存在 
                        continue;
                    if (nums <= 0)
                    return;
                    if (ButtonInformation[line_count * i + j].ButtonType != 0)
                        {
                            Button button = this.panel_btn.Controls[line_count * i + j] as Button;
                            button.Text = button.Tag.ToString();
                            button.BackColor = System.Drawing.Color.White;
                            button.Enabled = false;
                            nums--;
                        }
                    
                }
            }
        }

        /// <summary>
        /// 按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (e.Button == MouseButtons.Left) //左键
            {
                if (button.BackgroundImage != null)
                return;
                button.Text = button.Tag.ToString();
                button.BackColor = System.Drawing.Color.White;
                button.Enabled = false;
                if (button.Text.Contains('*'))
                {
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = Color.Crimson;
                    MessageBox.Show("对不起，游戏结束");
                    timer1.Stop();
                    ShowAllMineButton();
                    panel_btn.Enabled = false;
                    try
                    {
                        string filepath = System.Windows.Forms.Application.StartupPath;
                        filepath = filepath.Substring(0, filepath.LastIndexOf("MineSweeper") + 12) +
                                   "Resources\\cry.jpg";
                        this.button_control.BackgroundImage = Image.FromFile(filepath);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("图片不存在");
                    }
                }
                else if (button.Text == String.Empty)
                {
                    Random random = new Random();
                    int n = 3;
                    switch (m_btnCount)
                    {
                        case 81:
                            n = random.Next(3, 10);
                            break;
                        case 225:
                            n = random.Next(4, 20);
                            break;
                        case 400:
                            n = random.Next(4, 30);
                            break;
                    }
                    ShowClickButtonArounds(Int32.Parse(button.Name.Replace("button", String.Empty)), n);
                }

            }
            else if (e.Button == MouseButtons.Right) //右键
            {
                if ( button.BackgroundImage!=null)
                {
                    button.BackgroundImage = null;
                    return;
                }
                try
                {
                    string filepath = System.Windows.Forms.Application.StartupPath;
                    filepath = filepath.Substring(0, filepath.LastIndexOf("MineSweeper") + 12) + "Resources\\pole.jpg";
                    button.BackgroundImage = Image.FromFile(filepath);
                }
                catch (Exception)
                {
                    MessageBox.Show("图片不存在");
                }
            }
        }

        /// <summary>
        /// 展示所有地雷信息
        /// </summary>
        private void ShowAllMineButton()
        {
            foreach (int k in MineList)
            {
                Button button = this.panel_btn.Controls[k] as Button;
                button.Text = button.Tag.ToString();
            }
        }
        private void 初级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_btnCount = 9*9;
            InitalForm();
            ChangeFormPosition();

        }

        private void 中级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_btnCount = 15*15;
            InitalForm();
            ChangeFormPosition();

        }

        private void 高级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_btnCount = 20*20;
            InitalForm();
            ChangeFormPosition();
        }

        private void ChangeFormPosition()
        {
            this.Location = new Point(
                Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Width * 0.5 - this.Size.Width * 0.5), //屏幕工作区域减去窗体宽度
                Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Height * 0.5 - this.Size.Height * 0.5)); //屏幕工作区域减去窗体高度
        }

        private void button_control_Click(object sender, EventArgs e)
        {
            InitalForm();
            try
            {
                string filepath = System.Windows.Forms.Application.StartupPath;
                filepath = filepath.Substring(0, filepath.LastIndexOf("MineSweeper") + 12) + "Resources\\smile.jpg";
                this.button_control.BackgroundImage = Image.FromFile(filepath);
                this.label_Time.Text = "000";
                timer1.Interval = 1000;
                timer1.Enabled = true;
                timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("图片不存在");
            }
        }

    
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label_Time.Text = (int.Parse(this.label_Time.Text) + 1).ToString("D3");
        }


    }

}
