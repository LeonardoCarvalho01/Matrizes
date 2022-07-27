namespace DemoArray
{
    partial class frmMatrices
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMatrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spcContainer = new System.Windows.Forms.SplitContainer();
            this.lstMatriz = new System.Windows.Forms.ListView();
            this.nudMatriz = new System.Windows.Forms.NumericUpDown();
            this.lblNum = new System.Windows.Forms.Label();
            this.lsvResultados = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.diagonalPrinciaplToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalSecundáriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangularInferiorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangularSuperiorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarMatrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).BeginInit();
            this.spcContainer.Panel1.SuspendLayout();
            this.spcContainer.Panel2.SuspendLayout();
            this.spcContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(878, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearMatrizesToolStripMenuItem,
            this.diagonalPrinciaplToolStripMenuItem,
            this.diagonalSecundáriaToolStripMenuItem,
            this.triangularInferiorToolStripMenuItem,
            this.triangularSuperiorToolStripMenuItem,
            this.ordenarMatrizToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // crearMatrizesToolStripMenuItem
            // 
            this.crearMatrizesToolStripMenuItem.Name = "crearMatrizesToolStripMenuItem";
            this.crearMatrizesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.crearMatrizesToolStripMenuItem.Text = "Crear Matrizes";
            this.crearMatrizesToolStripMenuItem.Click += new System.EventHandler(this.crearMatrizesToolStripMenuItem_Click);
            // 
            // spcContainer
            // 
            this.spcContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcContainer.Location = new System.Drawing.Point(0, 24);
            this.spcContainer.Name = "spcContainer";
            // 
            // spcContainer.Panel1
            // 
            this.spcContainer.Panel1.Controls.Add(this.lstMatriz);
            this.spcContainer.Panel1.Controls.Add(this.nudMatriz);
            this.spcContainer.Panel1.Controls.Add(this.lblNum);
            // 
            // spcContainer.Panel2
            // 
            this.spcContainer.Panel2.Controls.Add(this.lsvResultados);
            this.spcContainer.Panel2.Controls.Add(this.label1);
            this.spcContainer.Size = new System.Drawing.Size(878, 475);
            this.spcContainer.SplitterDistance = 417;
            this.spcContainer.TabIndex = 1;
            // 
            // lstMatriz
            // 
            this.lstMatriz.Location = new System.Drawing.Point(3, 37);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(407, 414);
            this.lstMatriz.TabIndex = 2;
            this.lstMatriz.UseCompatibleStateImageBehavior = false;
            // 
            // nudMatriz
            // 
            this.nudMatriz.Location = new System.Drawing.Point(103, 11);
            this.nudMatriz.Name = "nudMatriz";
            this.nudMatriz.Size = new System.Drawing.Size(73, 20);
            this.nudMatriz.TabIndex = 1;
            this.nudMatriz.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(10, 13);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(87, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Ordem da Matriz:";
            // 
            // lsvResultados
            // 
            this.lsvResultados.Location = new System.Drawing.Point(3, 37);
            this.lsvResultados.Name = "lsvResultados";
            this.lsvResultados.Size = new System.Drawing.Size(450, 414);
            this.lsvResultados.TabIndex = 3;
            this.lsvResultados.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultados: ";
            // 
            // diagonalPrinciaplToolStripMenuItem
            // 
            this.diagonalPrinciaplToolStripMenuItem.Name = "diagonalPrinciaplToolStripMenuItem";
            this.diagonalPrinciaplToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.diagonalPrinciaplToolStripMenuItem.Text = "Diagonal Princiapl";
            this.diagonalPrinciaplToolStripMenuItem.Click += new System.EventHandler(this.diagonalPrinciaplToolStripMenuItem_Click);
            // 
            // diagonalSecundáriaToolStripMenuItem
            // 
            this.diagonalSecundáriaToolStripMenuItem.Name = "diagonalSecundáriaToolStripMenuItem";
            this.diagonalSecundáriaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.diagonalSecundáriaToolStripMenuItem.Text = "Diagonal Secundária";
            this.diagonalSecundáriaToolStripMenuItem.Click += new System.EventHandler(this.diagonalSecundáriaToolStripMenuItem_Click);
            // 
            // triangularInferiorToolStripMenuItem
            // 
            this.triangularInferiorToolStripMenuItem.Name = "triangularInferiorToolStripMenuItem";
            this.triangularInferiorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.triangularInferiorToolStripMenuItem.Text = "Triangular Inferior";
            this.triangularInferiorToolStripMenuItem.Click += new System.EventHandler(this.triangularInferiorToolStripMenuItem_Click);
            // 
            // triangularSuperiorToolStripMenuItem
            // 
            this.triangularSuperiorToolStripMenuItem.Name = "triangularSuperiorToolStripMenuItem";
            this.triangularSuperiorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.triangularSuperiorToolStripMenuItem.Text = "Triangular Superior ";
            this.triangularSuperiorToolStripMenuItem.Click += new System.EventHandler(this.triangularSuperiorToolStripMenuItem_Click);
            // 
            // ordenarMatrizToolStripMenuItem
            // 
            this.ordenarMatrizToolStripMenuItem.Name = "ordenarMatrizToolStripMenuItem";
            this.ordenarMatrizToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ordenarMatrizToolStripMenuItem.Text = "Ordenar Matriz";
            this.ordenarMatrizToolStripMenuItem.Click += new System.EventHandler(this.ordenarMatrizToolStripMenuItem_Click);
            // 
            // frmMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 499);
            this.Controls.Add(this.spcContainer);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmMatrices";
            this.Text = "Matrizes";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.spcContainer.Panel1.ResumeLayout(false);
            this.spcContainer.Panel1.PerformLayout();
            this.spcContainer.Panel2.ResumeLayout(false);
            this.spcContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).EndInit();
            this.spcContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearMatrizesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer spcContainer;
        private System.Windows.Forms.ListView lstMatriz;
        private System.Windows.Forms.NumericUpDown nudMatriz;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ListView lsvResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem diagonalPrinciaplToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalSecundáriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangularInferiorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangularSuperiorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarMatrizToolStripMenuItem;
    }
}

