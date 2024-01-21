
namespace WORKHELPER
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notedataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workhelperDataSet = new WORKHELPER.workhelperDataSet();
            this.datenow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timelabel = new System.Windows.Forms.Label();
            this.timebox = new System.Windows.Forms.TextBox();
            this.alarmlabel = new System.Windows.Forms.Label();
            this.alarmy = new System.Windows.Forms.CheckBox();
            this.alarmn = new System.Windows.Forms.CheckBox();
            this.notelabel = new System.Windows.Forms.Label();
            this.notebox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.datenowtime = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.workhelperDataSet1 = new WORKHELPER.workhelperDataSet1();
            this.datanoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datanoteTableAdapter = new WORKHELPER.workhelperDataSet1TableAdapters.datanoteTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timenoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmynDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notedataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workhelperDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workhelperDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datanoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.datenoteDataGridViewTextBoxColumn,
            this.timenoteDataGridViewTextBoxColumn,
            this.alarmynDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.datanoteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(564, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // notedataBindingSource
            // 
            this.notedataBindingSource.DataMember = "notedata";
            this.notedataBindingSource.DataSource = this.workhelperDataSet;
            // 
            // workhelperDataSet
            // 
            this.workhelperDataSet.DataSetName = "workhelperDataSet";
            this.workhelperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datenow
            // 
            this.datenow.AutoSize = true;
            this.datenow.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datenow.Location = new System.Drawing.Point(849, 9);
            this.datenow.Name = "datenow";
            this.datenow.Size = new System.Drawing.Size(61, 20);
            this.datenow.TabIndex = 1;
            this.datenow.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datelabel.Location = new System.Drawing.Point(623, 62);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(46, 18);
            this.datelabel.TabIndex = 2;
            this.datelabel.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(737, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timelabel.Location = new System.Drawing.Point(623, 119);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(42, 18);
            this.timelabel.TabIndex = 4;
            this.timelabel.Text = "Saat";
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(737, 118);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(100, 22);
            this.timebox.TabIndex = 5;
            // 
            // alarmlabel
            // 
            this.alarmlabel.AutoSize = true;
            this.alarmlabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alarmlabel.Location = new System.Drawing.Point(625, 168);
            this.alarmlabel.Name = "alarmlabel";
            this.alarmlabel.Size = new System.Drawing.Size(52, 18);
            this.alarmlabel.TabIndex = 6;
            this.alarmlabel.Text = "Alarm";
            // 
            // alarmy
            // 
            this.alarmy.AutoSize = true;
            this.alarmy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alarmy.Location = new System.Drawing.Point(737, 168);
            this.alarmy.Name = "alarmy";
            this.alarmy.Size = new System.Drawing.Size(63, 22);
            this.alarmy.TabIndex = 7;
            this.alarmy.Text = "Evet";
            this.alarmy.UseVisualStyleBackColor = true;
            // 
            // alarmn
            // 
            this.alarmn.AutoSize = true;
            this.alarmn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alarmn.Location = new System.Drawing.Point(841, 167);
            this.alarmn.Name = "alarmn";
            this.alarmn.Size = new System.Drawing.Size(69, 22);
            this.alarmn.TabIndex = 8;
            this.alarmn.Text = "Hayır";
            this.alarmn.UseVisualStyleBackColor = true;
            // 
            // notelabel
            // 
            this.notelabel.AutoSize = true;
            this.notelabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notelabel.Location = new System.Drawing.Point(623, 212);
            this.notelabel.Name = "notelabel";
            this.notelabel.Size = new System.Drawing.Size(34, 18);
            this.notelabel.TabIndex = 9;
            this.notelabel.Text = "Not";
            // 
            // notebox
            // 
            this.notebox.Location = new System.Drawing.Point(737, 212);
            this.notebox.Multiline = true;
            this.notebox.Name = "notebox";
            this.notebox.Size = new System.Drawing.Size(316, 157);
            this.notebox.TabIndex = 10;
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.savebutton.Location = new System.Drawing.Point(829, 405);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(108, 31);
            this.savebutton.TabIndex = 11;
            this.savebutton.Text = "Kaydet";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearbutton.Location = new System.Drawing.Point(582, 472);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(108, 35);
            this.clearbutton.TabIndex = 12;
            this.clearbutton.Text = "Kayıt Sil";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // datenowtime
            // 
            this.datenowtime.AutoSize = true;
            this.datenowtime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datenowtime.Location = new System.Drawing.Point(974, 9);
            this.datenowtime.Name = "datenowtime";
            this.datenowtime.Size = new System.Drawing.Size(61, 20);
            this.datenowtime.TabIndex = 13;
            this.datenowtime.Text = "label1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WorkHELPER";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 76);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem1
            // 
            this.hideToolStripMenuItem1.Name = "hideToolStripMenuItem1";
            this.hideToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.hideToolStripMenuItem1.Text = "Hide";
            this.hideToolStripMenuItem1.Click += new System.EventHandler(this.hideToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(13, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Uygulama Gizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(198, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(296, 22);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Uygulamayı Otomatik Olarak Başlat";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // workhelperDataSet1
            // 
            this.workhelperDataSet1.DataSetName = "workhelperDataSet1";
            this.workhelperDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datanoteBindingSource
            // 
            this.datanoteBindingSource.DataMember = "datanote";
            this.datanoteBindingSource.DataSource = this.workhelperDataSet1;
            // 
            // datanoteTableAdapter
            // 
            this.datanoteTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "No";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // datenoteDataGridViewTextBoxColumn
            // 
            this.datenoteDataGridViewTextBoxColumn.DataPropertyName = "date_note";
            this.datenoteDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.datenoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datenoteDataGridViewTextBoxColumn.Name = "datenoteDataGridViewTextBoxColumn";
            this.datenoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timenoteDataGridViewTextBoxColumn
            // 
            this.timenoteDataGridViewTextBoxColumn.DataPropertyName = "time_note";
            this.timenoteDataGridViewTextBoxColumn.HeaderText = "Saat";
            this.timenoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timenoteDataGridViewTextBoxColumn.Name = "timenoteDataGridViewTextBoxColumn";
            this.timenoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alarmynDataGridViewTextBoxColumn
            // 
            this.alarmynDataGridViewTextBoxColumn.DataPropertyName = "alarmyn";
            this.alarmynDataGridViewTextBoxColumn.HeaderText = "Alarm";
            this.alarmynDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alarmynDataGridViewTextBoxColumn.Name = "alarmynDataGridViewTextBoxColumn";
            this.alarmynDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Not";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 533);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datenowtime);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.notelabel);
            this.Controls.Add(this.alarmn);
            this.Controls.Add(this.alarmy);
            this.Controls.Add(this.alarmlabel);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.datenow);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1104, 580);
            this.MinimumSize = new System.Drawing.Size(1104, 580);
            this.Name = "Form1";
            this.Text = "WorkHELPER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notedataBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workhelperDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datanoteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label datenow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.TextBox timebox;
        private System.Windows.Forms.Label alarmlabel;
        private System.Windows.Forms.CheckBox alarmy;
        private System.Windows.Forms.CheckBox alarmn;
        private System.Windows.Forms.Label notelabel;
        private System.Windows.Forms.TextBox notebox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button clearbutton;
        private workhelperDataSet workhelperDataSet;
        private System.Windows.Forms.BindingSource notedataBindingSource;
        private System.Windows.Forms.Label datenowtime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private workhelperDataSet1 workhelperDataSet1;
        private System.Windows.Forms.BindingSource datanoteBindingSource;
        private workhelperDataSet1TableAdapters.datanoteTableAdapter datanoteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timenoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmynDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}

