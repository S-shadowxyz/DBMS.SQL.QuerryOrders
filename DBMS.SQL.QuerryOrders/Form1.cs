using Microsoft.Data.SqlClient;
using System.Data;

namespace DBMS.SQL.QuerryOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ประกาสตัวแปร
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        private void connectDB()
        {
            string server = @".\sqlexpress";
            string db = "northwind";
            string strCon = string.Format(@"Data Source={0};initial catalog={1};" + "Integrated security = true; Encrypt = false", server, db);
            connection = new SqlConnection(strCon);
            connection.Open();
        }

        private void disconnectDB()
        {
            connection.Close();
        }

        private void showData(string sql, DataGridView dgv)
        {
            adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectDB();
            String sqlQuery = "select o.OrderID,format( o.OrderDate, 'dd/MM/yy') [order date] ,format ( o.ShippedDate, 'dd/MM/yy') " +
                " [shipdate],s.CompanyName,e.FirstName + ' ' + e.LastName [employee name ],c.CompanyName,c.Phone,  " +
                " convert (decimal (10,2),sum(od.Quantity *  od.UnitPrice * (1-od.Discount))) [total price] from " +
                " Orders o join [Order Details] od on o.OrderID = od.OrderID join Shippers s on s.ShipperID = o.ShipVia " +
                " join Employees e on e.EmployeeID = o.EmployeeID join Customers c on c.CustomerID = o.CustomerID " +
                " group by  o.OrderID,o.OrderDate,o.ShippedDate,s.CompanyName,e.FirstName,e.LastName,c.CompanyName,c.Phone";
            showData(sqlQuery, dgvOrders);

        }

        private void dgvOrders_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = Convert.ToInt32(dgvOrders.CurrentRow.Cells[0].Value);
                String sqlQuery = " select p.ProductID, p.ProductName, SUM(od.Quantity) [qty], od.UnitPrice, CONCAT(od.Discount * 100, '%') AS Discount, " +
                                  " od.Quantity * od.UnitPrice [total price], od.Quantity * od.UnitPrice * (1 - od.Discount) [Discount], " +
                                  " (od.Quantity * od.UnitPrice) - (od.Quantity * od.UnitPrice * (1 - od.Discount)) [net price] " +
                                  " from Orders o " +
                                  " join [Order Details] od on o.OrderID = od.OrderID " +
                                  " join Products p on p.ProductID = od.ProductID " +
                                  " where o.OrderID = @id " +
                                  " group by p.ProductID, p.ProductName, od.UnitPrice, od.Discount, od.Quantity";

                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ogvDetail.DataSource = ds.Tables[0];

            }
        }
    }
}
