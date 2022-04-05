﻿
namespace PV_Dev
{
    partial class frmNColaborador
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbSucursal = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbArea = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSueldo = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.txtEdad = new DevExpress.XtraEditors.TextEdit();
            this.txtApellido = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSueldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbSucursal);
            this.groupControl1.Controls.Add(this.cmbArea);
            this.groupControl1.Controls.Add(this.txtSueldo);
            this.groupControl1.Controls.Add(this.txtDireccion);
            this.groupControl1.Controls.Add(this.txtEdad);
            this.groupControl1.Controls.Add(this.txtApellido);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Controls.Add(this.btnCancelar);
            this.groupControl1.Controls.Add(this.btnGuardar);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(396, 335);
            this.groupControl1.TabIndex = 0;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(123, 259);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSucursal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idSucursal", "id Sucursal", 90, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "direccion", 76, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbSucursal.Properties.DataSource = this.sucursalBindingSource;
            this.cmbSucursal.Properties.DisplayMember = "nombre";
            this.cmbSucursal.Properties.NullText = "";
            this.cmbSucursal.Properties.ValueMember = "idSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(150, 26);
            this.cmbSucursal.TabIndex = 15;
            // 
            // cmbArea
            // 
            this.cmbArea.Location = new System.Drawing.Point(123, 215);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbArea.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idArea", "id Area", 64, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion", 92, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbArea.Properties.DataSource = this.areaBindingSource;
            this.cmbArea.Properties.DisplayMember = "nombre";
            this.cmbArea.Properties.NullText = "";
            this.cmbArea.Properties.ValueMember = "idArea";
            this.cmbArea.Size = new System.Drawing.Size(150, 26);
            this.cmbArea.TabIndex = 14;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(123, 176);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(150, 26);
            this.txtSueldo.TabIndex = 13;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(123, 134);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(231, 26);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(123, 89);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(150, 26);
            this.txtEdad.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(123, 46);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(231, 26);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(265, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar:";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(133, 290);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 34);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar:";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 262);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 19);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Sucursal:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 218);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 19);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Area:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 179);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 19);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Sueldo:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Direccion:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Edad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Apellido:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre:";
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataSource = typeof(DAL.Area);
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(DAL.Sucursal);
            // 
            // frmNColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 359);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmNColaborador";
            this.Text = "Nuevo Colaborador";
            this.Load += new System.EventHandler(this.frmNColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSueldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbSucursal;
        private DevExpress.XtraEditors.LookUpEdit cmbArea;
        private DevExpress.XtraEditors.TextEdit txtSueldo;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.TextEdit txtEdad;
        private DevExpress.XtraEditors.TextEdit txtApellido;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private System.Windows.Forms.BindingSource areaBindingSource;
    }
}