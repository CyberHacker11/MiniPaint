
namespace MiniPaint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_Figures = new System.Windows.Forms.ComboBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.tbx_Height = new System.Windows.Forms.TextBox();
            this.tbx_Width = new System.Windows.Forms.TextBox();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.btn_ColorSelect = new System.Windows.Forms.Button();
            this.rbtn_Fill = new System.Windows.Forms.RadioButton();
            this.rbtn_Outline = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cbx_Figures
            // 
            this.cbx_Figures.FormattingEnabled = true;
            this.cbx_Figures.Location = new System.Drawing.Point(22, 12);
            this.cbx_Figures.Name = "cbx_Figures";
            this.cbx_Figures.Size = new System.Drawing.Size(121, 21);
            this.cbx_Figures.TabIndex = 0;
            this.cbx_Figures.SelectedIndexChanged += new System.EventHandler(this.cbx_Figures_SelectedIndexChanged);
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Height.Location = new System.Drawing.Point(191, 15);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(49, 16);
            this.lbl_Height.TabIndex = 1;
            this.lbl_Height.Text = "Height";
            // 
            // tbx_Height
            // 
            this.tbx_Height.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_Height.Location = new System.Drawing.Point(246, 12);
            this.tbx_Height.Name = "tbx_Height";
            this.tbx_Height.Size = new System.Drawing.Size(59, 22);
            this.tbx_Height.TabIndex = 2;
            this.tbx_Height.Text = "100";
            // 
            // tbx_Width
            // 
            this.tbx_Width.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_Width.Location = new System.Drawing.Point(417, 12);
            this.tbx_Width.Name = "tbx_Width";
            this.tbx_Width.Size = new System.Drawing.Size(59, 22);
            this.tbx_Width.TabIndex = 4;
            this.tbx_Width.Text = "100";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Width.Location = new System.Drawing.Point(362, 15);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(45, 16);
            this.lbl_Width.TabIndex = 3;
            this.lbl_Width.Text = "Width";
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Color.Location = new System.Drawing.Point(520, 15);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(42, 16);
            this.lbl_Color.TabIndex = 5;
            this.lbl_Color.Text = "Color";
            // 
            // btn_ColorSelect
            // 
            this.btn_ColorSelect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ColorSelect.Location = new System.Drawing.Point(568, 12);
            this.btn_ColorSelect.Name = "btn_ColorSelect";
            this.btn_ColorSelect.Size = new System.Drawing.Size(75, 23);
            this.btn_ColorSelect.TabIndex = 6;
            this.btn_ColorSelect.Text = "Select";
            this.btn_ColorSelect.UseVisualStyleBackColor = true;
            // 
            // rbtn_Fill
            // 
            this.rbtn_Fill.AutoSize = true;
            this.rbtn_Fill.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_Fill.Location = new System.Drawing.Point(712, 12);
            this.rbtn_Fill.Name = "rbtn_Fill";
            this.rbtn_Fill.Size = new System.Drawing.Size(46, 20);
            this.rbtn_Fill.TabIndex = 7;
            this.rbtn_Fill.TabStop = true;
            this.rbtn_Fill.Text = "Fill";
            this.rbtn_Fill.UseVisualStyleBackColor = true;
            // 
            // rbtn_Outline
            // 
            this.rbtn_Outline.AutoSize = true;
            this.rbtn_Outline.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_Outline.Location = new System.Drawing.Point(712, 38);
            this.rbtn_Outline.Name = "rbtn_Outline";
            this.rbtn_Outline.Size = new System.Drawing.Size(72, 20);
            this.rbtn_Outline.TabIndex = 8;
            this.rbtn_Outline.TabStop = true;
            this.rbtn_Outline.Text = "Outline";
            this.rbtn_Outline.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.rbtn_Outline);
            this.Controls.Add(this.rbtn_Fill);
            this.Controls.Add(this.btn_ColorSelect);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.tbx_Width);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.tbx_Height);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.cbx_Figures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Figures;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.TextBox tbx_Height;
        private System.Windows.Forms.TextBox tbx_Width;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.Button btn_ColorSelect;
        private System.Windows.Forms.RadioButton rbtn_Fill;
        private System.Windows.Forms.RadioButton rbtn_Outline;
    }
}

