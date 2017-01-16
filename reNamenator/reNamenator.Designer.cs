namespace TheSortingHat
{
    partial class reNamenator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reNamenator));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_min = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_suffix = new System.Windows.Forms.TextBox();
            this.tb_prefix = new System.Windows.Forms.TextBox();
            this.cb_suffix = new System.Windows.Forms.CheckBox();
            this.cb_prefix = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_caseSame = new System.Windows.Forms.RadioButton();
            this.rb_caseLower = new System.Windows.Forms.RadioButton();
            this.rb_caseUpper = new System.Windows.Forms.RadioButton();
            this.rb_caseTitle = new System.Windows.Forms.RadioButton();
            this.lbl_casing = new System.Windows.Forms.Label();
            this.pnl_Status = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.lbl_dynamic_status = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.pnl_replaceTo = new System.Windows.Forms.Panel();
            this.cb_space = new System.Windows.Forms.CheckBox();
            this.cb_bracketsSquare = new System.Windows.Forms.CheckBox();
            this.cb_bracketsCurly = new System.Windows.Forms.CheckBox();
            this.cb_bracketsNormal = new System.Windows.Forms.CheckBox();
            this.tb_customChars = new System.Windows.Forms.TextBox();
            this.cb_customChars = new System.Windows.Forms.CheckBox();
            this.cb_multiSpace = new System.Windows.Forms.CheckBox();
            this.cb_comma = new System.Windows.Forms.CheckBox();
            this.cb_equals = new System.Windows.Forms.CheckBox();
            this.cb_dash = new System.Windows.Forms.CheckBox();
            this.cb_fullStop = new System.Windows.Forms.CheckBox();
            this.cb_underScore = new System.Windows.Forms.CheckBox();
            this.lbl_frequent = new System.Windows.Forms.Label();
            this.pnl_replaceWith = new System.Windows.Forms.Panel();
            this.tb_customCharReplace = new System.Windows.Forms.TextBox();
            this.rb_custom = new System.Windows.Forms.RadioButton();
            this.rb_nothing = new System.Windows.Forms.RadioButton();
            this.rb_space = new System.Windows.Forms.RadioButton();
            this.lbl_replace = new System.Windows.Forms.Label();
            this.pnl_names = new System.Windows.Forms.Panel();
            this.lbl_dynamic_NewName = new System.Windows.Forms.Label();
            this.lbl_dynamic_oldName = new System.Windows.Forms.Label();
            this.lbl_newName = new System.Windows.Forms.Label();
            this.lbl_oldName = new System.Windows.Forms.Label();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_main.SuspendLayout();
            this.pnl_min.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Status.SuspendLayout();
            this.pnl_replaceTo.SuspendLayout();
            this.pnl_replaceWith.SuspendLayout();
            this.pnl_names.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.AllowDrop = true;
            this.pnl_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_main.Controls.Add(this.pnl_min);
            this.pnl_main.Controls.Add(this.panel1);
            this.pnl_main.Controls.Add(this.panel2);
            this.pnl_main.Controls.Add(this.pnl_Status);
            this.pnl_main.Controls.Add(this.pnl_replaceTo);
            this.pnl_main.Controls.Add(this.pnl_replaceWith);
            this.pnl_main.Controls.Add(this.pnl_names);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(461, 384);
            this.pnl_main.TabIndex = 0;
            this.pnl_main.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_main_DragDrop);
            this.pnl_main.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_main_DragEnter);
            // 
            // pnl_min
            // 
            this.pnl_min.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_min.Controls.Add(this.btn_min);
            this.pnl_min.Location = new System.Drawing.Point(268, 243);
            this.pnl_min.Name = "pnl_min";
            this.pnl_min.Size = new System.Drawing.Size(181, 96);
            this.pnl_min.TabIndex = 12;
            // 
            // btn_min
            // 
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_min.Location = new System.Drawing.Point(3, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(175, 90);
            this.btn_min.TabIndex = 0;
            this.btn_min.Text = "Minimize";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.tb_suffix);
            this.panel1.Controls.Add(this.tb_prefix);
            this.panel1.Controls.Add(this.cb_suffix);
            this.panel1.Controls.Add(this.cb_prefix);
            this.panel1.Location = new System.Drawing.Point(126, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 96);
            this.panel1.TabIndex = 11;
            // 
            // tb_suffix
            // 
            this.tb_suffix.Enabled = false;
            this.tb_suffix.Location = new System.Drawing.Point(7, 69);
            this.tb_suffix.Name = "tb_suffix";
            this.tb_suffix.Size = new System.Drawing.Size(122, 20);
            this.tb_suffix.TabIndex = 19;
            this.tb_suffix.TextChanged += new System.EventHandler(this.tb_suffix_TextChanged);
            // 
            // tb_prefix
            // 
            this.tb_prefix.Enabled = false;
            this.tb_prefix.Location = new System.Drawing.Point(7, 22);
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(122, 20);
            this.tb_prefix.TabIndex = 18;
            this.tb_prefix.TextChanged += new System.EventHandler(this.tb_prefix_TextChanged);
            // 
            // cb_suffix
            // 
            this.cb_suffix.AutoSize = true;
            this.cb_suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_suffix.Location = new System.Drawing.Point(4, 48);
            this.cb_suffix.Name = "cb_suffix";
            this.cb_suffix.Size = new System.Drawing.Size(58, 17);
            this.cb_suffix.TabIndex = 1;
            this.cb_suffix.Text = "Suffix";
            this.cb_suffix.UseVisualStyleBackColor = true;
            this.cb_suffix.CheckedChanged += new System.EventHandler(this.cb_suffix_CheckedChanged);
            // 
            // cb_prefix
            // 
            this.cb_prefix.AutoSize = true;
            this.cb_prefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_prefix.Location = new System.Drawing.Point(4, 4);
            this.cb_prefix.Name = "cb_prefix";
            this.cb_prefix.Size = new System.Drawing.Size(58, 17);
            this.cb_prefix.TabIndex = 0;
            this.cb_prefix.Text = "Prefix";
            this.cb_prefix.UseVisualStyleBackColor = true;
            this.cb_prefix.CheckedChanged += new System.EventHandler(this.cb_prefix_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.rb_caseSame);
            this.panel2.Controls.Add(this.rb_caseLower);
            this.panel2.Controls.Add(this.rb_caseUpper);
            this.panel2.Controls.Add(this.rb_caseTitle);
            this.panel2.Controls.Add(this.lbl_casing);
            this.panel2.Location = new System.Drawing.Point(12, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 96);
            this.panel2.TabIndex = 10;
            // 
            // rb_caseSame
            // 
            this.rb_caseSame.AutoSize = true;
            this.rb_caseSame.Location = new System.Drawing.Point(6, 19);
            this.rb_caseSame.Name = "rb_caseSame";
            this.rb_caseSame.Size = new System.Drawing.Size(52, 17);
            this.rb_caseSame.TabIndex = 8;
            this.rb_caseSame.TabStop = true;
            this.rb_caseSame.Text = "Same";
            this.rb_caseSame.UseVisualStyleBackColor = true;
            // 
            // rb_caseLower
            // 
            this.rb_caseLower.AutoSize = true;
            this.rb_caseLower.Location = new System.Drawing.Point(6, 57);
            this.rb_caseLower.Name = "rb_caseLower";
            this.rb_caseLower.Size = new System.Drawing.Size(76, 17);
            this.rb_caseLower.TabIndex = 7;
            this.rb_caseLower.TabStop = true;
            this.rb_caseLower.Text = "lower case";
            this.rb_caseLower.UseVisualStyleBackColor = true;
            // 
            // rb_caseUpper
            // 
            this.rb_caseUpper.AutoSize = true;
            this.rb_caseUpper.Location = new System.Drawing.Point(6, 77);
            this.rb_caseUpper.Name = "rb_caseUpper";
            this.rb_caseUpper.Size = new System.Drawing.Size(93, 17);
            this.rb_caseUpper.TabIndex = 6;
            this.rb_caseUpper.TabStop = true;
            this.rb_caseUpper.Text = "UPPER CASE";
            this.rb_caseUpper.UseVisualStyleBackColor = true;
            // 
            // rb_caseTitle
            // 
            this.rb_caseTitle.AutoSize = true;
            this.rb_caseTitle.Location = new System.Drawing.Point(6, 39);
            this.rb_caseTitle.Name = "rb_caseTitle";
            this.rb_caseTitle.Size = new System.Drawing.Size(72, 17);
            this.rb_caseTitle.TabIndex = 5;
            this.rb_caseTitle.TabStop = true;
            this.rb_caseTitle.Text = "Title Case";
            this.rb_caseTitle.UseVisualStyleBackColor = true;
            // 
            // lbl_casing
            // 
            this.lbl_casing.AutoSize = true;
            this.lbl_casing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casing.Location = new System.Drawing.Point(3, 3);
            this.lbl_casing.Name = "lbl_casing";
            this.lbl_casing.Size = new System.Drawing.Size(45, 13);
            this.lbl_casing.TabIndex = 4;
            this.lbl_casing.Text = "Casing";
            // 
            // pnl_Status
            // 
            this.pnl_Status.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Status.Controls.Add(this.btn_about);
            this.pnl_Status.Controls.Add(this.lbl_dynamic_status);
            this.pnl_Status.Controls.Add(this.lbl_status);
            this.pnl_Status.Location = new System.Drawing.Point(12, 345);
            this.pnl_Status.Name = "pnl_Status";
            this.pnl_Status.Size = new System.Drawing.Size(437, 27);
            this.pnl_Status.TabIndex = 8;
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_about.Location = new System.Drawing.Point(369, 2);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(61, 23);
            this.btn_about.TabIndex = 3;
            this.btn_about.Text = "About";
            this.toolTips.SetToolTip(this.btn_about, "About The Sorting Hat");
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // lbl_dynamic_status
            // 
            this.lbl_dynamic_status.AutoSize = true;
            this.lbl_dynamic_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dynamic_status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_dynamic_status.Location = new System.Drawing.Point(48, 7);
            this.lbl_dynamic_status.Name = "lbl_dynamic_status";
            this.lbl_dynamic_status.Size = new System.Drawing.Size(146, 13);
            this.lbl_dynamic_status.TabIndex = 1;
            this.lbl_dynamic_status.Text = "Ready! - Drop Files or Folders";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(6, 7);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(47, 13);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Status:";
            // 
            // pnl_replaceTo
            // 
            this.pnl_replaceTo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_replaceTo.Controls.Add(this.cb_space);
            this.pnl_replaceTo.Controls.Add(this.cb_bracketsSquare);
            this.pnl_replaceTo.Controls.Add(this.cb_bracketsCurly);
            this.pnl_replaceTo.Controls.Add(this.cb_bracketsNormal);
            this.pnl_replaceTo.Controls.Add(this.tb_customChars);
            this.pnl_replaceTo.Controls.Add(this.cb_customChars);
            this.pnl_replaceTo.Controls.Add(this.cb_multiSpace);
            this.pnl_replaceTo.Controls.Add(this.cb_comma);
            this.pnl_replaceTo.Controls.Add(this.cb_equals);
            this.pnl_replaceTo.Controls.Add(this.cb_dash);
            this.pnl_replaceTo.Controls.Add(this.cb_fullStop);
            this.pnl_replaceTo.Controls.Add(this.cb_underScore);
            this.pnl_replaceTo.Controls.Add(this.lbl_frequent);
            this.pnl_replaceTo.Location = new System.Drawing.Point(12, 63);
            this.pnl_replaceTo.Name = "pnl_replaceTo";
            this.pnl_replaceTo.Size = new System.Drawing.Size(437, 120);
            this.pnl_replaceTo.TabIndex = 7;
            // 
            // cb_space
            // 
            this.cb_space.AutoSize = true;
            this.cb_space.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_space.Location = new System.Drawing.Point(6, 72);
            this.cb_space.Name = "cb_space";
            this.cb_space.Size = new System.Drawing.Size(69, 17);
            this.cb_space.TabIndex = 17;
            this.cb_space.Text = "Space [ ]";
            this.cb_space.UseVisualStyleBackColor = true;
            // 
            // cb_bracketsSquare
            // 
            this.cb_bracketsSquare.AutoSize = true;
            this.cb_bracketsSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bracketsSquare.Location = new System.Drawing.Point(304, 70);
            this.cb_bracketsSquare.Name = "cb_bracketsSquare";
            this.cb_bracketsSquare.Size = new System.Drawing.Size(129, 17);
            this.cb_bracketsSquare.TabIndex = 16;
            this.cb_bracketsSquare.Text = "Square Brackets [ [ ] ]";
            this.cb_bracketsSquare.UseVisualStyleBackColor = true;
            // 
            // cb_bracketsCurly
            // 
            this.cb_bracketsCurly.AutoSize = true;
            this.cb_bracketsCurly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bracketsCurly.Location = new System.Drawing.Point(304, 47);
            this.cb_bracketsCurly.Name = "cb_bracketsCurly";
            this.cb_bracketsCurly.Size = new System.Drawing.Size(120, 17);
            this.cb_bracketsCurly.TabIndex = 15;
            this.cb_bracketsCurly.Text = "Curly Brackets [ { } ]";
            this.cb_bracketsCurly.UseVisualStyleBackColor = true;
            // 
            // cb_bracketsNormal
            // 
            this.cb_bracketsNormal.AutoSize = true;
            this.cb_bracketsNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bracketsNormal.Location = new System.Drawing.Point(161, 72);
            this.cb_bracketsNormal.Name = "cb_bracketsNormal";
            this.cb_bracketsNormal.Size = new System.Drawing.Size(92, 17);
            this.cb_bracketsNormal.TabIndex = 14;
            this.cb_bracketsNormal.Text = "Brackets [ ( ) ]";
            this.cb_bracketsNormal.UseVisualStyleBackColor = true;
            // 
            // tb_customChars
            // 
            this.tb_customChars.Enabled = false;
            this.tb_customChars.Location = new System.Drawing.Point(127, 91);
            this.tb_customChars.Name = "tb_customChars";
            this.tb_customChars.Size = new System.Drawing.Size(303, 20);
            this.tb_customChars.TabIndex = 1;
            this.tb_customChars.TextChanged += new System.EventHandler(this.tb_customChars_TextChanged);
            // 
            // cb_customChars
            // 
            this.cb_customChars.AutoSize = true;
            this.cb_customChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_customChars.Location = new System.Drawing.Point(6, 93);
            this.cb_customChars.Name = "cb_customChars";
            this.cb_customChars.Size = new System.Drawing.Size(118, 17);
            this.cb_customChars.TabIndex = 7;
            this.cb_customChars.Text = "Custom Characters:";
            this.cb_customChars.UseVisualStyleBackColor = true;
            this.cb_customChars.CheckedChanged += new System.EventHandler(this.cb_customChars_CheckedChanged);
            // 
            // cb_multiSpace
            // 
            this.cb_multiSpace.AutoSize = true;
            this.cb_multiSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_multiSpace.Location = new System.Drawing.Point(304, 24);
            this.cb_multiSpace.Name = "cb_multiSpace";
            this.cb_multiSpace.Size = new System.Drawing.Size(122, 17);
            this.cb_multiSpace.TabIndex = 13;
            this.cb_multiSpace.Text = "Multiple Spaces [    ]";
            this.cb_multiSpace.UseVisualStyleBackColor = true;
            // 
            // cb_comma
            // 
            this.cb_comma.AutoSize = true;
            this.cb_comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_comma.Location = new System.Drawing.Point(161, 47);
            this.cb_comma.Name = "cb_comma";
            this.cb_comma.Size = new System.Drawing.Size(79, 17);
            this.cb_comma.TabIndex = 12;
            this.cb_comma.Text = "Comma [ , ]";
            this.cb_comma.UseVisualStyleBackColor = true;
            // 
            // cb_equals
            // 
            this.cb_equals.AutoSize = true;
            this.cb_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_equals.Location = new System.Drawing.Point(161, 24);
            this.cb_equals.Name = "cb_equals";
            this.cb_equals.Size = new System.Drawing.Size(79, 17);
            this.cb_equals.TabIndex = 11;
            this.cb_equals.Text = "Equals [ = ]";
            this.cb_equals.UseVisualStyleBackColor = true;
            // 
            // cb_dash
            // 
            this.cb_dash.AutoSize = true;
            this.cb_dash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dash.Location = new System.Drawing.Point(6, 56);
            this.cb_dash.Name = "cb_dash";
            this.cb_dash.Size = new System.Drawing.Size(69, 17);
            this.cb_dash.TabIndex = 10;
            this.cb_dash.Text = "Dash [ - ]";
            this.cb_dash.UseVisualStyleBackColor = true;
            // 
            // cb_fullStop
            // 
            this.cb_fullStop.AutoSize = true;
            this.cb_fullStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_fullStop.Location = new System.Drawing.Point(6, 40);
            this.cb_fullStop.Name = "cb_fullStop";
            this.cb_fullStop.Size = new System.Drawing.Size(80, 17);
            this.cb_fullStop.TabIndex = 9;
            this.cb_fullStop.Text = "Fullstop [ . ]";
            this.cb_fullStop.UseVisualStyleBackColor = true;
            // 
            // cb_underScore
            // 
            this.cb_underScore.AutoSize = true;
            this.cb_underScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_underScore.Location = new System.Drawing.Point(6, 24);
            this.cb_underScore.Name = "cb_underScore";
            this.cb_underScore.Size = new System.Drawing.Size(102, 17);
            this.cb_underScore.TabIndex = 8;
            this.cb_underScore.Text = "Underscore [ _ ]";
            this.cb_underScore.UseVisualStyleBackColor = true;
            // 
            // lbl_frequent
            // 
            this.lbl_frequent.AutoSize = true;
            this.lbl_frequent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frequent.Location = new System.Drawing.Point(3, 4);
            this.lbl_frequent.Name = "lbl_frequent";
            this.lbl_frequent.Size = new System.Drawing.Size(134, 13);
            this.lbl_frequent.TabIndex = 2;
            this.lbl_frequent.Text = "Characters to Replace";
            // 
            // pnl_replaceWith
            // 
            this.pnl_replaceWith.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_replaceWith.Controls.Add(this.tb_customCharReplace);
            this.pnl_replaceWith.Controls.Add(this.rb_custom);
            this.pnl_replaceWith.Controls.Add(this.rb_nothing);
            this.pnl_replaceWith.Controls.Add(this.rb_space);
            this.pnl_replaceWith.Controls.Add(this.lbl_replace);
            this.pnl_replaceWith.Location = new System.Drawing.Point(12, 189);
            this.pnl_replaceWith.Name = "pnl_replaceWith";
            this.pnl_replaceWith.Size = new System.Drawing.Size(437, 48);
            this.pnl_replaceWith.TabIndex = 6;
            // 
            // tb_customCharReplace
            // 
            this.tb_customCharReplace.Enabled = false;
            this.tb_customCharReplace.Location = new System.Drawing.Point(220, 19);
            this.tb_customCharReplace.Name = "tb_customCharReplace";
            this.tb_customCharReplace.Size = new System.Drawing.Size(210, 20);
            this.tb_customCharReplace.TabIndex = 17;
            this.tb_customCharReplace.TextChanged += new System.EventHandler(this.tb_customCharReplace_TextChanged);
            // 
            // rb_custom
            // 
            this.rb_custom.AutoSize = true;
            this.rb_custom.Location = new System.Drawing.Point(154, 20);
            this.rb_custom.Name = "rb_custom";
            this.rb_custom.Size = new System.Drawing.Size(60, 17);
            this.rb_custom.TabIndex = 6;
            this.rb_custom.TabStop = true;
            this.rb_custom.Text = "Custom";
            this.rb_custom.UseVisualStyleBackColor = true;
            this.rb_custom.CheckedChanged += new System.EventHandler(this.rb_custom_CheckedChanged);
            // 
            // rb_nothing
            // 
            this.rb_nothing.AutoSize = true;
            this.rb_nothing.Location = new System.Drawing.Point(80, 20);
            this.rb_nothing.Name = "rb_nothing";
            this.rb_nothing.Size = new System.Drawing.Size(71, 17);
            this.rb_nothing.TabIndex = 5;
            this.rb_nothing.TabStop = true;
            this.rb_nothing.Text = "Nothing []";
            this.rb_nothing.UseVisualStyleBackColor = true;
            this.rb_nothing.CheckedChanged += new System.EventHandler(this.rb_nothing_CheckedChanged);
            // 
            // rb_space
            // 
            this.rb_space.AutoSize = true;
            this.rb_space.Location = new System.Drawing.Point(6, 20);
            this.rb_space.Name = "rb_space";
            this.rb_space.Size = new System.Drawing.Size(68, 17);
            this.rb_space.TabIndex = 4;
            this.rb_space.TabStop = true;
            this.rb_space.Text = "Space [ ]";
            this.rb_space.UseVisualStyleBackColor = true;
            this.rb_space.CheckedChanged += new System.EventHandler(this.rb_space_CheckedChanged);
            // 
            // lbl_replace
            // 
            this.lbl_replace.AutoSize = true;
            this.lbl_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_replace.Location = new System.Drawing.Point(3, 3);
            this.lbl_replace.Name = "lbl_replace";
            this.lbl_replace.Size = new System.Drawing.Size(146, 13);
            this.lbl_replace.TabIndex = 3;
            this.lbl_replace.Text = "Replace Characters with";
            // 
            // pnl_names
            // 
            this.pnl_names.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_names.Controls.Add(this.lbl_dynamic_NewName);
            this.pnl_names.Controls.Add(this.lbl_dynamic_oldName);
            this.pnl_names.Controls.Add(this.lbl_newName);
            this.pnl_names.Controls.Add(this.lbl_oldName);
            this.pnl_names.Location = new System.Drawing.Point(12, 12);
            this.pnl_names.Name = "pnl_names";
            this.pnl_names.Size = new System.Drawing.Size(437, 44);
            this.pnl_names.TabIndex = 5;
            // 
            // lbl_dynamic_NewName
            // 
            this.lbl_dynamic_NewName.AutoSize = true;
            this.lbl_dynamic_NewName.Location = new System.Drawing.Point(75, 24);
            this.lbl_dynamic_NewName.Name = "lbl_dynamic_NewName";
            this.lbl_dynamic_NewName.Size = new System.Drawing.Size(0, 13);
            this.lbl_dynamic_NewName.TabIndex = 3;
            // 
            // lbl_dynamic_oldName
            // 
            this.lbl_dynamic_oldName.AutoSize = true;
            this.lbl_dynamic_oldName.Location = new System.Drawing.Point(75, 7);
            this.lbl_dynamic_oldName.Name = "lbl_dynamic_oldName";
            this.lbl_dynamic_oldName.Size = new System.Drawing.Size(0, 13);
            this.lbl_dynamic_oldName.TabIndex = 2;
            // 
            // lbl_newName
            // 
            this.lbl_newName.AutoSize = true;
            this.lbl_newName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newName.Location = new System.Drawing.Point(3, 24);
            this.lbl_newName.Name = "lbl_newName";
            this.lbl_newName.Size = new System.Drawing.Size(72, 13);
            this.lbl_newName.TabIndex = 1;
            this.lbl_newName.Text = "New Name:";
            // 
            // lbl_oldName
            // 
            this.lbl_oldName.AutoSize = true;
            this.lbl_oldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oldName.Location = new System.Drawing.Point(3, 7);
            this.lbl_oldName.Name = "lbl_oldName";
            this.lbl_oldName.Size = new System.Drawing.Size(66, 13);
            this.lbl_oldName.TabIndex = 0;
            this.lbl_oldName.Text = "Old Name:";
            // 
            // reNamenator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 384);
            this.Controls.Add(this.pnl_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(477, 423);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(477, 423);
            this.Name = "reNamenator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reNamenator";
            this.TopMost = true;
            this.pnl_main.ResumeLayout(false);
            this.pnl_min.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_Status.ResumeLayout(false);
            this.pnl_Status.PerformLayout();
            this.pnl_replaceTo.ResumeLayout(false);
            this.pnl_replaceTo.PerformLayout();
            this.pnl_replaceWith.ResumeLayout(false);
            this.pnl_replaceWith.PerformLayout();
            this.pnl_names.ResumeLayout(false);
            this.pnl_names.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_replaceTo;
        private System.Windows.Forms.CheckBox cb_bracketsSquare;
        private System.Windows.Forms.CheckBox cb_bracketsCurly;
        private System.Windows.Forms.CheckBox cb_bracketsNormal;
        private System.Windows.Forms.TextBox tb_customChars;
        private System.Windows.Forms.CheckBox cb_customChars;
        private System.Windows.Forms.CheckBox cb_multiSpace;
        private System.Windows.Forms.CheckBox cb_comma;
        private System.Windows.Forms.CheckBox cb_equals;
        private System.Windows.Forms.CheckBox cb_dash;
        private System.Windows.Forms.CheckBox cb_fullStop;
        private System.Windows.Forms.CheckBox cb_underScore;
        private System.Windows.Forms.Label lbl_frequent;
        private System.Windows.Forms.Panel pnl_replaceWith;
        private System.Windows.Forms.TextBox tb_customCharReplace;
        private System.Windows.Forms.RadioButton rb_custom;
        private System.Windows.Forms.RadioButton rb_nothing;
        private System.Windows.Forms.RadioButton rb_space;
        private System.Windows.Forms.Label lbl_replace;
        private System.Windows.Forms.Panel pnl_names;
        private System.Windows.Forms.Label lbl_dynamic_NewName;
        private System.Windows.Forms.Label lbl_dynamic_oldName;
        private System.Windows.Forms.Label lbl_newName;
        private System.Windows.Forms.Label lbl_oldName;
        private System.Windows.Forms.Panel pnl_Status;
        private System.Windows.Forms.Label lbl_dynamic_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_caseLower;
        private System.Windows.Forms.RadioButton rb_caseUpper;
        private System.Windows.Forms.RadioButton rb_caseTitle;
        private System.Windows.Forms.Label lbl_casing;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.RadioButton rb_caseSame;
        private System.Windows.Forms.CheckBox cb_space;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_suffix;
        private System.Windows.Forms.TextBox tb_prefix;
        private System.Windows.Forms.CheckBox cb_suffix;
        private System.Windows.Forms.CheckBox cb_prefix;
        private System.Windows.Forms.Panel pnl_min;
        private System.Windows.Forms.Button btn_min;
    }
}

