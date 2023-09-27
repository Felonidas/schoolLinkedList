using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Realice un sistema que permita el registro de alumnos de una institución que permita registrar,modificar, eliminar los mismos.
//Los datos de los alumnos son nombres, apellido, DNI, fecha denacimiento, dirección y teléfono.
//El sistema debe permitir:
//a. Registrar un nuevo alumno
//b. Eliminar alumno (en cualquier posición)
//c. Actualizar alumno (modificar algún dato)
//d. Agregar después del seleccionado
//e. Agregar antes del seleccionado
//f. Mostrar Listado de los alumnos actuales

namespace Ejercicio2TP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Node newNode = new Node();
            newNode.Name = textBox1.Text;
            newNode.Surname = textBox2.Text;
            newNode.DNI = textBox3.Text;
            newNode.Birthdate = textBox4.Text;
            newNode.Address = textBox5.Text;
            newNode.Phone = textBox6.Text;
            
            listBox1.Items.Add(newNode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Node newNode = new Node();
            newNode.Name = textBox1.Text;
            newNode.Surname = textBox2.Text;
            newNode.DNI = textBox3.Text;
            newNode.Birthdate = textBox4.Text;
            newNode.Address = textBox5.Text;
            newNode.Phone = textBox6.Text;

            listBox1.Items.Insert(listBox1.SelectedIndex,newNode);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Node newNode = new Node();
            newNode.Name = textBox1.Text;
            newNode.Surname = textBox2.Text;
            newNode.DNI = textBox3.Text;
            newNode.Birthdate = textBox4.Text;
            newNode.Address = textBox5.Text;
            newNode.Phone = textBox6.Text;

            listBox1.Items.Insert(listBox1.SelectedIndex+1, newNode);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Node newNode = new Node();
            newNode.Name = textBox1.Text;
            newNode.Surname = textBox2.Text;
            newNode.DNI = textBox3.Text;
            newNode.Birthdate = textBox4.Text;
            newNode.Address = textBox5.Text;
            newNode.Phone = textBox6.Text;

            listBox1.Items.Insert(listBox1.SelectedIndex, newNode);
        }
    }

    public class Node
    {
        public string Name;
        public string Surname;
        public string DNI;
        public string Birthdate;
        public string Address;
        public string Phone;
        public Node Next;

        public override string ToString()
        {
            return $"{Name}-{Surname}-{DNI}-{Birthdate}-{Address}-{Phone}";
        }
    }
}

