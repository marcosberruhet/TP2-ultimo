﻿
namespace UI.Desktop
{
    partial class Modulos
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
            this.tscModulos = new System.Windows.Forms.ToolStripContainer();
            this.tlModulos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvModulos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsModulos = new System.Windows.Forms.ToolStrip();
            this.IDModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejecuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscModulos.ContentPanel.SuspendLayout();
            this.tscModulos.TopToolStripPanel.SuspendLayout();
            this.tscModulos.SuspendLayout();
            this.tlModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            this.tsModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscModulos
            // 
            // 
            // tscModulos.ContentPanel
            // 
            this.tscModulos.ContentPanel.Controls.Add(this.tlModulos);
            this.tscModulos.ContentPanel.Size = new System.Drawing.Size(800, 423);
            this.tscModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscModulos.Location = new System.Drawing.Point(0, 0);
            this.tscModulos.Name = "tscModulos";
            this.tscModulos.Size = new System.Drawing.Size(800, 450);
            this.tscModulos.TabIndex = 0;
            this.tscModulos.Text = "toolStripContainer1";
            // 
            // tscModulos.TopToolStripPanel
            // 
            this.tscModulos.TopToolStripPanel.Controls.Add(this.tsModulos);
            // 
            // tlModulos
            // 
            this.tlModulos.ColumnCount = 2;
            this.tlModulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlModulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlModulos.Controls.Add(this.dgvModulos, 0, 0);
            this.tlModulos.Controls.Add(this.btnActualizar, 0, 1);
            this.tlModulos.Controls.Add(this.btnSalir, 1, 1);
            this.tlModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlModulos.Location = new System.Drawing.Point(0, 0);
            this.tlModulos.Name = "tlModulos";
            this.tlModulos.RowCount = 2;
            this.tlModulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlModulos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlModulos.Size = new System.Drawing.Size(800, 423);
            this.tlModulos.TabIndex = 0;
            // 
            // dgvModulos
            // 
            this.dgvModulos.AllowUserToAddRows = false;
            this.dgvModulos.AllowUserToDeleteRows = false;
            this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDModulo,
            this.Descripcion,
            this.Ejecuta});
            this.tlModulos.SetColumnSpan(this.dgvModulos, 2);
            this.dgvModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModulos.Location = new System.Drawing.Point(3, 3);
            this.dgvModulos.MultiSelect = false;
            this.dgvModulos.Name = "dgvModulos";
            this.dgvModulos.ReadOnly = true;
            this.dgvModulos.RowHeadersWidth = 51;
            this.dgvModulos.RowTemplate.Height = 24;
            this.dgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModulos.Size = new System.Drawing.Size(794, 388);
            this.dgvModulos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(636, 397);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsModulos
            // 
            this.tsModulos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsModulos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsModulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsModulos.Location = new System.Drawing.Point(4, 0);
            this.tsModulos.Name = "tsModulos";
            this.tsModulos.Size = new System.Drawing.Size(100, 27);
            this.tsModulos.TabIndex = 0;
            // 
            // IDModulo
            // 
            this.IDModulo.DataPropertyName = "ID";
            this.IDModulo.HeaderText = "ID Modulo";
            this.IDModulo.MinimumWidth = 6;
            this.IDModulo.Name = "IDModulo";
            this.IDModulo.ReadOnly = true;
            this.IDModulo.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // Ejecuta
            // 
            this.Ejecuta.DataPropertyName = "Ejecuta";
            this.Ejecuta.HeaderText = "Ejecuta";
            this.Ejecuta.MinimumWidth = 6;
            this.Ejecuta.Name = "Ejecuta";
            this.Ejecuta.ReadOnly = true;
            this.Ejecuta.Width = 125;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::UI.Desktop.Properties.Resources._1486395885_plus_80605;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(29, 24);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::UI.Desktop.Properties.Resources._1486395883_edit_80608;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(29, 24);
            this.tsbEditar.Text = "toolStripButton2";
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::UI.Desktop.Properties.Resources._1486395882_close_80604;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(29, 24);
            this.tsbEliminar.Text = "toolStripButton3";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tscModulos);
            this.Name = "Modulos";
            this.Text = "Modulos";
            this.Load += new System.EventHandler(this.Modulos_Load);
            this.tscModulos.ContentPanel.ResumeLayout(false);
            this.tscModulos.TopToolStripPanel.ResumeLayout(false);
            this.tscModulos.TopToolStripPanel.PerformLayout();
            this.tscModulos.ResumeLayout(false);
            this.tscModulos.PerformLayout();
            this.tlModulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            this.tsModulos.ResumeLayout(false);
            this.tsModulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscModulos;
        private System.Windows.Forms.TableLayoutPanel tlModulos;
        private System.Windows.Forms.DataGridView dgvModulos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsModulos;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejecuta;
    }
}