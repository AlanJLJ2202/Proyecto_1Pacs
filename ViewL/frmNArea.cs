﻿using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewL
{
    public partial class frmNArea : Form
    {
        Area area = new Area();
        public int idArea = 0;
        private AreaBLL areaBLL = AreaBLL.Instance();
        public frmNArea()
        {
            InitializeComponent();
        }

        public frmNArea(int idArea)
        {

            InitializeComponent();
            this.idArea = idArea;
            area.idArea = idArea;
            txtNombre.Text = areaBLL.GetByID(area).nombre.ToString();
            txtDescripcion.Text = areaBLL.GetByID(area).descripcion.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
            if (idArea > 0)
            {
                if (areaBLL.Update(new BOL.Area()
                {
                    idArea = idArea,
                    nombre = txtNombre.Text,
                    descripcion = txtDescripcion.Text,
                }))
                {
                    MessageBox.Show("Area actualizada correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (areaBLL.Add(new BOL.Area()
                {
                    nombre = txtNombre.Text,
                    descripcion = txtDescripcion.Text,
                }))
                {
                    MessageBox.Show("Area ingresada correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }

            }
        }
        private void Clean()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmNArea_Load(object sender, EventArgs e)
        {

        }
    }
}