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

namespace DemoArray
{
    public partial class frmMatrices : Form
    {
        private int[,] mat;
        private int n;

        public frmMatrices()
        {
            InitializeComponent();
        }


        private void crearMatrizesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharMatriz();
            MostrarMatriz();
        }

        private void MostrarMatriz()
        {
            AlinharCabecalhos(lstMatriz);
            for (int i = 0; i < n; i++)
            {
                string[] fila = new string[n + 1];
                fila[0] = i.ToString();
                for (int j = 0; j < n; j++)
                {
                    fila[j + 1] = mat[i, j].ToString();
                }
                ListViewItem lsiFila = new ListViewItem(fila);
                lstMatriz.Items.Add(lsiFila);
            }
        }

        private void AlinharCabecalhos(ListView lista)
        {
            lista.View = View.Details;
            lista.Columns.Clear();
            lista.Items.Clear();

            lista.Columns.Add("Fila", 30, HorizontalAlignment.Right);
            for (int i = 0; i < n; i++)
            {
                lista.Columns.Add(i.ToString(), 30, HorizontalAlignment.Right);

            }
        }

        private void AlinharMatriz()
        {
            n = (int)nudMatriz.Value;
            mat = new int[n, n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = rd.Next(1, 100);

                }
            }
        }

        private void diagonalPrinciaplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharCabecalhos(lsvResultados);

            for (int i = 0; i < n; i++)
            {
                string[] fila = new string[n + 1];
                fila[0] = i.ToString();
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        fila[j + 1] = mat[i, j].ToString();
                    }
                    else
                    {
                        fila[j + 1] = "";
                    }

                }
                ListViewItem lsiFila = new ListViewItem(fila);
                lsvResultados.Items.Add(lsiFila);
            }
        }

        private void diagonalSecundáriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharCabecalhos(lsvResultados);

            for (int i = 0; i < n; i++)
            {
                string[] fila = new string[n + 1];
                fila[0] = i.ToString();
                for (int j = 0; j < n; j++)
                {
                    if (i == (n-j-1))
                    {
                        fila[j + 1] = mat[i, j].ToString();
                    }
                    else
                    {
                        fila[j + 1] = "";
                    }

                }
                ListViewItem lsiFila = new ListViewItem(fila);
                lsvResultados.Items.Add(lsiFila);
            }
        }

        private void triangularInferiorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharCabecalhos(lsvResultados);

            for (int i = 0; i < n; i++)
            {
                string[] fila = new string[n + 1];
                fila[0] = i.ToString();
                for (int j = 0; j < n; j++)
                {
                    if (i >= j)
                    {
                        fila[j + 1] = mat[i, j].ToString();
                    }
                    else
                    {
                        fila[j + 1] = "";
                    }

                }
                ListViewItem lsiFila = new ListViewItem(fila);
                lsvResultados.Items.Add(lsiFila);
            }
        }

        private void triangularSuperiorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharCabecalhos(lsvResultados);

            for (int i = 0; i < n; i++)
            {
                string[] fila = new string[n + 1];
                fila[0] = i.ToString();
                for (int j = 0; j < n; j++)
                {
                    if (i <= j)
                    {
                        fila[j + 1] = mat[i, j].ToString();
                    }
                    else
                    {
                        fila[j + 1] = "";
                    }

                }
                ListViewItem lsiFila = new ListViewItem(fila);
                lsvResultados.Items.Add(lsiFila);
            }
        }

        private void ordenarMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            foreach (int item in mat)
            {
                lista.Add(item);
            }
            lista.Sort();
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = (int)lista[k];
                    k++;
                }
            }
            MostrarMatriz();
        }
    }
}
