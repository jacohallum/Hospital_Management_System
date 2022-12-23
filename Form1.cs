using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
        public partial class HospitalManagementSysten : Form
        {
                public HospitalManagementSysten()
                {
                        InitializeComponent();
                }

                private void tabPage1_Click(object sender, EventArgs e)
                {

                }

                private void tblPatientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
                {
                        this.Validate();
                        this.tblPatientsBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

                }

                private void Form1_Load(object sender, EventArgs e)
                {
                        // TODO: This line of code loads data into the 'hospitalDataSet.tblVisit' table. You can move, or remove it, as needed.
                        this.tblVisitTableAdapter.Fill(this.hospitalDataSet.tblVisit);
                        // TODO: This line of code loads data into the 'hospitalDataSet.tblDoctor' table. You can move, or remove it, as needed.
                        this.tblDoctorTableAdapter.Fill(this.hospitalDataSet.tblDoctor);
                        // TODO: This line of code loads data into the 'hospitalDataSet.tblPatients' table. You can move, or remove it, as needed.
                        this.tblPatientsTableAdapter.Fill(this.hospitalDataSet.tblPatients);

                }
        }
}
