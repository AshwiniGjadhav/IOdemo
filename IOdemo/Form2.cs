﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Text.Json;
namespace IOdemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSalary_Click(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                //.dat --> data file  / binary file
                FileStream fs = new FileStream(@"D:\Cybage\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Binary data saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("data cannot save");
            }
        }



    private void btnBinaryRead_Click(object sender, EventArgs e)
        {
        try
        {
            Employee employee = new Employee();

            FileStream fs = new FileStream(@"D:\Cybage\emp.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter binary = new BinaryFormatter();
            employee = (Employee)binary.Deserialize(fs);
            txtId.Text = employee.Id.ToString();
            txtSalary.Text = employee.Salary.ToString();
            txtName.Text = employee.Name;
                fs.Close();
            }
        catch (Exception ex)
        {
              MessageBox.Show("data cannot read");
            }


    }

    private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);

            FileStream fs = new FileStream(@"D:\Cybage\emp.xml",FileMode.Create,FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, employee);
                fs.Close ();
                MessageBox.Show("data saved");
            }
            catch(Exception ex)
            {
                MessageBox.Show("data cannot save");
            }

        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee ();
                FileStream fs = new FileStream(@"D:\Cybage\emp.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml=new XmlSerializer(typeof(Employee));
                employee=(Employee)xml.Deserialize(fs); 
                txtId.Text=employee.Id.ToString();
                txtSalary.Text=employee.Salary.ToString();
                txtName.Text=employee.Name;
                fs.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);

                FileStream fs = new FileStream(@"D:\Cybage\emp.jos", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Employee>(fs, employee);
                fs.Close ();
                MessageBox.Show("Data saved in json");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Data cannot saved in json");
            }
            }
        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                FileStream fs = new FileStream(@"D:\Cybage\emp.json", FileMode.Open, FileAccess.Read);
                employee = JsonSerializer.Deserialize<Employee>(fs);
                txtId.Text = employee.Id.ToString();
                txtSalary.Text = employee.Salary.ToString();
                txtName.Text = employee.Name;
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                //.dat --> data file  / binary file
                FileStream fs = new FileStream(@"D:\Cybage\emp.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Soap data saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("data cannot save");
            }

        }

    private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();

                FileStream fs = new FileStream(@"D:\Cybage\emp.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                employee = (Employee)soap.Deserialize(fs);
                txtId.Text = employee.Id.ToString();
                txtSalary.Text = employee.Salary.ToString();
                txtName.Text = employee.Name;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("data cannot read");
            }

        }
    }
}
