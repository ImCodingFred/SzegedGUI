using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzegedGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGVLOAD();
            l_jaratok.Text = "";
        }

        private void DGVLOAD()
        {
            DGV.Rows.Clear();
            db db = new db("SELECT jaratok.jaratszam, megallo.nev,jaratok.jarat_leiras ,jaratok.jarat_tipus FROM jaratok, megallo,utvonal WHERE jaratok.id = utvonal.jarat_id and utvonal.megallo_id = megallo.id  ORDER BY megallo.nev");
            while (db.Dr.Read())
            {
                string a;
                if (int.Parse(db.Dr[3].ToString()) == 1)
                {
                    a = "vonat";
                }
                else if (int.Parse(db.Dr[3].ToString()) == 2)
                {
                    a = "Villamos";
                }
                else
                {
                    a = "Troli";
                }
                DGV.Rows.Add(db.Dr[0], db.Dr[1], db.Dr[2], a);
            }
        }

        private void DGVLOAD(string be)
        {
            DGV.Rows.Clear();
            db db = new db($"SELECT jaratok.jaratszam, megallo.nev,jaratok.jarat_leiras ,jaratok.jarat_tipus FROM jaratok, megallo,utvonal WHERE jaratok.id = utvonal.jarat_id and utvonal.megallo_id = megallo.id and megallo.nev LIKE '{be}%' ORDER BY megallo.nev");
            while (db.Dr.Read())
            {
                string a;
                if (int.Parse(db.Dr[3].ToString()) == 1)
                {
                    a = "vonat";
                }
                else if (int.Parse(db.Dr[3].ToString()) == 2)
                {
                    a = "Villamos";
                }
                else
                {
                    a = "Troli";
                }
                DGV.Rows.Add(db.Dr[0], db.Dr[1], db.Dr[2], a);
            }
        }

        private void tb_kereses_TextChanged(object sender, EventArgs e)
        {
            DGVLOAD(tb_kereses.Text);
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db db = new db($"SELECT jaratok.jaratszam from jaratok, utvonal,megallo where jaratok.id = utvonal.jarat_id and utvonal.megallo_id = megallo.id and megallo.nev ='{DGV.Rows[e.RowIndex].Cells[1].Value.ToString()}' group by jaratszam ");
            string a = "";
            while (db.Dr.Read())
            {
                a += db.Dr[0].ToString()+" ";
            }
            l_jaratok.Text= $"megálló járatai: {a}";
        }
    }
}
