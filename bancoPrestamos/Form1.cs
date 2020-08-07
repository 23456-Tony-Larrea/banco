using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;    
namespace bancoPrestamos
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost; User Id=postgres; Password=123456;Database=cuentaReal;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
   

        private void txt_Correcto_Click(object sender, EventArgs e)
        {
            correctaTransferecia(textBox1.Text,textBox2.Text,textBox3.Text,descripcion.Text) ;

        }
        public void correctaTransferecia(string cuentaDebitar, string cuentaAcreditar, string saldo , string descripcion) 
        {
            conexion.Open();
            string query = "BEGIN";
            string query1 = $"update cuentaReal set monto=monto - {saldo}where numerocuenta='{cuentaDebitar}' and monto>={saldo}";
            string query2 = $"update cuentaReal set monto=monto + {saldo}where numerocuenta='{cuentaAcreditar}'";
            string query3 = $"insert into v_cuenta(fecha,saldo,transaccion,numeroCuenta,descripcion)values(current_date,{saldo},'debitado','{cuentaDebitar}','{descripcion}')";
            string query4 = $"insert into v_cuenta(fecha,saldo,transaccion,numeroCuenta,descripcion)values(current_date,{saldo},'acreditar','{cuentaAcreditar}','{descripcion}')";
            string query5 = "COMMIT";
            NpgsqlCommand funcion1 = new NpgsqlCommand(query, conexion);
            NpgsqlCommand funcion2 = new NpgsqlCommand(query1, conexion);
            NpgsqlCommand funcion3 = new NpgsqlCommand(query2, conexion);
            NpgsqlCommand funcion4 = new NpgsqlCommand(query3, conexion);
            NpgsqlCommand funcion5 = new NpgsqlCommand(query4, conexion);
            NpgsqlCommand funcion6 = new NpgsqlCommand(query5, conexion);

            funcion1.ExecuteNonQuery();
            funcion2.ExecuteNonQuery();
            funcion3.ExecuteNonQuery();
            funcion4.ExecuteNonQuery();
            funcion5.ExecuteNonQuery();
            funcion6.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("correcto");
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_error_Click(object sender, EventArgs e)
        {
            errorTransferencia(textBox1.Text, textBox2.Text, textBox3.Text);
        }
        public void errorTransferencia(string cuentaDebitar,string cuentaAcreditar ,string saldo ) 
        {
            conexion.Open();
            string query = "BEGIN";
            string query1 = $"update cuentaReal set monto=monto-{saldo}where numerocuenta='{cuentaDebitar}' and monto>={saldo}";
            string query2 = $"update cuentaReal set monto=monto+{saldo}where numerocuenta='{cuentaAcreditar}'";
            string query3 = "ROLLBACK";
            NpgsqlCommand funcion1 = new NpgsqlCommand(query, conexion);
            NpgsqlCommand funcion2 = new NpgsqlCommand(query1, conexion);
            NpgsqlCommand funcion3 = new NpgsqlCommand(query2, conexion);
            NpgsqlCommand funcion4 = new NpgsqlCommand(query3, conexion);
            funcion1.ExecuteNonQuery();
            funcion2.ExecuteNonQuery();
            funcion3.ExecuteNonQuery();
            funcion4.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("error");
        }

        /*public DataTable operacionCrud(string c_actividad,string c_numerocuenta, string c_nombre , string c_monto)
        {
            string query1 = $"select * from crud({c_actividad},'{c_numerocuenta}','{c_nombre}',{c_monto}) ";
            NpgsqlCommand ejecutar1= new NpgsqlCommand(query1, conexion);
            NpgsqlDataAdapter datos1 = new NpgsqlDataAdapter(ejecutar1);
            DataTable dataGridView1 = new DataTable();
            datos1.Fill(dataGridView1);
            return dataGridView1;
        }*/
      
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            operacionCrud(numerocuenta.Text, nombre.Text, monto.Text);
        }
        public void operacionCrud(string c_numerocuenta, string c_nombre, string c_monto)
        {
            conexion.Open();
            string query1 = $"SELECT * FROM crud('c','{c_numerocuenta}','{c_nombre}','{c_monto}') ";
            NpgsqlCommand ejecutar1 = new NpgsqlCommand(query1, conexion);
            ejecutar1.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("guardado");
        }
        public void operacionCrud1( string c_numerocuenta, string c_nombre, string c_monto)
        {
            conexion.Open();
            string query1 = $"SELECT * FROM crud('c','{c_numerocuenta}','{c_nombre}','{c_monto}') ";
            NpgsqlCommand ejecutar1 = new NpgsqlCommand(query1, conexion);
            ejecutar1.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("guardado");
        }
        public void operacionCrud2( string c_numerocuenta, string c_nombre, string c_monto)
        {
            conexion.Open();
            string query1 = $"SELECT * FROM crud('u','{c_numerocuenta}','{c_nombre}','{c_monto}') ";
            
            NpgsqlCommand ejecutar1 = new NpgsqlCommand(query1, conexion);
            ejecutar1.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("editar");
        }
        public void operacionCrud3(string c_numerocuenta, string c_nombre, string c_monto)
        {
            conexion.Open();
            string query1 = $"SELECT * FROM crud('d','{c_numerocuenta}','{c_nombre}','{c_monto}') ";
           
            NpgsqlCommand ejecutar1 = new NpgsqlCommand(query1, conexion);
            ejecutar1.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Elimando");
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void editar_Click(object sender, EventArgs e)
        {
            operacionCrud2(numerocuenta.Text, nombre.Text, monto.Text);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            operacionCrud3(numerocuenta.Text, nombre.Text, monto.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Consultar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cuentareal";
            NpgsqlCommand conector = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Busqueda(movimientos.Text);
            

        }
        public void Busqueda(string numero_cuenta) {

            string v = $"SELECT * FROM v_cuenta where numerocuenta='{movimientos.Text}'";
            string query = v;
            NpgsqlCommand conector = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            dataGridView2.DataSource = tabla.DefaultView;
        }

        private void moviminetos_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"file:///C:/Users/avsla/Downloads/reporteFinal.pdf";
            proceso.Start();
        }

    }
}
  