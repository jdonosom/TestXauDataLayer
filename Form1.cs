using System.Data;
using System.Data.Common;
using XauDataLayer;
using static Mysqlx.Crud.Order.Types;

namespace TestDataLayer
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                string version = "";
                BaseDatos db = new BaseDatos("secret", "SQLSERVER_credencial");

                string sSQL = "SELECT @@Version AS Version";
                db.Conectar();
                db.CrearComando(sSQL);

                DbDataReader dr = db.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);
                DataTableReader reader = new DataTableReader(dt);

                if (reader.Read())
                {
                    version = reader.IsDBNull(reader.GetOrdinal("Version")) ? "" : reader.GetString(reader.GetOrdinal("Version"));
                }
                db.Desconectar();

                MessageBox.Show($"{version}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConectarJson_Click(object sender, EventArgs e)
        {
            try
            {
                string version = "";
                BaseDatos db = new BaseDatos();

                string sSQL = "SELECT @@Version AS Version";
                db.Conectar();
                db.CrearComando(sSQL);

                DbDataReader dr = db.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);
                DataTableReader reader = new DataTableReader(dt);

                if (reader.Read())
                {
                    version = reader.IsDBNull(reader.GetOrdinal("Version")) ? "" : reader.GetString(reader.GetOrdinal("Version"));
                }
                db.Desconectar();

                MessageBox.Show($"{version}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConectarApp_Click(object sender, EventArgs e)
        {
            try
            {
                string version = "";
                BaseDatos db = new BaseDatos(server: ".", port: "1433", username: "sa", password: "View1210", provider: "System.Data.SqlClient", database: "Farmacia");

                string sSQL = "SELECT @@Version AS Version";
                db.Conectar();
                db.CrearComando(sSQL);

                DbDataReader dr = db.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);
                DataTableReader reader = new DataTableReader(dt);

                if (reader.Read())
                {
                    version = reader.IsDBNull(reader.GetOrdinal("Version")) ? "" : reader.GetString(reader.GetOrdinal("Version"));
                }
                db.Desconectar();

                MessageBox.Show($"{version}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConectarVarMySQL_Click(object sender, EventArgs e)
        {
            try
            {
                string version = "";
                BaseDatos db = new BaseDatos("secret", "MySQL_credencial");

                string sSQL = "SELECT Version() AS Version";
                db.Conectar();
                db.CrearComando(sSQL);

                DbDataReader dr = db.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);
                DataTableReader reader = new DataTableReader(dt);

                if (reader.Read())
                {
                    version = reader.IsDBNull(reader.GetOrdinal("Version")) ? "" : reader.GetString(reader.GetOrdinal("Version"));
                }
                db.Desconectar();

                MessageBox.Show($"MySQL Versión {version}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConectarJsonMySQL_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDatos db = new BaseDatos();
                string sSQL = "SELECT 1 AS Escalar";
                db.Conectar();
                db.CrearComando(sSQL);
                int valor = (int)db.EjecutarEscalar();
                db.Desconectar();

                MessageBox.Show(valor.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConectarAppMySQL_Click(object sender, EventArgs e)
        {
            try
            {
                string version = "";
                BaseDatos db = new BaseDatos(server: "localhost", port: "13306", username: "root", password: "View1210", provider: "MySql.Data.MySqlClient", database: "Asociacion");

                string sSQL = "SELECT Version() AS Version";
                db.Conectar();
                db.CrearComando(sSQL);

                DbDataReader dr = db.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);
                DataTableReader reader = new DataTableReader(dt);

                if (reader.Read())
                {
                    version = reader.IsDBNull(reader.GetOrdinal("Version")) ? "" : reader.GetString(reader.GetOrdinal("Version"));
                }
                db.Desconectar();

                MessageBox.Show($"MySQL Versión {version}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
