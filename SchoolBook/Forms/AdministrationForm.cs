using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchoolBook.Forms
{
    public partial class AdministrationForm : Form
    {
        private readonly string filePath;
        public AdministrationForm()
        {
            InitializeComponent();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filesDirectory = Path.Combine(baseDirectory, "Files");

            if(!Directory.Exists(filesDirectory))
            {
                Directory.CreateDirectory(filesDirectory);
            }

            filePath = Path.Combine(filesDirectory, "studentInfo.txt");

            StudentInfo();
        }

        private void StudentInfo()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] data = File.ReadAllLines(filePath);
                    
                    if (data.Length >= 8)
                    {
                        textBoxName.Text = data[0];
                        textBoxSurname.Text = data[1];
                        textBoxLastName.Text = data[2];
                        comboBoxGender.Text = data[3];
                        textBoxEGN.Text = data[4];
                        textBoxPhoneNumber.Text = data[5];
                        dateTimePicker.Text = data[6];
                        comboBoxPlaceOfBirth.Text = data[7];
                    } 
                    else
                    {
                        MessageBox.Show("Файлът съдържа недостатъчно данни.");
                    }
                }
                else
                {
                    MessageBox.Show("Фейлът не е намерен.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при зареждане на данните; " + ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxName.ReadOnly = false;
            textBoxSurname.ReadOnly = false;
            textBoxLastName.ReadOnly = false;
            textBoxEGN.ReadOnly = false;
            textBoxPhoneNumber.ReadOnly = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string lastname = textBoxLastName.Text;
            string gender = comboBoxGender.Text;
            string egn = textBoxEGN.Text;
            string phonenumber = textBoxPhoneNumber.Text;
            string dateofbirth = dateTimePicker.Text;
            string placeofbirth = comboBoxPlaceOfBirth.Text;

            string[] data = new string[8];
            data[0] = name; 
            data[1] = surname;
            data[2] = lastname; 
            data[3] = gender;
            data[4] = egn;
            data[5] = phonenumber;
            data[6] = dateofbirth;
            data[7] = placeofbirth;

            string filePath = "files/studentInfo.txt";

            try
            {
                File.WriteAllLines(filePath, data);
                MessageBox.Show("Данните са запазени успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при запазване на данните; " + ex.Message);
            }

        }
    }
}
